using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Service;
using PayRoll_Client.View;
using PayRoll_Client.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Client.Utils
{
    public partial class CRUDview : UserControl
    {
        public const int numInPage = 8;
        ICRUDable model;

        Button[] btns;
        List<string> infos;
        int _lastChoseIdx = -1;
        int LastChoseIdx
        {
            get => _lastChoseIdx;
            set
            {
                if (_lastChoseIdx != -1)
                {
                    btns[_lastChoseIdx].BasedChoice();
                }
                _lastChoseIdx = value;
                if (_lastChoseIdx != -1)
                {
                    if (IsUpdate)
                        btns[_lastChoseIdx].BasedChoosing();
                    else
                        btns[_lastChoseIdx].BasedDelete();
                }

            }
        }

        public void InitFront()
        {
            LastChoseIdx = -1;
            pagesLength = model.GetPageLength();
            if (pagesLength == 0) pagesLength = 1;
            CurPage = 1;
            IsUpdate = true;
            BringToFront();
        }
        public void BackFront()
        {
            LastChoseIdx = -1;
            pagesLength = model.GetPageLength();
            if (pagesLength == 0) pagesLength = 1;
            if (CurPage > pagesLength)
                CurPage--;
            else
                CurPage = CurPage;
            BringToFront();
        }

        bool ConfirmDelete()
        {
            return ConfirmBox.Confirm("确定要删掉它（他/她）吗？","删掉她","取消");
        }

        private void TakeBtn_Click(object? sender, EventArgs e)
        {
            Take();
        }

        void Take()
        {
            if (LastChoseIdx == -1)
            {
                ErrorBox.Error("或许他只是想点着玩？");
                return;
            }
            if (isUpd)
            {
                model.UpdateStart(curPageNumber, LastChoseIdx);
            }
            else
                if (ConfirmDelete())
            {
                model.Delete(curPageNumber, LastChoseIdx);
                BackFront();
            }
        }

        public CRUDview(ICRUDable controller)
        {
            InitializeComponent();
            takeBtn.Text = "确定";
            takeBtn.Based();
            takeBtn.Click += TakeBtn_Click;
            model = controller;
            curPageNumber = 0;
            btns = new Button[numInPage];

            for (int i = 0; i < numInPage; i++)
            {
                btns[i] = new Button();
                btns[i].BasedChoice();
                int m = i;
                btns[i].Click += (a, b) =>
                {
                    if (LastChoseIdx == m)
                    {
                        Take();
                        return;
                    }
                    LastChoseIdx = m;
                };
                pageBodyLyout.Controls.Add(btns[i]);
            }

            prePageBtn.Based();
            nextPageBtn.Based();
            pageLab.Based();

            prePageBtn.Dock = DockStyle.Right;
            nextPageBtn.Dock = DockStyle.Left;


            prePageBtn.Click += (a, b) => CurPage--;
            nextPageBtn.Click += (a, b) => CurPage++;

            backBtn.Based();
            backBtn.Click += (a, b) => model.Back();

            AddBtn.Based();
            AddBtn.Click += (a, b) => model.CreateStart();

            AddBtn.Text = "添加";
            backBtn.Text = "返回";


            UpBtn.Based();
            UpBtn.FlatAppearance.BorderColor = ArtHelpers.brown;
            UpBtn.Click += (a, b) => IsUpdate = !isUpd;

            TitleBtn.BasedTitle();
            TitleBtn.Text = model.Title;
        }



        int CurPage
        {
            get => curPageNumber;
            set
            {
                curPageNumber = value;
                LastChoseIdx = -1;
                infos = model.GetPageInfo(value);
                if (infos == null) infos = new();
                for (int i = 0; i < infos.Count; i++)
                {
                    btns[i].Visible = true;
                    btns[i].Text = infos[i];
                    Refresh();
                }
                for (int i = numInPage - 1; i >= infos.Count; i--)
                {
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

        bool IsUpdate
        {
            get => isUpd;
            set
            {
                isUpd = value;
                if (value)
                    UpBtn.Text = "更ing/删";
                else
                    UpBtn.Text = "删ing/更";
                LastChoseIdx = LastChoseIdx;
            }
        }

        bool isUpd;
        int curPageNumber;
        int pagesLength;

    }
}
