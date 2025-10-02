using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Client.View
{
    public partial class JoinProjectTake : UserControl
    {
        Label[] labs;
        Button[] btns;
        List<Project> pros;
        int curPageNumber;
        int pagesLength;
        int _lastChoseIdx = -1;
        int LastChoseIdx
        {
            get => _lastChoseIdx;
            set
            {
                if (_lastChoseIdx != -1)
                    btns[_lastChoseIdx].BasedChoice();
                _lastChoseIdx = value;
                if (_lastChoseIdx != -1)
                    btns[_lastChoseIdx].BasedChoosing();
            }
        }

        public void Front()
        {
            CurPage = 1;
            BringToFront();
        }

        int CurPage
        {
            get => curPageNumber;
            set
            {
                curPageNumber = value;
                pros = Sql.PageQuery<Project>(curPageNumber);
                LastChoseIdx = -1;

                for (int i = 0; i < pros.Count; i++)
                {
                    btns[i].Visible = true;
                    btns[i].Text = pros[i].ID + "-" + pros[i].Name;
                    labs[i + 2].Visible = true;
                    labs[i + 2].Text = pros[i].ChargePerson;
                    Refresh();
                }
                for (int i = 7; i >= pros.Count; i--)
                {
                    labs[i + 2].Visible = false;
                    btns[i].Visible = false;
                    Refresh();
                }
                pageLab.Text = $"{curPageNumber} / {pagesLength} 页";
                if (value == 1) prePageBtn.Enabled = false;
                else prePageBtn.Enabled = true;
                if (value == pagesLength) nextPageBtn.Enabled = false;
                else nextPageBtn.Enabled = true;
            }
        }

        void Based()
        {
            foreach (var lab in labs)
            {
                lab.BasedFill();
            }
            foreach (var btn in btns)
            {
                btn.BasedChoice();
            }

        }

        public JoinProjectTake()
        {
            InitializeComponent();

            OKBtn.Text = "确定";
            cancelBtn.Text = "取消";

            curPageNumber = 1;
            labs = new Label[10];
            btns = new Button[8];
            pagesLength = Sql.PageLength<Project>();

            Button Pro = new Button();
            labs[0] = new Label();
            labs[1] = new Label();
            Pro.Text = "项目名称";
            Pro.BasedTitle();
            labs[1].Text = "负责人";
            pageBodyLyout.Controls.Add(Pro);
            pageBodyLyout.Controls.Add(labs[1]);


            for (int i = 0; i < 8; i++)
            {
                int j = i + 2;
                btns[i] = new Button();
                labs[j] = new Label();
                int m = i;
                btns[i].Click += (a, b) =>
                {
                    if (LastChoseIdx == m)
                    {
                        OKBtn_Click(a, b);
                        return;
                    }
                    LastChoseIdx = m;
                    IDcheck = pros[LastChoseIdx].ID;
                };
                pageBodyLyout.Controls.Add(btns[i]);
                pageBodyLyout.Controls.Add(labs[j]);
            }

            prePageBtn.Based();
            nextPageBtn.Based();
            pageLab.Based();
            prePageBtn.Dock = DockStyle.Right;
            nextPageBtn.Dock = DockStyle.Left;

            cancelBtn.Based();
            OKBtn.Based();
            Based();
        }

        int IDcheck;

        private void prePageBtn_Click(object sender, EventArgs e)
        {
            CurPage--;
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            CurPage++;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (LastChoseIdx == -1)
            {
                ErrorBox.Error("无项目，不上班。");
                return;
            }

            var pro = Sql.PageAt<Project>(curPageNumber, LastChoseIdx);
            if (pro == null || IDcheck != pro.ID)
            {
                ErrorBox.Error("此项目在刹那间被送走了~");
                CurPage = CurPage;
                return;
            }

            ClockinService.CurProject = pro;
            if (ClockinService.CurProject == null)
                FormCtr.ClientMain.BackFront();

            FormCtr.ClientMain.SureClockin();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            FormCtr.ClientMain.BackFront();
        }


    }
}
