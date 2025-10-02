namespace PayRoll_Admin.View
{
    partial class AdminMain
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
            dtBtn = new Button();
            nextTime = new Button();
            Exit = new Button();
            PjMng = new Button();
            nextDate = new Button();
            tmBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ProjectLbl = new Label();
            nameLab = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            Report = new Button();
            EmpMng = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtBtn
            // 
            dtBtn.Location = new Point(305, 10);
            dtBtn.Margin = new Padding(5, 5, 0, 0);
            dtBtn.Name = "dtBtn";
            dtBtn.Size = new Size(75, 23);
            dtBtn.TabIndex = 16;
            dtBtn.Text = "db";
            dtBtn.UseVisualStyleBackColor = true;
            // 
            // nextTime
            // 
            nextTime.Location = new Point(305, 107);
            nextTime.Margin = new Padding(5, 5, 0, 0);
            nextTime.Name = "nextTime";
            nextTime.Size = new Size(75, 23);
            nextTime.TabIndex = 13;
            nextTime.Text = "+1Hour";
            nextTime.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Location = new Point(305, 301);
            Exit.Margin = new Padding(5, 5, 0, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 14;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // PjMng
            // 
            PjMng.Location = new Point(305, 204);
            PjMng.Margin = new Padding(5, 5, 0, 0);
            PjMng.Name = "PjMng";
            PjMng.Size = new Size(239, 28);
            PjMng.TabIndex = 1;
            PjMng.Text = "Manage Project";
            PjMng.UseVisualStyleBackColor = true;
            // 
            // nextDate
            // 
            nextDate.Location = new Point(10, 107);
            nextDate.Margin = new Padding(5, 5, 0, 0);
            nextDate.Name = "next日期";
            nextDate.Size = new Size(75, 23);
            nextDate.TabIndex = 14;
            nextDate.Text = "+1Day";
            nextDate.UseVisualStyleBackColor = true;
            // 
            // tmBtn
            // 
            tmBtn.Location = new Point(10, 10);
            tmBtn.Margin = new Padding(5, 5, 0, 0);
            tmBtn.Name = "tmBtn";
            tmBtn.Size = new Size(75, 23);
            tmBtn.TabIndex = 15;
            tmBtn.Text = "tm";
            tmBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(ProjectLbl, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ProjectLbl
            // 
            ProjectLbl.AutoSize = true;
            ProjectLbl.ForeColor = SystemColors.ButtonFace;
            ProjectLbl.Location = new Point(3, 20);
            ProjectLbl.Name = "ProjectLbl";
            ProjectLbl.Size = new Size(32, 17);
            ProjectLbl.TabIndex = 2;
            ProjectLbl.Text = "proj";
            // 
            // nameLab
            // 
            nameLab.AutoSize = true;
            nameLab.ForeColor = SystemColors.ControlLightLight;
            nameLab.Location = new Point(3, 0);
            nameLab.Name = "nameLab";
            nameLab.Size = new Size(40, 17);
            nameLab.TabIndex = 9;
            nameLab.Text = "name";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(Exit, 1, 3);
            tableLayoutPanel3.Controls.Add(Report, 0, 3);
            tableLayoutPanel3.Controls.Add(PjMng, 1, 2);
            tableLayoutPanel3.Controls.Add(nextTime, 1, 1);
            tableLayoutPanel3.Controls.Add(tmBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(EmpMng, 0, 2);
            tableLayoutPanel3.Controls.Add(dtBtn, 1, 0);
            tableLayoutPanel3.Controls.Add(nextDate, 0, 1);
            tableLayoutPanel3.Location = new Point(155, 40);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5);
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(600, 400);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // Report
            // 
            Report.Location = new Point(10, 301);
            Report.Margin = new Padding(5, 5, 0, 0);
            Report.Name = "Report";
            Report.Size = new Size(239, 26);
            Report.TabIndex = 2;
            Report.Text = "Employee Report";
            Report.UseVisualStyleBackColor = true;
            // 
            // EmpMng
            // 
            EmpMng.Location = new Point(10, 204);
            EmpMng.Margin = new Padding(5, 5, 0, 0);
            EmpMng.Name = "EmpMng";
            EmpMng.Size = new Size(239, 32);
            EmpMng.TabIndex = 0;
            EmpMng.Text = "Manage Employee";
            EmpMng.UseVisualStyleBackColor = true;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            Controls.Add(tableLayoutPanel3);
            Name = "AdminMain";
            Size = new Size(900, 540);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Exit;
        private Button nextTime;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ProjectLbl;
        private Label nameLab;
        private TableLayoutPanel tableLayoutPanel3;
        private Button EmpMng;
        private Button PjMng;
        private Button Report;
        private Button nextDate;
        private Button tmBtn;
        private Button dtBtn;
    }
}
