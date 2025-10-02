using Models;
using PayRoll_Admin.Control;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using PayRoll_Client.View;
using System.Data;
using System.Text;

namespace PayRoll_Admin.View
{
    public partial class AdminReport : UserControl
    {
        public AdminReport()
        {
            InitializeComponent();
            tb.Reported();

            hour.BasedAmberBtn();
            pay.BasedTitleBtn();

            back.Based();
            save.BasedTitleRBtn();

            hour.Text = "雇员工作时长";
            pay.Text = "雇员今年收入";
            save.Text = "保存至文件";
            back.Text = "返回主界面";

            back.Click += (a, b) => AdminFormCtr.AdminMain.Front();
            hour.Click += Hour_Click;
            pay.Click += Pay_Click;
            save.Click += Save_Click;

        }

        private void Save_Click(object? sender, EventArgs e)
        {
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
                File.WriteAllText(saveFileDialog.FileName, tb.Text);
        }

        private void Pay_Click(object? sender, EventArgs e)
        {
            var d2 = VClockService.Vclock.Date();
            var d1 = new DateTime(d2.Year, 1, 1);

            var sums1 = emps.Select(emp => Sql.Query<PayCheck>().Where(x =>
                x.EmployeeID == emp.ID
                && x.Date / 10000 == d2.Year
                ).Sum(x => x.RealWages));
            var sums2 = emps.Select(emp => Sql.Query<BankPayCheck>().Where(x =>
                x.EmployeeID == emp.ID
                && x.Date / 10000 == d2.Year
                ).Sum(x => x.RealWages));
            var sums = sums1.Zip(sums2, (a, b) => a + b);


            var ps = emps.Zip(sums).OrderByDescending(c => c.Second).ToList();

            sb = new();
            AddLine("今年收入");
            AddLine($"日期：  {d1.Str()}   至   {d2.Str()}");
            foreach (var p in ps)
                AddLine(p.First.Name + "：" + p.Second + "元");
            AddLine("结束.");
        }

        private void Hour_Click(object? sender, EventArgs e)
        {
            var d = VClockService.Vclock.Date();
            var time = d.Str();
            if (!GetTextForm.TryGet("开始日期", time, out DateTime d1))
                return;
            if (!GetTextForm.TryGet("结束日期", time, out DateTime d2))
                return;
            if (d1 > d2)
            {
                ErrorBox.Error("逝者如斯夫，不可倒流。");
                return;
            }

            var dd1 = d1.Int();
            var dd2 = d2.Int();

            var workHourss = emps.Select(emp => Sql.Query<TimeCard>().Where(x =>
                x.EmployeeID == emp.ID &&
                x.Date >= dd1 && x.Date <= dd2
                ).Sum(x => x.DurationHours));
            var ps = emps.Zip(workHourss).OrderByDescending(c => c.Second).ToList();


            sb = new();
            AddLine("工作时长");
            AddLine($"日期：  {d1.Str()}   至    {d2.Str()}");
            foreach (var p in ps)
                AddLine(p.First.Name.Combine(p.Second, 20) + "小时");
            AddLine("结束.");
        }

        List<Employee> emps;

        public void Front()
        {
            emps = AdminFormCtr.ReportTakes.Emps;
            tb.Text = "";
            BringToFront();
        }

        StringBuilder sb;
        void AddLine(string newLine)
        {
            sb.AppendLine(newLine);
            tb.Text = sb.ToString();
            Refresh();
            Task.Delay(50).Wait();
        }

    }
}
