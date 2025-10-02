using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using PayRoll_Client.ViewObject;
using SqlSugar;

namespace PayRoll_Client.View
{
    public partial class NoteCU : UserControl
    {
        void Based(params TextBox[] cts)
        {
            foreach (var ct in cts)
            {
                ct.Based();
                ct.Dock = DockStyle.Fill;
            }
        }

        void Based(params Button[] cts)
        {
            foreach (var ct in cts)
            {
                ct.BasedLab(22);
            }

        }


        public NoteCU()
        {
            InitializeComponent();
            Based(pname, b1, b2, b3);
            title.BasedTitle(25);
            OK.Based();
            Exit.Based();
            Based(textBox1, textBox2, textBox3);
            title.Text = "研究笔记";
            pname.Text = "项目名称";
            b1.Text = "笔记名称";
            b2.Text = "贡献值";
            b3.Text = "描述";
            OK.Text = "确认";
            Exit.Text = "取消";

            proBtn.BasedLabBtn(22);
            proBtn.Click += Pinfo_Click;

        }

        private void Pinfo_Click(object? sender, EventArgs e)
        {
            var pros = Sql.Query<Project>().ToList();
            bool b = GetEnumForm.TryGet("项目", pros, p => p.Name, note.ProjectID, x => x.ID, out int idx);
            if (b)
            {
                note.ProjectID = pros[idx].ID;
                proBtn.Text = pros[idx].Name;
            }
        }

        ResearchNote note;
        public void Front(ResearchNote? not)
        {
            if (not == null)
            {
                proBtn.Text = ClockinService.CurProject.Name;
                note = new();
                note.ProjectID = ClockinService.CurProject.ID;
                note.EmployeeID = ClockinService.CurEmployee.ID;
                note.Date = VClockService.Vclock.NowDate;
                note.Name = "";
                note.Description = "";
                note.Contribute = 0;
                note.Date = VClockService.Vclock.NowDate;
            }
            else
            {
                note = not;
                proBtn.Text = Sql.QueryID<Project>(note.ProjectID).Name;
            }
            textBox1.Text = note.Name;
            textBox2.Text = note.Contribute.ToString();
            textBox3.Text = note.Description;
            BringToFront();
        }


        private void OK_Click(object sender, EventArgs e)
        {
            if (!TypeCheck.Correct("笔记名称", textBox1.Text, TextType.Name))
            {
                textBox1.Text = note.Name;
                return;
            }
            if (!TypeCheck.Correct("贡献值", textBox2.Text, TextType.Real))
            {
                textBox2.Text = note.Contribute.ToString();
                return;
            }

            note.Name = textBox1.Text;
            note.Contribute = double.Parse(textBox2.Text);
            note.Description = textBox3.Text;

            FormCtr.NoteCRUD.AdOrUpOver(note);
            FormCtr.NoteCRUDView.BackFront();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is '\r' or (char)27)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is '\r' or (char)27)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is (char)27)
                e.Handled = true;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            FormCtr.NoteCRUDView.BackFront();
        }
    }
}
