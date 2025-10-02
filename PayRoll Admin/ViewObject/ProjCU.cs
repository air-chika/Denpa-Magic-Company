using Models;
using PayRoll_Admin.Control;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using PayRoll_Client.View;
using PayRoll_Client.ViewModel;

namespace PayRoll_Admin.ViewModel
{
    public class ProjCU : ITakeable
    {
        Project pj = new();
        public string Title => "项目";

        public void Front()
        {
            pj = AdminFormCtr.ProjCURD.project;
        }

        public void Back()
        {
            AdminFormCtr.ProjCRUDView.BackFront();
        }


        public void Choose(int pnum, int i)
        {
            switch (i)
            {
                case 0:
                    var b = GetTextForm.TryGet("项目名", pj.Name, out string name,TextType.Name);
                    if (b)
                    {
                        pj.Name = name;
                        AdminFormCtr.ProjCUView.BackFront();
                    }
                    break;
                case 1:
                    var c = GetTextForm.TryGet("负责人", pj.ChargePerson, out string charge,TextType.Name);
                    if (c)
                    {
                        pj.ChargePerson = charge;
                        AdminFormCtr.ProjCUView.BackFront();
                    }
                    break;
                case 2:
                    if (!TypeCheck.Correct("项目名", pj.Name, TextType.Name))
                        return;
                    if (!TypeCheck.Correct("负责人", pj.Name, TextType.Name))
                        return;
                    Sql.CU(pj, pj.ID);
                    AdminFormCtr.ProjCRUDView.BackFront();
                    break;
            }
        }



        public List<string> GetPageInfo(int pnum)
        {
            var l = new List<string>();
            l.Add("项目名：".Combine(pj.Name));
            l.Add("负责人：".Combine(pj.ChargePerson));
            l.Add("保存");
            return l;
        }

        public int GetPageLength()
        {
            return 1;
        }
    }
}
