using System;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_MainMenu : UserControl
    {
        public bool loggedIn;
        public string loggedInAccount;

        public UC_MainMenu()
        {
            InitializeComponent();

            SetCurrentAccount();

            loggedIn = F_SignIn.loggedIn;
            loggedInAccount = F_SignIn.loggedInAccount;
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

        private void B_Account_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accounts aren't supported yet.");
        }

        private void SetCurrentAccount()
        {
            loggedIn = F_SignIn.loggedIn;
            loggedInAccount = F_SignIn.loggedInAccount;

            if (loggedIn == true)
            {
                L_CurrentAcc.Text += loggedInAccount;
            }
            else
            {
                L_CurrentAcc.Text = "Playing as guest";
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
