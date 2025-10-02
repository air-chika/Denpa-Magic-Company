namespace PayRoll_Client.Utils
{
    partial class CRUDview

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
            pageBodyLyout = new TableLayoutPanel();
            TitleBtn = new Button();
            backBtn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            AddBtn = new Button();
            UpBtn = new Button();
            takeBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(pageBodyLyout, 0, 1);
            tableLayoutPanel1.Controls.Add(TitleBtn, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(750, 540);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(nextPageBtn, 2, 0);
            tableLayoutPanel2.Controls.Add(prePageBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(pageLab, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 486);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(738, 48);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // nextPageBtn
            // 
            nextPageBtn.Location = new Point(445, 3);
            nextPageBtn.Name = "nextPageBtn";
            nextPageBtn.Size = new Size(75, 24);
            nextPageBtn.TabIndex = 1;
            nextPageBtn.Text = " ▶ ";
            nextPageBtn.TextAlign = ContentAlignment.TopCenter;
            nextPageBtn.UseVisualStyleBackColor = true;
            // 
            // prePageBtn
            // 
            prePageBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            prePageBtn.Location = new Point(217, 3);
            prePageBtn.Name = "prePageBtn";
            prePageBtn.Size = new Size(75, 24);
            prePageBtn.TabIndex = 100;
            prePageBtn.Text = " ◀ ";
            prePageBtn.TextAlign = ContentAlignment.TopCenter;
            prePageBtn.UseVisualStyleBackColor = true;
            // 
            // pageLab
            // 
            pageLab.AutoSize = true;
            pageLab.Dock = DockStyle.Fill;
            pageLab.Location = new Point(298, 0);
            pageLab.Name = "pageLab";
            pageLab.Size = new Size(141, 48);
            pageLab.TabIndex = 2;
            pageLab.Text = "label1";
            // 
            // pageBodyLyout
            // 
            pageBodyLyout.ColumnCount = 1;
            pageBodyLyout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pageBodyLyout.Dock = DockStyle.Fill;
            pageBodyLyout.Location = new Point(6, 59);
            pageBodyLyout.Name = "pageBodyLyout";
            pageBodyLyout.RowCount = 8;
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            pageBodyLyout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            pageBodyLyout.Size = new Size(738, 421);
            pageBodyLyout.TabIndex = 1;
            // 
            // TitleBtn
            // 
            TitleBtn.Dock = DockStyle.Fill;
            TitleBtn.FlatStyle = FlatStyle.Flat;
            TitleBtn.Location = new Point(9, 6);
            TitleBtn.Margin = new Padding(6, 3, 6, 0);
            TitleBtn.Name = "TitleBtn";
            TitleBtn.Size = new Size(732, 50);
            TitleBtn.TabIndex = 2;
            TitleBtn.Text = "button1";
            TitleBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(6, 180);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(backBtn, 0, 3);
            tableLayoutPanel3.Controls.Add(UpBtn, 0, 2);
            tableLayoutPanel3.Controls.Add(AddBtn, 0, 1);
            tableLayoutPanel3.Controls.Add(takeBtn, 0, 0);
            tableLayoutPanel3.Location = new Point(777, 294);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(3);
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(120, 240);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(6, 64);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // UpBtn
            // 
            UpBtn.Location = new Point(6, 122);
            UpBtn.Name = "UpBtn";
            UpBtn.Size = new Size(75, 23);
            UpBtn.TabIndex = 6;
            UpBtn.Text = "Up日期";
            UpBtn.UseVisualStyleBackColor = true;
            // 
            // takeBtn
            // 
            takeBtn.Location = new Point(6, 6);
            takeBtn.Name = "takeBtn";
            takeBtn.Size = new Size(75, 23);
            takeBtn.TabIndex = 7;
            takeBtn.Text = "take";
            takeBtn.UseVisualStyleBackColor = true;
            // 
            // CRUDview
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Name = "CRUDview";
            Size = new Size(900, 540);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
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
        private Button backBtn;
        private Button TitleBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private Button AddBtn;
        private Button UpBtn;
        private Button takeBtn;
    }
}
