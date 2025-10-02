using Models;
using PayRoll_Admin.Control;
using PayRoll_Admin.Models;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using PayRoll_Client.View;
using System.Data;

namespace PayRoll_Admin.View
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            button2.BasedTitle(25);
            button2.Text = "管理员";
            tb.Based(25);
            log.Based(20);
            ex.Based(20);

            var m = "Art Assets".FindPath("秩序.png");
            if (m != null)
            {
                var pic = new Bitmap(new Bitmap(m), 100, 100);
                pictureBox1.Image = pb2.Image = pic;
            }

            tb.TextAlign = HorizontalAlignment.Left;

            button1.BasedTitle(25);
            button1.Text = "密码：";
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = ArtHelpers.tbSingle;

            tb.Dock = DockStyle.Top;
            tb.Height = 100;

            log.Text = "登录";
            ex.Text = "退出";

            log.BackColor = ArtHelpers.blue;
            log.FlatAppearance.BorderColor = ArtHelpers.gold;
            ex.BackColor = ArtHelpers.red;
            ex.FlatAppearance.BorderColor = ArtHelpers.gold;

            log.Click += Log_Click;
            ex.Click += Ex_Click;
            tb.KeyPress += Tb_KeyPress;
        }



        public void Front()
        {
            BringToFront();
        }

        private void Tb_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                Log_Click(sender, e);
            }
        }


        private void Log_Click(object? sender, EventArgs e)
        {

            if (tb.Text == Sql.Query<AdminPass>().First().Password)
            {
                AdminFormCtr.AdminMain.Front();
            }
            else
            {
                ErrorBox.Error("密码错误。\r\n不是他的生日，或许是我的生日？");
                Front();
            }
        }

        private void Ex_Click(object? sender, EventArgs e)
        {
            ErrorBox.Error("无尽的BUG在等着我......");
            AdminFormCtr.Close();
        }
    }
}
