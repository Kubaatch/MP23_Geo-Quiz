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
            UC_MainMenu uc = new UC_MainMenu();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void B_SignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This part of the program is not set up yet, sorry...", "¯\\_(ツ)_/¯");
        }

        private void B_SignIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This part of the program is not set up yet, sorry...", "¯\\_(ツ)_/¯");
        }
    }
}
