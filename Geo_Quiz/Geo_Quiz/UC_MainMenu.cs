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
    public partial class UC_MainMenu : UserControl
    {
        public UC_MainMenu()
        {
            InitializeComponent();
        }
        private void B_Testing_Click(object sender, EventArgs e)
        {            
            UC_GameUI uc = new UC_GameUI();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_Training_Click(object sender, EventArgs e)
        {
            UC_Learn uc = new UC_Learn();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_Settings_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
