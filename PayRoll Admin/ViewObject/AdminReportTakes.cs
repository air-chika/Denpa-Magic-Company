using Models;
using PayRoll_Admin.Control;
using PayRoll_Client.Service;
using PayRoll_Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Admin.ViewModel
{
    public class AdminReportTakes : IMultiTakeable
    {
        public string Title => "选择你的从者（雾）";

        public List<Employee> Emps { get; } = new();

        public void Back()
        {
            AdminFormCtr.AdminMain.Front();
        }

        public void Choose(SortedSet<(int, int)> takes)
        {
            foreach (var v in takes)
                Emps.Add(Sql.PageAt<Employee>(v.Item1, v.Item2));
            AdminFormCtr.ReportView.Front();
        }

        public void Front()
        {
            Emps.Clear();
        }

        public List<string> GetPageInfo(int pnum)
        {
            return Sql.Query<Employee>().PageQuery(pnum)
                .Select(x => x.ID + "-" + x.Name).ToList();
        }

        public int GetPageLength()
        {
            return Sql.PageLength<Employee>();
        }
    }
}
