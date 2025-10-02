using PayRoll_Client.Controller;
using PayRoll_Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Client.View
{
    public partial class ErrorBox : Form
    {
        public ErrorBox()
        {
            InitializeComponent();
            button1.Based(24);
            button1.FlatAppearance.BorderSize = 10;
        }

        static ErrorBox form = new();
        public static Form fatherForm = null;

        public static void Error(string message)
        {
            if (form.Visible == true)
            {
                ConfirmBox.Confirm("BUG常有，而程序员不常有。", "世界上又少了一个程序员", "你已黔驴技穷");
                Task.Delay(3000).Wait();
                throw new Exception();
            }

            form.SetMidLoc(fatherForm);
            form.button1.Text = message;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Close();
        }

    }
}
