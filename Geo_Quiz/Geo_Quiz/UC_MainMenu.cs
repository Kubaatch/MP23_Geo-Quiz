using System;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_MainMenu : UserControl
    {
        public UC_MainMenu()
        {
            InitializeComponent();

            SetCurrentAccount();
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

        private void B_ShowStats_Click(object sender, EventArgs e)
        {
            UC_Statistics uc = new UC_Statistics();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_LogOut_Click(object sender, EventArgs e)
        {
            F_SignIn form = ParentForm as F_SignIn;
            form.SetGuestLabel();

            Dispose();
        }

        private void SetCurrentAccount()
        {
            if (F_SignIn.loggedIn == true)
            {
                L_CurrentAcc.Text += F_SignIn.loggedInAccount;
            }
            else
            {
                L_CurrentAcc.Text = "Playing as guest";
                B_LogOut.Text = "Log in";
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
