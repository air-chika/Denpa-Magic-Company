namespace PayRoll_Client.View
{
    partial class ProjInfo
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
            title = new Button();
            b1 = new Button();
            textBox1 = new TextBox();
            OK = new Button();
            Exit = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            b2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(title, 0, 0);
            tableLayoutPanel1.Controls.Add(b1, 0, 1);
            tableLayoutPanel1.Controls.Add(b2, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444542F));
            tableLayoutPanel1.Size = new Size(750, 536);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // title
            // 
            tableLayoutPanel1.SetColumnSpan(title, 2);
            title.Dock = DockStyle.Fill;
            title.Location = new Point(6, 6);
            title.Name = "title";
            title.Size = new Size(738, 52);
            title.TabIndex = 0;
            title.Text = "button1";
            title.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            b1.Location = new Point(6, 64);
            b1.Name = "b1";
            b1.Size = new Size(75, 23);
            b1.TabIndex = 2;
            b1.Text = "button3";
            b1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // OK
            // 
            OK.Location = new Point(3, 3);
            OK.Name = "OK";
            OK.Size = new Size(75, 23);
            OK.TabIndex = 1;
            OK.Text = "Submit";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(3, 93);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 2;
            Exit.Text = "Cancel";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Exit, 0, 2);
            tableLayoutPanel2.Controls.Add(OK, 0, 0);
            tableLayoutPanel2.Location = new Point(765, 330);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(120, 150);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.Location = new Point(192, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // b2
            // 
            b2.Location = new Point(6, 299);
            b2.Name = "b2";
            b2.Size = new Size(75, 23);
            b2.TabIndex = 3;
            b2.Text = "button4";
            b2.UseVisualStyleBackColor = true;
            // 
            // ProjInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Location = new Point(0, 2);
            Name = "ProjInfo";
            Size = new Size(900, 536);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button title;
        private Button b1;
        private TextBox textBox1;
        private Button OK;
        private Button Exit;
        private TableLayoutPanel tableLayoutPanel2;
        private Button b2;
        private TextBox textBox2;
    }
}
