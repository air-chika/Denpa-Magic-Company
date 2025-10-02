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
    public partial class QuickTakeView : UserControl
    {
        ITakeable takeable;
        Button title;
        Button[] btns;
        List<string> pageInfos;
        int curPageNumber;
        int pagesLength;
        const int numInPage = CRUDview.numInPage;

        public void InitFront()
        {
            takeable.Front();
            pagesLength = takeable.GetPageLength();
            if (pagesLength == 0) pagesLength = 1;
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

        public QuickTakeView(ITakeable take)
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
                btns[i].Based();
                int m = i;
                btns[i].Click += (a, b) =>
                {
                    takeable.Choose(curPageNumber, m);
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
        }

    }
}
