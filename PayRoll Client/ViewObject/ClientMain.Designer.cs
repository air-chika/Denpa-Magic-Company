namespace PayRoll_Client.View
{
    partial class ClientMain
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
            clockinBtn = new Button();
            clockoutBtn = new Button();
            infoBtn = new Button();
            Reportbtn = new Button();
            LogoutBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            pjbtn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            SubmitBtn = new Button();
            nmbtn = new Button();
            durabtn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            nexHour = new Button();
            nexDate = new Button();
            tmbtn = new Button();
            dtbtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // clockinBtn
            // 
            clockinBtn.Location = new Point(0, 3);
            clockinBtn.Margin = new Padding(0, 3, 0, 0);
            clockinBtn.Name = "clockinBtn";
            clockinBtn.Size = new Size(75, 23);
            clockinBtn.TabIndex = 10;
            clockinBtn.Text = "Clock In";
            clockinBtn.UseVisualStyleBackColor = true;
            clockinBtn.Click += ClockInBtn_Click;
            // 
            // clockoutBtn
            // 
            clockoutBtn.Location = new Point(296, 3);
            clockoutBtn.Margin = new Padding(0, 3, 0, 0);
            clockoutBtn.Name = "clockoutBtn";
            clockoutBtn.Size = new Size(75, 23);
            clockoutBtn.TabIndex = 1;
            clockoutBtn.Text = "Clock Out";
            clockoutBtn.UseVisualStyleBackColor = true;
            clockoutBtn.Click += ClockOutBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.Location = new Point(0, 3);
            infoBtn.Margin = new Padding(0, 3, 0, 0);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(75, 23);
            infoBtn.TabIndex = 5;
            infoBtn.Text = "Info";
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // Reportbtn
            // 
            Reportbtn.Location = new Point(148, 3);
            Reportbtn.Margin = new Padding(0, 3, 0, 0);
            Reportbtn.Name = "Reportbtn";
            Reportbtn.Size = new Size(75, 23);
            Reportbtn.TabIndex = 7;
            Reportbtn.Text = "Report";
            Reportbtn.UseVisualStyleBackColor = true;
            Reportbtn.Click += Reportbtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(296, 3);
            LogoutBtn.Margin = new Padding(0, 3, 0, 0);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(75, 23);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Controls.Add(pjbtn, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(nmbtn, 0, 2);
            tableLayoutPanel1.Controls.Add(durabtn, 0, 1);
            tableLayoutPanel1.Location = new Point(380, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(450, 400);
            tableLayoutPanel1.TabIndex = 11;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(infoBtn, 0, 0);
            tableLayoutPanel4.Controls.Add(Reportbtn, 1, 0);
            tableLayoutPanel4.Controls.Add(LogoutBtn, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(5, 325);
            tableLayoutPanel4.Margin = new Padding(5, 5, 0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(445, 75);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // pjbtn
            // 
            pjbtn.Location = new Point(5, 5);
            pjbtn.Margin = new Padding(5, 5, 0, 0);
            pjbtn.Name = "pjbtn";
            pjbtn.Size = new Size(75, 23);
            pjbtn.TabIndex = 17;
            pjbtn.Text = "button3";
            pjbtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(SubmitBtn, 1, 0);
            tableLayoutPanel3.Controls.Add(clockoutBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(clockinBtn, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 245);
            tableLayoutPanel3.Margin = new Padding(5, 5, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(445, 75);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(148, 3);
            SubmitBtn.Margin = new Padding(0, 3, 0, 0);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(75, 23);
            SubmitBtn.TabIndex = 2;
            SubmitBtn.Text = "Note";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // nmbtn
            // 
            nmbtn.Location = new Point(5, 165);
            nmbtn.Margin = new Padding(5, 5, 0, 0);
            nmbtn.Name = "nmbtn";
            nmbtn.Size = new Size(75, 23);
            nmbtn.TabIndex = 19;
            nmbtn.Text = "button5";
            nmbtn.UseVisualStyleBackColor = true;
            // 
            // durabtn
            // 
            durabtn.Location = new Point(5, 85);
            durabtn.Margin = new Padding(5, 5, 0, 0);
            durabtn.Name = "durabtn";
            durabtn.Size = new Size(75, 23);
            durabtn.TabIndex = 18;
            durabtn.Text = "button4";
            durabtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(nexHour, 0, 2);
            tableLayoutPanel2.Controls.Add(nexDate, 0, 3);
            tableLayoutPanel2.Controls.Add(tmbtn, 0, 0);
            tableLayoutPanel2.Controls.Add(dtbtn, 0, 1);
            tableLayoutPanel2.Location = new Point(50, 70);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(300, 400);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // nexHour
            // 
            nexHour.Location = new Point(5, 205);
            nexHour.Margin = new Padding(5, 5, 0, 0);
            nexHour.Name = "nexHour";
            nexHour.Size = new Size(75, 23);
            nexHour.TabIndex = 7;
            nexHour.Text = "nexHour";
            nexHour.UseVisualStyleBackColor = true;
            // 
            // nexDate
            // 
            nexDate.Location = new Point(5, 305);
            nexDate.Margin = new Padding(5, 5, 0, 0);
            nexDate.Name = "nex日期";
            nexDate.Size = new Size(75, 23);
            nexDate.TabIndex = 8;
            nexDate.Text = "nex日期";
            nexDate.UseVisualStyleBackColor = true;
            // 
            // tmbtn
            // 
            tmbtn.Location = new Point(5, 5);
            tmbtn.Margin = new Padding(5, 5, 0, 0);
            tmbtn.Name = "tmbtn";
            tmbtn.Size = new Size(75, 23);
            tmbtn.TabIndex = 15;
            tmbtn.Text = "button1";
            tmbtn.UseVisualStyleBackColor = true;
            // 
            // dtbtn
            // 
            dtbtn.Location = new Point(5, 105);
            dtbtn.Margin = new Padding(5, 5, 0, 0);
            dtbtn.Name = "dtbtn";
            dtbtn.Size = new Size(75, 23);
            dtbtn.TabIndex = 16;
            dtbtn.Text = "button2";
            dtbtn.UseVisualStyleBackColor = true;
            // 
            // ClientMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "ClientMain";
            Size = new Size(900, 540);
            Load += ClientMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button clockinBtn;
        private Button clockoutBtn;
        private Button infoBtn;
        private Button Reportbtn;
        private Button LogoutBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button SubmitBtn;
        private Button nexHour;
        private Button nexDate;
        private Button pjbtn;
        private Button nmbtn;
        private Button durabtn;
        private Button tmbtn;
        private Button dtbtn;
    }
}
