using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Service;
using PayRoll_Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.ViewObject
{
    public class ReportProjectTakes : IMultiTakeable
    {
        public string Title => "选择项目";

        public void Back()
        {
            FormCtr.ReportView.BackFront();
        }

        public void Choose(SortedSet<(int, int)> takes)
        {
            List<Project> pros = new();
            foreach (var t in takes)
                pros.Add(Sql.PageAt<Project>(t.Item1, t.Item2));
            FormCtr.ReportView.BackFront();
            FormCtr.ReportView.ShowPro(pros);
        }

        public void Front() { }

        public List<string> GetPageInfo(int pnum)
        {
            return Sql.Query<Project>().PageQuery(pnum).Select(x => x.ID + "-" + x.Name + $"（{x.ChargePerson}）").ToList();
        }

        public int GetPageLength()
        {
            return Sql.PageLength<Project>();
        }
    }
}
