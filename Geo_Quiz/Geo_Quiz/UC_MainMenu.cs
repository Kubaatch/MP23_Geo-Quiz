using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_MainMenu : UserControl
    {
        public static Button[] buttons;

        public UC_MainMenu()
        {
            InitializeComponent();

            buttons = new Button[] { B_Exit, B_LogOut, B_Testing, B_Training, B_ShowStats };

            SetCurrentAccount();
        }

        private void B_Click_Open(object sender, EventArgs e)
        {
            DisableButtons();
            UserControl uc;

            if (sender == B_Testing)
            { uc = new UC_GameUI(); }
            else if (sender == B_Training)
            { uc = new UC_Learn(); }
            else if (sender == B_ShowStats)
            { uc = new UC_Statistics(); }

            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_Testing_Click(object sender, EventArgs e)
        {
            DisableButtons();
            
            UC_GameUI uc = new UC_GameUI();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_Training_Click(object sender, EventArgs e)
        {
            DisableButtons();

            UC_Learn uc = new UC_Learn();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_ShowStats_Click(object sender, EventArgs e)
        {
            DisableButtons();

            UC_Statistics uc = new UC_Statistics();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_LogOut_Click(object sender, EventArgs e)
        {
            F_SignIn form = ParentForm as F_SignIn;
            form.SetGuestLabel();
            form.EnableButtons();

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

        public void DisableButtons()
        {
            foreach (Button b in buttons)
            {
                b.Enabled = false;
            }
        }

        public void EnableButtons()
        {
            foreach (Button b in buttons)
            {
                b.Enabled = true;
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
