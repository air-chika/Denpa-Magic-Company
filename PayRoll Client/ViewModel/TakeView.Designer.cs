namespace PayRoll_Client.View
{
    partial class TakeView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            nextPageBtn = new Button();
            prePageBtn = new Button();
            pageLab = new Label();
            OKBtn = new Button();
            cancelBtn = new Button();
            pageBodyLyout = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(pageBodyLyout, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(900, 540);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel2.Controls.Add(nextPageBtn, 2, 0);
            tableLayoutPanel2.Controls.Add(prePageBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(pageLab, 1, 0);
            tableLayoutPanel2.Controls.Add(OKBtn, 3, 0);
            tableLayoutPanel2.Controls.Add(cancelBtn, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 489);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(894, 48);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // nextPageBtn
            // 
            nextPageBtn.Location = new Point(538, 3);
            nextPageBtn.Name = "nextPageBtn";
            nextPageBtn.Size = new Size(75, 23);
            nextPageBtn.TabIndex = 1;
            nextPageBtn.Text = " ▶ ";
            nextPageBtn.UseVisualStyleBackColor = true;
            // 
            // prePageBtn
            // 
            prePageBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            prePageBtn.Location = new Point(279, 3);
            prePageBtn.Name = "prePageBtn";
            prePageBtn.Size = new Size(75, 23);
            prePageBtn.TabIndex = 100;
            prePageBtn.Text = " ◀ ";
            prePageBtn.UseVisualStyleBackColor = true;
            // 
            // pageLab
            // 
            pageLab.AutoSize = true;
            pageLab.Dock = DockStyle.Fill;
            pageLab.Location = new Point(360, 0);
            pageLab.Name = "pageLab";
            pageLab.Size = new Size(172, 48);
            pageLab.TabIndex = 2;
            pageLab.Text = "label1";
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(657, 3);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(44, 23);
            OKBtn.TabIndex = 3;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(776, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // pageBodyLyout
            // 
            pageBodyLyout.ColumnCount = 1;
            pageBodyLyout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pageBodyLyout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pageBodyLyout.Dock = DockStyle.Fill;
            pageBodyLyout.Location = new Point(3, 3);
            pageBodyLyout.Name = "pageBodyLyout";
            pageBodyLyout.RowCount = 9;
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            pageBodyLyout.Size = new Size(894, 480);
            pageBodyLyout.TabIndex = 1;
            // 
            // TakeView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            Controls.Add(tableLayoutPanel1);
            Name = "TakeView";
            Size = new Size(900, 540);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button nextPageBtn;
        private Label pageLab;
        private TableLayoutPanel pageBodyLyout;
        private Button prePageBtn;
        private Button OKBtn;
        private Button cancelBtn;
    }
}
