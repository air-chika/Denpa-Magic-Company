using Models;
using PayRoll_Admin.Control;
using PayRoll_Client.ViewModel;
using PayRoll_Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayRoll_Client.Utils;
using System.Reflection;
using PayRoll_Client.Controller;

namespace PayRoll_Admin.ViewModel
{
    public class ProjCRUD : ICRUDable
    {
        public string Title => "项目管理";
        public Project project = new();

        public void CreateStart()
        {
            project = new();
            AdminFormCtr.ProjCUView.InitFront();
        }

        public void UpdateStart(int pageNumber, int index)
        {
            project = Sql.PageAt<Project>(pageNumber, index);
            AdminFormCtr.ProjCUView.InitFront();
        }

        public void Back()
        {
            AdminFormCtr.AdminMain.Front();
        }

        public void Delete(int pageNumber, int index)
        {
            var c = Sql.PageAt<Project>(pageNumber, index);
            Sql.Delete(c);
            Sql.DB.Deleteable<TimeCard>().Where(x => x.ProjectID == c.ID).ExecuteCommand();
            Sql.DB.Deleteable<ResearchNote>().Where(x => x.ProjectID == c.ID).ExecuteCommand();
        }

        public List<string> GetPageInfo(int pageNumber)
        {
            return Sql.PageQuery<Project>(pageNumber).Select(x => x.ID + "-" + x.Name).ToList();
        }

        public int GetPageLength()
        {
            return Sql.PageLength<Project>();
        }

    }
}
