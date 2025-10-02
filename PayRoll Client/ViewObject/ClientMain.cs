using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using System.Runtime.CompilerServices;

namespace PayRoll_Client.View
{
    public partial class ClientMain : UserControl
    {
        public ClientMain()
        {
            InitializeComponent();
            
            clockinBtn.Text = "打卡";
            SubmitBtn.Text = "笔记";
            clockoutBtn.Text = "下班";
            infoBtn.Text = "信息";
            Reportbtn.Text = "报告";
            LogoutBtn.Text = "登出";
        }


        int baseSize = 25;
        void Based(Button ct)
        {
            ct.Based(baseSize);
        }

        void BasedTitle()
        {
            if (IsClocked)
            {
                pjbtn.BasedAmber(baseSize);
                nmbtn.BasedAmber(baseSize);
                durabtn.BasedAmber(baseSize);
                tmbtn.BasedAmber(baseSize);
                dtbtn.BasedAmber(baseSize);
            }
            else
            {
                pjbtn.BasedTitle(baseSize);
                nmbtn.BasedTitle(baseSize);
                durabtn.BasedTitle(baseSize);
                tmbtn.BasedTitle(baseSize);
                dtbtn.BasedTitle(baseSize);
            }

        }


        private void ClientMain_Load(object sender, EventArgs e)
        {
            Based(clockinBtn);
            Based(clockoutBtn);
            Based(SubmitBtn);
            Based(infoBtn);
            Based(Reportbtn);


            BasedTitle();

            LogoutBtn.Based(baseSize);
            nexHour.Based(baseSize);
            nexDate.Based(baseSize);

            nexHour.Text = "+1小时";
            nexDate.Text = "+1天";

            nexHour.Click += (a, b) =>
            {
                VClockService.NextHour();
                TimeRefresh();
            };

            nexDate.Click += (a, b) =>
            {
                VClockService.NextDate();
                TimeRefresh();
            };

            Polling();
        }

        async void Polling()
        {
            while (true)
            {
                TimeRefresh();
                await Task.Delay(1000);
            }
        }


        void TimeRefresh()
        {
            Employee = Employee;
            Project = Project;
            var res = ClockinService.Refresh();
            CurDateTime = res.c2;
            Dura = res.dura;
        }

        public void InitFront()
        {
            Project = null;
            IsClocked = false;
            if (Employee == null) return;
            BackFront();
        }
        public void BackFront()
        {
            if (Employee == null) return;
            TimeRefresh();
            BringToFront();
        }

        private void ClockInBtn_Click(object sender, EventArgs e)
        {
            if (IsClocked)
            {
                var b = ConfirmBox.Confirm("请问您是工作狂吗？","我不工作就会死","我点错了？");
                if (b)
                    ErrorBox.Error("牛的。");
                else
                    ErrorBox.Error("是的，您已经打卡了。");
                return;
            }
            var emp = Employee;
            if (emp == null) return;
            if (emp.Fired == 1)
            {
                ErrorBox.Error("被爆炒的人还会打工吗……");
                return;
            }
            FormCtr.JoinProjectTake.Front();
        }

        public void SureClockin()
        {
            ClockinService.ClockIn();
            IsClocked = true;
            BackFront();
        }

        private void ClockOutBtn_Click(object sender, EventArgs e)
        {
            if (!IsClocked)
            {
                if (ConfirmBox.Confirm("请问您现在想下班吗？","现在、立刻、马上。","我忘记打卡了"))
                    if (ConfirmBox.Confirm("好吧，请把时间卡拿出来。","...","我好像没有打卡"))
                        ErrorBox.Error("又一个忘了打卡的雇员。");
                    else
                        ErrorBox.Error("“果咩纳塞”");
                else
                    return;
                return;
            }
            ClockinService.ClockOut();
            var x = ClockinService.clockinTime;
            IsClocked = false;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (ClockinService.clockinTime != null)
                ClockOutBtn_Click(sender, e);
            FormCtr.LoginView.Front();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            FormCtr.Info.InitFront();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            FormCtr.NoteCRUDView.InitFront();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            FormCtr.ReportView.Front();
        }

        int dura;

        public int Dura
        {
            private get => dura;
            set
            {
                dura = value;
                durabtn.Text = $"工作小时数：{dura} ";
            }
        }

        public VirtualClock CurDateTime
        {
            private get => VClockService.Vclock;
            set
            {
                dtbtn.Text = value.VDateString();
                tmbtn.Text = value.VTimeString();
            }
        }

        bool _isClocked;
        public bool IsClocked
        {
            get => _isClocked;
            set
            {
                _isClocked = value;
                BasedTitle();
                TimeRefresh();
            }
        }

        public Project? Project
        {
            get => ClockinService.CurProject;
            set
            {
                if (value == null)
                    pjbtn.Text = "当前项目：无";
                else
                    pjbtn.Text = "当前项目：" + value.Name;
            }
        }

        public Employee? Employee
        {
            get => ClockinService.CurEmployee;
            set
            {
                if (value == null)
                    nmbtn.Text = "姓名：无";
                else
                    nmbtn.Text = "姓名：" + value.Name;
            }
        }

    }
}
