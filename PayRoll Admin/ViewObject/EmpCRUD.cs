using Models;
using PayRoll_Admin.Control;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using PayRoll_Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Admin.ViewModel
{
    public class EmpCRUD : ICRUDable
    {
        public string Title => "雇员管理";

        public Employee emp = new();

        public void CreateStart()
        {
            emp = new();
            AdminFormCtr.EmpCUView.InitFront();
        }

        public void UpdateStart(int pageNumber, int index)
        {
            emp = Sql.PageAt<Employee>(pageNumber, index);
            AdminFormCtr.EmpCUView.InitFront();
        }

        public void Back()
        {
            AdminFormCtr.AdminMain.Front();
        }

        public void Delete(int pageNumber, int index)
        {
            var c = Sql.PageAt<Employee>(pageNumber, index);
            c.Fired = 1;
        }

        public List<string> GetPageInfo(int pageNumber)
        {
            var x = Sql.PageQuery<Employee>(pageNumber);
            //return x.Select(x=> x.Name.Combine(x.Type.EnumEmpType())).ToList();
            return x.Select(x => x.ID + "-" + x.Name).ToList();
        }

        public int GetPageLength()
        {
            return Sql.PageLength<Employee>();
        }
    }
}
