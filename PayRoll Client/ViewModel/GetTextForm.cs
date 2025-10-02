using Npgsql.TypeHandlers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayRoll_Client.View
{

    public partial class GetTextForm : Form
    {
        GetTextForm()
        {
            InitializeComponent();
            label1.Based(25);
            tb.Based(30);
            tb.Dock = DockStyle.Fill;
        }

        bool canceled = false;
        static GetTextForm form = new();
        public static Form fatherForm = null;

        TextType type = TextType.Text;

        static public bool TryGet<T>(string name, T? info, out double val, TextType type = TextType.Real)
        {
            form.SetMidLoc(fatherForm);
            form.label1.Text = name;
            form.type = type;
            form.tb.Text = Convert.ToString(info);

            form.canceled = true;
            form.ShowDialog();
            double.TryParse(form.tb.Text, out val);
            if (form.canceled) return false;
            return true;
        }

        static public bool TryGet<T>(string name, T? info, out int val, TextType type = TextType.Int)
        {
            form.SetMidLoc(fatherForm);
            form.label1.Text = name;
            form.type = type;
            form.tb.Text = Convert.ToString(info);

            form.canceled = true;
            form.ShowDialog();
            int.TryParse(form.tb.Text, out val);
            if (form.canceled) return false;
            return true;
        }

        static public bool TryGet<T>(string name, T? info, out string val, TextType type = TextType.Text)
        {
            form.SetMidLoc(fatherForm);
            form.label1.Text = name;
            form.type = type;
            form.tb.Text = Convert.ToString(info);

            form.canceled = true;
            form.ShowDialog();
            val = form.tb.Text;
            if (form.canceled) return false;
            return true;
        }
        static public bool TryGet<T>(string name, T? info, out DateTime val)
        {
            form.SetMidLoc(fatherForm);
            form.label1.Text = name;
            form.type = TextType.Date;
            form.tb.Text = Convert.ToString(info);

            form.canceled = true;
            form.ShowDialog();
            DateTime.TryParse(form.tb.Text, out val);
            if (form.canceled) return false;
            return true;
        }

        bool Correct()
        {
            return TypeCheck.Correct(label1.Text, tb.Text, type);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is '\r')
            {
                e.Handled = true;
                if (!Correct())
                {
                    tb.Text = "";
                    return;
                }
                canceled = false;
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

    }
}
