using Models;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dm.net.buffer.ByteArrayBuffer;

namespace PayRoll_Client.View
{
    public partial class GetEnumForm : Form
    {
        GetEnumForm()
        {
            InitializeComponent();
            label1.Based(25);
            cb.Based(25);
            cb.Dock = DockStyle.Top;
        }

        bool canceled ;
        static GetEnumForm form = new();
        public static Form fatherForm = null;

        static public bool TryGet(string name, int idx, out int val, string[] enums)
        {
            form.SetMidLoc(fatherForm);
            form.label1.Text = name;

            form.cb.Items.Clear();
            form.cb.Items.AddRange(enums);
            form.cb.SelectedIndex = idx;

            form.canceled = true;
            form.ShowDialog();
            val = form.cb.SelectedIndex;
            if (form.canceled) return false;
            return true;
        }

        static public bool TryGet<T, R>(string name, List<T> pros, Func<T, string> infos, R start, Func<T, R> firstEqual, out int idx)
            where R : IEquatable<R>
        {
            var pro = pros.FirstOrDefault(x => firstEqual(x).Equals(start));
            int i = 0;
            if (pro != null)
                i = pros.IndexOf(pro);
            return TryGet(name, i, out idx, pros.Select(infos).ToArray());
        }




        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                canceled = false;
                e.Handled = true;
                form.Close();
                return;
            }
            if (e.KeyChar == 27)
            {
                canceled = true;
                e.Handled = true;
                form.Close();
            }
        }

        private void GetTextForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1_KeyPress(sender, e);
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            canceled = false;
            form.Close();
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1_KeyPress(sender, e);
        }
    }
}
