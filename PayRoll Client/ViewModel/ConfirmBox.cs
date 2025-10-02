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

namespace PayRoll_Client.View
{
    public partial class ConfirmBox : Form
    {
        public ConfirmBox()
        {
            InitializeComponent();
            Text = "Magic Text!";
            Width = 600;
            Height = 300;
            button1.BasedLab_SameBase(24);
            button1.FlatAppearance.BorderSize = 10;
            button2.BasedDelete();
            button3.BasedChoosing();
            

            button2.Click += Button2_Click;
            button3.Click += Button3_Click; ;

        }

        static ConfirmBox form = new();
        public static Form fatherForm = null;

        bool sure;
        public static bool Confirm(string message,string left = "确定", string right = "取消")
        {
            form.sure = false;
            form.SetMidLoc(fatherForm);
            form.button1.Text = message;
            form.button2.Text = left;
            form.button3.Text = right;
            form.ShowDialog();
            return form.sure;
        }


        private void Button3_Click(object? sender, EventArgs e)
        {
            sure = false;
            form.Close();
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            sure = true;
            form.Close();
        }
    }
}
