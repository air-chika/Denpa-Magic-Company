using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Models;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PayRoll_Client.View
{
    public partial class EmployReport : UserControl
    {
        public EmployReport()
        {
            InitializeComponent();
            tb.Reported();

            hour.BasedTitleBtn();
            pay.BasedTitleBtn();
            inPro.BasedTitleBtn();

            vacation.Based();

            save.Based();
            back.Based();

            vacation.BackColor = ArtHelpers.amber;
            vacation.ForeColor = ArtHelpers.black1;
            vacation.FlatAppearance.BorderColor = ArtHelpers.green;


            hour.Text = "工作时长";
            inPro.Text = "项目投入";
            vacation.Text = "假期！";
            pay.Text = "今年收入";
            save.Text = "保存到文件";
            back.Text = "返回主界面";

            back.Click += (a, b) => FormCtr.ClientMain.BackFront();
            hour.Click += Hour_Click;
            pay.Click += Pay_Click;
            save.Click += Save_Click;
            inPro.Click += InPro_Click;
            vacation.Click += Vacation_Click;
        }

        private void Vacation_Click(object? sender, EventArgs e)
        {
            sb = new();
            var dd = VClockService.Vclock.NowDate;
            var di = dd % 10000;

            var vs = Sql.Query<Vacation>().Where(x => x.EndDate > di).ToList();
            var ds = vs.Select(x =>
                {
                    var d1 = x.StartDate.VacationDate();
                    var d2 = x.EndDate.VacationDate();
                    return ((d2 - d1).Days + 1, x.Name + "： " + d1.Str()
                        + "  至  " + d2.Str() + "    共" + ((d2 - d1).Days + 1) + "天");
                });

            AddLine("假期：");
            AddLine("当前日期：" + dd.Date().Str());
            foreach (var d in ds)
                AddLine(d.Item2);
            AddLine("共" + ds.Sum(x => x.Item1) + "天");
            AddLine("结束.");
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
            var dd2 = d2.Int();
            var dd1 = d1.Int();

            var ps = Sql.Query<PayCheck>().Where(x => x.EmployeeID == emp.ID && x.Date >= dd1 && x.Date <= dd2);

            var bps = Sql.Query<BankPayCheck>().Where(x => x.EmployeeID == emp.ID && x.Date >= dd1 && x.Date <= dd2).ToList();

            var sum = ps.Sum(x => x.RealWages) + bps.Sum(x => x.RealWages);

            var pss2 = ps.OrderBy(p => p.Date).ToList();
            var pss = pss2.SelectMany(p => PayInfo(p)).ToList();
            var bs = bps.GroupBy(x => x.BankID);
            var bss = bs.SelectMany(x => x.OrderBy(b => b.Date));
            var bpss = bss.SelectMany(p => PayInfo(p));

            var rs = pss.Concat(bpss);

            sb = new();
            AddLine("今年收入：");
            AddLine($"日期：{d1.Str()}   至   {d2.Str()}");
            AddLine($"总金额：" + sum + "元");
            foreach (var r in rs)
                AddLine(r);
            AddLine("结束.");
        }

        List<string> PayInfo(PayCheck pay)
        {
            List<string> bu = new();
            bu.Add("");
            bu.Add("日期：" + pay.Date.Date().Str());
            bu.Add("工资：" + pay.RawWages + "元");
            bu.Add("佣金：+" + pay.Commision + "元");
            bu.Add("税收：-" + pay.Tax + "元");
            bu.Add("其他扣除：-" + pay.OtherDeductions + "元");
            bu.Add("结算工资：" + pay.RealWages + "元");
            return bu;
        }


        List<string> PayInfo(BankPayCheck pay)
        {
            List<string> bu = new();
            bu.Add("");
            bu.Add("日期：" + pay.Date.Date().Str());
            bu.Add("银行：" + Sql.QueryID<Bank>(pay.BankID).Name);
            bu.Add("工资： " + pay.RawWages + "元");
            bu.Add("佣金： +" + pay.Commision + "元");
            bu.Add("税收： -" + pay.Tax + "元");
            bu.Add("其他扣除： -" + pay.OtherDeductions + "元");
            bu.Add("结算工资： " + pay.RealWages + "元");
            return bu;
        }

        private void Hour_Click(object? sender, EventArgs e)
        {
            var time = VClockService.Vclock.Date().Str();
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

            var works = Sql.Query<TimeCard>().Where(x =>
                x.EmployeeID == emp.ID &&
                x.Date >= dd1 && x.Date <= dd2).ToList();

            var gs = works.GroupBy(x => x.ProjectID).ToList();
            var pros = gs.Select(x => Sql.QueryID<Project>(x.Key)).Select(x => x.Name);
            var hours = gs.Select(x => x.Sum(x => x.DurationHours));
            var ps = pros.Zip(hours).OrderByDescending(x => x.Second);


            sb = new();
            AddLine("工作时长：");
            AddLine($"日期：{d1.Str()}   至   {d2.Str()}");

            foreach (var p in ps)
                AddLine(("项目：" + p.First).Combine(p.Second) + "小时");
            AddLine("共" + hours.Sum() + "小时");
            AddLine("结束.");
        }

        private void InPro_Click(object? sender, EventArgs e)
        {
            FormCtr.RProtakesView.InitFront();
        }

        public void ShowPro(List<Project> pros)
        {
            var time = VClockService.Vclock.Date().Str();
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

            var cards = Sql.Query<TimeCard>().Where(x =>
                x.EmployeeID == emp.ID &&
                x.Date >= dd1 && x.Date <= dd2).ToList();

            var sets = pros.Select(p => cards.Where(x => x.ProjectID == p.ID));
            var hs = sets.Select(x => x.Sum(x => x.DurationHours));
            var ps = pros.Zip(hs).OrderByDescending(x => x.Second);

            sb = new();
            AddLine("项目投入：");
            AddLine($"日期：{d1.Str()}至{d2.Str()}");

            foreach (var p in ps)
                AddLine(("项目：" + p.First.Name).Combine(p.Second) + "小时");
            AddLine("共" + hs.Sum() + "小时");
            AddLine("结束.");

        }

        Employee emp;

        public void Front()
        {
            emp = ClockinService.CurEmployee;
            if (emp == null) return;
            tb.Text = "";
            BringToFront();
        }
        public void BackFront()
        {
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
