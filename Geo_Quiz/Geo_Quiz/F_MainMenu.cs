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
    public partial class F_MainMenu : Form
    {
        public F_MainMenu()
        {
            InitializeComponent();
        }

        private void B_Testing_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            F_GameUI f1 = new F_GameUI();
            f1.ShowDialog();
        }

        private void B_Training_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            F_GameUI f2 = new F_GameUI();
            f2.ShowDialog();
        }

        private void B_Settings_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            F_Settings f3 = new F_Settings();
            f3.ShowDialog();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }         
    }
}
