using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using PayRoll_Client.View;
using PayRoll_Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.ViewObject
{
    public class NoteCRUD : ICRUDable
    {
        bool isAdding;

        public string Title => ("研究笔记（项目）");

        public void CreateStart()
        {
            if (ClockinService.CurEmployee == null)
                return;
            if (ClockinService.CurEmployee.Fired == 1)
            {
                ErrorBox.Error("被爆炒之人已无法提交研究笔记。悲。");
                return;
            }

            if (FormCtr.ClientMain.IsClocked == false)
            {
                ErrorBox.Error("写研究笔记前需要打卡。（谁想要打白工？）");
                return;
            }

            isAdding = true;
            FormCtr.NoteCU.Front(null);
        }

        public void AdOrUpOver(ResearchNote note)
        {
            if (isAdding)
                Sql.Insert(note);
            else
                Sql.Update(note);
        }
        public void UpdateStart(int pnum, int i)
        {
            if (ClockinService.CurEmployee == null) return;
            isAdding = false;
            var note = Sql.Query<ResearchNote>().Where(x => x.EmployeeID == ClockinService.CurEmployee.ID).PageQuery(pnum)[i];

            FormCtr.NoteCU.Front(note);
        }

        public void Back()
        {
            FormCtr.ClientMain.BackFront();
        }

        public void Delete(int pnum, int i)
        {
            var note = Sql.PageAt<ResearchNote>(pnum, i);
            Sql.Delete(note);
            FormCtr.NoteCRUDView.BackFront();
        }

        public List<string> GetPageInfo(int pnum)
        {
            if (ClockinService.CurEmployee == null) return null;

            var notes = Sql.Query<ResearchNote>().Where(x => x.EmployeeID == ClockinService.CurEmployee.ID).ToPageList(pnum, CRUDview.numInPage);
            var pros = notes.Select(x => Sql.Query<Project>().First(p => p.ID == x.ProjectID).Name).ToList();
            var ids = notes.Select(x => x.ID).ToList();

            return notes.Zip(pros, (a, b) => a.Name + $"（{b}）")
                .Zip(ids, (a, b) => b + "-" + a)
                .ToList();
        }

        public int GetPageLength()
        {
            return Sql.PageLength<ResearchNote>();
        }


    }
}
