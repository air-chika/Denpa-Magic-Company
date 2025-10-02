using PayRoll_Admin.Control;
using PayRoll_Admin.View;
using PayRoll_Admin.ViewModel;
using PayRoll_Client.Controller;
using PayRoll_Client.Utils;
using PayRoll_Client.ViewModel;

namespace PayRoll_Client.View
{
    public partial class ProjInfo : UserControl
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
                ct.BasedTitle();
        }
        ProjCRUD projModel;
        public ProjInfo(ProjCRUD model)
        {
            InitializeComponent();
            Based(title, b1, b2);
            OK.Based();
            Exit.Based();
            Based(textBox1, textBox2);
            title.Text = "Project";
            b1.Text = "Project Name";
            b2.Text = "Charge Person";
            projModel = model;
        }


        public void Front(List<string> infos)
        {
            textBox1.Text = infos[0];
            textBox2.Text = infos[1];
            BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            AdminFormCtr.ProjCRUDView.BackFront();
        }

        private void OK_Click(object sender, EventArgs e)
        {

            AdminFormCtr.ProjCRUDView.BackFront();
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

    }
}
