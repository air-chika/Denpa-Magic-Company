using Models;
using PayRoll_Admin.Control;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Admin.View
{
    public partial class AdminMain : UserControl
    {
        const int basesize = 25;
        public AdminMain()
        {
            InitializeComponent();

            EmpMng.Text = "雇员管理";
            PjMng.Text = "项目管理";
            Report.Text = "雇员报告";
            Exit.Text = "退出";
            nextTime.Text = "+1小时";
            nextDate.Text = "+1天";

            EmpMng.Based(basesize);
            EmpMng.Click += (a, b) => AdminFormCtr.EmpCRUDView.InitFront();
            PjMng.Based(basesize);
            PjMng.Click += (a, b) => AdminFormCtr.ProjCRUDView.InitFront();
            Report.Based(basesize);
            Report.Click += (a, b) => AdminFormCtr.ReportTakesView.InitFront();

            tmBtn.BasedTitle(basesize);
            dtBtn.BasedTitle(basesize);

            nextTime.Based(basesize);
            nextDate.Based(basesize);



            Exit.Based(basesize);
            Exit.Click += (a, b) => AdminFormCtr.LoginView.Front();

            nextTime.Click += (_, _) =>
            {
                var vc = VClockService.NextHour();
                UpdateTime(vc);
            };

            nextDate.Click += (_, _) =>
            {
                var vc = VClockService.NextDate();
                UpdateTime(vc);
            };

            Polling();
        }

        void UpdateTime(VirtualClock vc)
        {
            tmBtn.Text = vc.VDateString();
            dtBtn.Text = vc.VTimeString();
        }

        async public void Polling()
        {
            while (true)
            {
                UpdateTime(VClockService.Vclock);
                await Task.Delay(1000);
            }
        }

        public void Front()
        {
            BringToFront();
        }
    }
}
