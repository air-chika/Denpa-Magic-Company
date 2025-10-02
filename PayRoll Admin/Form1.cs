using PayRoll_Admin.Control;
using PayRoll_Client.View;

namespace PayRoll_Admin
{
    public partial class Form1 : Form
    {
        public PictureBox pb => pictureBox1;
        public Form1()
        {
            InitializeComponent();
            AdminFormCtr.Init(this);
        }

    }
}