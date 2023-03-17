using System;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class F_SignIn : Form
    {
        public static string header;
        public static string type;
        public static bool loggedIn = false;
        public static string loggedInAccount;

        public F_SignIn()
        {
            InitializeComponent();
        }

        private void B_Guest_Click(object sender, EventArgs e)
        {
            if (loggedIn == false)
            {
                DialogResult result = MessageBox.Show("You are not logged in, do you want to play as guest?\nYour stats won't be saved, " +
                    "but you still can log in later.", "¯\\_(ツ)_/¯", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    OpenMainMenu();
                }
            }
            else
            {
                OpenMainMenu();
            }
        }

        private void OpenMainMenu()
        {
            UC_MainMenu uc = new UC_MainMenu();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_SignUp_Click(object sender, EventArgs e)
        {
            header = "Sign up a new account:";
            type = "SignUp";

            OpenLogin();            
        }

        private void B_SignIn_Click(object sender, EventArgs e)
        {
            header = "Sign in an existing account:";
            type = "SignIn";

            OpenLogin();            
        }

        public void SetCurrentAccLabel(string setUsername)
        {
            L_CurrentAcc.Visible = true;
            
            loggedInAccount = setUsername;
            L_CurrentAcc.Text += loggedInAccount;

            B_SignIn.Enabled = false;
            B_SignUp.Enabled = false;
        }

        private void OpenLogin()
        {
            UC_Login uc = new UC_Login();
            Controls.Add(uc);
            uc.Location = new System.Drawing.Point(80, 130);
            uc.BringToFront();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
