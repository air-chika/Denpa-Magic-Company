using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
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

namespace PayRoll_Client.View
{
    public partial class TakeView : UserControl
    {
        ITakeable takeable;
        Button title;
        Button[] btns;
        List<string> pageInfos;
        int curPageNumber;
        int pagesLength;
        const int numInPage = CRUDview.numInPage;

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

        public void InitFront()
        {
            takeable.Front();
            pagesLength = takeable.GetPageLength();
            if (pagesLength == 0) pagesLength = 1;
            LastChoseIdx = -1;
            CurPage = 1;
            BringToFront();
        }
        public void BackFront()
        {
            takeable.Front();
            pagesLength = takeable.GetPageLength();
            if (pagesLength == 0) pagesLength = 1;
            if (CurPage > pagesLength)
                CurPage--;
            else
                CurPage = CurPage;
            BringToFront();
        }


        int CurPage
        {
            get => curPageNumber;
            set
            {
                curPageNumber = value;
                LastChoseIdx = -1;
                pageInfos = takeable.GetPageInfo(value);
                if (pageInfos == null) pageInfos = new();
                for (int i = 0; i < pageInfos.Count; i++)
                {
                    btns[i].Visible = true;
                    btns[i].Text = pageInfos[i];
                    Refresh();
                }
                for (int i = numInPage - 1; i >= pageInfos.Count; i--)
                {
                    btns[i].Visible = false;
                    Refresh();
                }
                pageLab.Text = $"{curPageNumber} / {pagesLength} Page";
                if (value == 1) prePageBtn.Enabled = false;
                else prePageBtn.Enabled = true;
                if (value == pagesLength) nextPageBtn.Enabled = false;
                else nextPageBtn.Enabled = true;
            }
        }

        public TakeView(ITakeable take)
        {
            InitializeComponent();
            takeable = take;

            title = new Button();
            btns = new Button[numInPage];
            title.Text = takeable.Title;
            title.BasedTitle();
            pageBodyLyout.Controls.Add(title);


            for (int i = 0; i < numInPage; i++)
            {
                btns[i] = new Button();
                btns[i].BasedChoice();
                int m = i;
                btns[i].Click += (a, b) =>
                {
                    if(LastChoseIdx == m)
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

            cancelBtn.Based();
            cancelBtn.Click += (a, b) => takeable.Back();
            cancelBtn.Text = "取消";

            OKBtn.Based();
            OKBtn.Click += (a, b) => Take();
            OKBtn.Text = "确定";
        }

        void Take()
        {
            if (LastChoseIdx == -1)
            {
                ErrorBox.Error("爆");
                return;
            }
            takeable.Choose(curPageNumber, LastChoseIdx);
        }

    }
}
