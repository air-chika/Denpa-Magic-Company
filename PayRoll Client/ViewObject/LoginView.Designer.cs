namespace PayRoll_Client.View
{
    partial class LoginView
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
            ex = new Button();
            log = new Button();
            tb = new TextBox();
            button1 = new Button();
            nameBtn = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            desBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ex, 1, 3);
            tableLayoutPanel1.Controls.Add(log, 0, 3);
            tableLayoutPanel1.Controls.Add(tb, 0, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(nameBtn, 0, 0);
            tableLayoutPanel1.Location = new Point(140, 81);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(500, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ex
            // 
            ex.Location = new Point(260, 243);
            ex.Margin = new Padding(10, 3, 3, 3);
            ex.Name = "ex";
            ex.Size = new Size(75, 23);
            ex.TabIndex = 4;
            ex.Text = "button2";
            ex.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            log.Location = new Point(3, 243);
            log.Margin = new Padding(3, 3, 10, 3);
            log.Name = "log";
            log.Size = new Size(75, 23);
            log.TabIndex = 3;
            log.Text = "button1";
            log.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            tableLayoutPanel1.SetColumnSpan(tb, 2);
            tb.Location = new Point(3, 120);
            tb.Margin = new Padding(3, 0, 3, 3);
            tb.Name = "tb";
            tb.PasswordChar = '*';
            tb.Size = new Size(294, 23);
            tb.TabIndex = 1;
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.Location = new Point(3, 63);
            button1.Margin = new Padding(3, 3, 3, 0);
            button1.Name = "button1";
            button1.Size = new Size(294, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // nameBtn
            // 
            tableLayoutPanel1.SetColumnSpan(nameBtn, 2);
            nameBtn.Location = new Point(3, 3);
            nameBtn.Name = "nameBtn";
            nameBtn.Size = new Size(294, 23);
            nameBtn.TabIndex = 6;
            nameBtn.Text = "Name";
            nameBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(desBtn, 0, 0);
            tableLayoutPanel2.Location = new Point(650, 81);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(235, 300);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // desBtn
            // 
            desBtn.Location = new Point(3, 3);
            desBtn.Name = "desBtn";
            desBtn.Size = new Size(75, 23);
            desBtn.TabIndex = 0;
            desBtn.Text = "button2";
            desBtn.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "LoginView";
            Size = new Size(900, 540);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button ex;
        private Button log;
        private TextBox tb;
        private Button button1;
        private PictureBox pictureBox1;
        private Button nameBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private Button desBtn;
    }
}
