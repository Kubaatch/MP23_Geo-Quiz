using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class F_SignIn : Form
    {
        public F_SignIn()
        {
            InitializeComponent();
        }

        private void B_Guest_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            F_MainMenu f1 = new F_MainMenu();
            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
