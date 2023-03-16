using System;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class F_SignIn : Form
    {
        public static string header;
        public static string type;

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
