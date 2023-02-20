using System;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class F_Learn : Form
    {
        public F_Learn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            F_MainMenu f1 = new F_MainMenu();
            f1.ShowDialog();
        }
    }
}
