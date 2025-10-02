namespace PayRoll_Client.View
{
    partial class InfoU
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
            table = new TableLayoutPanel();
            title = new Button();
            SaveBtn = new Button();
            CancelBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            table.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnCount = 4;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table.Controls.Add(title, 0, 0);
            table.Dock = DockStyle.Left;
            table.Location = new Point(0, 0);
            table.Margin = new Padding(4);
            table.Name = "table";
            table.RowCount = 9;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            table.Size = new Size(766, 536);
            table.TabIndex = 0;
            // 
            // title
            // 
            table.SetColumnSpan(title, 4);
            title.Dock = DockStyle.Fill;
            title.FlatStyle = FlatStyle.Flat;
            title.Location = new Point(3, 3);
            title.Name = "title";
            title.Size = new Size(760, 53);
            title.TabIndex = 0;
            title.Text = "Employee Info";
            title.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(3, 3);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(3, 63);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 3;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(SaveBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(CancelBtn, 0, 1);
            tableLayoutPanel1.Location = new Point(779, 384);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(110, 120);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // InfoU
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(table);
            Location = new Point(2, 2);
            Name = "InfoU";
            Size = new Size(900, 536);
            table.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel table;
        private Button title;
        private Button SaveBtn;
        private Button CancelBtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
