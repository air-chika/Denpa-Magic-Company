using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.View;

namespace PayRoll_Client
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormCtr.Init(this);
        }
    }
}