using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Models;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using SqlSugar;
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
    public partial class LoginView : UserControl
    {
        public bool IsLogining { get; private set; } = true;

        const string desDefault = "你要的是这个金雇员，还是这个银雇员？\r\n\r\n我想要能干的雇员。";
        const string desDefault2 = "没有词条？看来她有成为路人女主的潜质。";

        public LoginView()
        {
            InitializeComponent();


            var m = "Art Assets".FindPath("风.png");
            if (m != null)
            {
                var pic = new Bitmap(new Bitmap(m), 100, 100);
                pictureBox1.Image = pic;
            }

            desBtn.BasedTitle(17);
            desBtn.TextAlign = ContentAlignment.TopLeft;
            desBtn.Text = desDefault;

            nameBtn.BasedTitle(25);
            nameBtn.Text = "雇员";
            tb.Based(25);
            tb.TextAlign = HorizontalAlignment.Left;
            tb.Dock = DockStyle.Top;
            tb.Height = 100;


            button1.BasedLab_SameBase(25);
            button1.Text = "密码：";
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = ArtHelpers.tbSingle;


            log.BasedChoosing(20);
            ex.BasedDelete(20);
            log.Text = "登录";
            ex.Text = "退出";

            idx = 0;
            IDcheck = 0;
            log.Click += Log_Click;
            ex.Click += Ex_Click;
            tb.KeyPress += Tb_KeyPress;
            nameBtn.Click += NameBtn_Click;
        }



        private void NameBtn_Click(object? sender, EventArgs e)
        {
            var emps = this.emps;
            bool b = GetEnumForm.TryGet("雇员", idx, out int ix, emps.Select(x => x.ID + "-" + x.Name).ToArray());
            if (!b) return;
            var des = Sql.Query<CharacterSetting>().First(x => emps[ix].Name == x.Name);
            if (des == null)
                desBtn.Text = desDefault2;
            else
                desBtn.Text = des.Descript;
            idx = ix;
            IDcheck = emps[ix].ID;
            nameBtn.Text = emps[ix].Name;
        }

        Employee[] emps => Sql.Query<Employee>().ToArray();
        int idx;
        int IDcheck;

        public void Front()
        {
            IsLogining = true;
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
            var emps = this.emps;
            if (IDcheck == 0)
            {
                ErrorBox.Error("‘空’雇员还在赶来的路上，或许他堵车了？");
                return;
            }
            if (emps.Length <= idx || emps[idx].ID != IDcheck)
            {
                ErrorBox.Error("你的雇员已被卷入虚空，或者有很小的可能，他（她）被爆炒了。");
                return;
            }
            if (tb.Text == emps[idx].Password)
            {
                ClockinService.CurEmployee = emps[idx];
                IsLogining = false;
                FormCtr.ClientMain.InitFront();
            }
            else
            {
                ErrorBox.Error("密码错误。\r\n一般来说，我会试试他的生日。");
                Front();
            }
        }
        private void Ex_Click(object? sender, EventArgs e)
        {
            if (ConfirmBox.Confirm("突然！你听到了一个女孩的声音……", "这里有我想要的那种场景吗？", "为何一切尚未结束？"))
                if (ConfirmBox.Confirm("撒由那拉", "我是柚子社的忠实粉丝", "可是这个程序没有装载语音模块"))
                    ErrorBox.Error("撒由那拉。");
                else
                    ErrorBox.Error("跟二次元不熟。\r\n\r\n真不熟。");
            else
                ErrorBox.Error("的确，这不是那种游戏。");
            FormCtr.Close();
        }

    }
}
