namespace PayRoll_Client.View
{
    partial class EmployReport
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
            tb = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            back = new Button();
            save = new Button();
            vacation = new Button();
            pay = new Button();
            inPro = new Button();
            hour = new Button();
            saveFileDialog = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tb
            // 
            tb.BackColor = Color.FromArgb(88, 88, 88);
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("微软雅黑", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tb.Location = new Point(15, 15);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.ScrollBars = ScrollBars.Horizontal;
            tb.Size = new Size(650, 510);
            tb.TabIndex = 0;
            tb.Text = "假期报告";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(back, 0, 5);
            tableLayoutPanel1.Controls.Add(save, 0, 4);
            tableLayoutPanel1.Controls.Add(vacation, 0, 0);
            tableLayoutPanel1.Controls.Add(pay, 0, 3);
            tableLayoutPanel1.Controls.Add(inPro, 0, 2);
            tableLayoutPanel1.Controls.Add(hour, 0, 1);
            tableLayoutPanel1.Location = new Point(684, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(196, 400);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // back
            // 
            back.Location = new Point(3, 333);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 2;
            back.Text = "button3";
            back.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            save.Location = new Point(3, 267);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 3;
            save.Text = "button1";
            save.UseVisualStyleBackColor = true;
            // 
            // vacation
            // 
            vacation.Location = new Point(3, 3);
            vacation.Name = "vacation";
            vacation.Size = new Size(75, 23);
            vacation.TabIndex = 5;
            vacation.Text = "vaca";
            vacation.UseVisualStyleBackColor = true;
            // 
            // pay
            // 
            pay.Location = new Point(3, 201);
            pay.Name = "pay";
            pay.Size = new Size(75, 23);
            pay.TabIndex = 1;
            pay.Text = "button2";
            pay.UseVisualStyleBackColor = true;
            // 
            // inPro
            // 
            inPro.Location = new Point(3, 135);
            inPro.Name = "inPro";
            inPro.Size = new Size(75, 23);
            inPro.TabIndex = 4;
            inPro.Text = "inPro";
            inPro.UseVisualStyleBackColor = true;
            // 
            // hour
            // 
            hour.Location = new Point(3, 69);
            hour.Name = "hour";
            hour.Size = new Size(75, 23);
            hour.TabIndex = 0;
            hour.Text = "work";
            hour.UseVisualStyleBackColor = true;
            // 
            // EmployReport
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tb);
            Name = "EmployReport";
            Size = new Size(900, 540);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb;
        private TableLayoutPanel tableLayoutPanel1;
        private Button hour;
        private Button pay;
        private Button back;
        private Button save;
        private SaveFileDialog saveFileDialog;
        private Button inPro;
        private Button vacation;
    }
}
