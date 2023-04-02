using System;
using System.IO;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class F_SignIn : Form
    {
        public static Button[] buttons;

        public static string header;
        public static string type;
        public static bool loggedIn = false;
        public static string loggedInAccount;

        public static string filepath = GetPath();

        public F_SignIn()
        {
            InitializeComponent();

            //can be removed, but visuals look terrible afterwards
            MaximizeBox = false;

            buttons = new Button[] { B_MainMenu, B_SignIn, B_SignUp, B_Exit };
        }

        private static string GetPath()
        {
            string path = Directory.GetCurrentDirectory();

            //copied from https://social.msdn.microsoft.com/Forums/vstudio/en-US/221c9385-e2a8-4630-b2f5-f4eabfd62df5/programmatically-detect-whenever-test-run-is-in-debug-mode?forum=vsunittest
            if (System.Diagnostics.Debugger.IsAttached)
            {
                path = Path.Combine(path, "..", "..");
            }
            //end

            path = Path.Combine(path, "Data");

            return path;
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
            DisableButtons();

            UC_MainMenu uc = new UC_MainMenu();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_SignUp_Click(object sender, EventArgs e)
        {
            if (loggedIn == true)
            {
                DialogResult result = MessageBox.Show("You are already logged in, do you want to change account by signing up a new one?",
                    "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    header = "Sign up a new account:";
                    type = "SignUp";

                    OpenLogin();
                }
            }
            else
            {
                header = "Sign up a new account:";
                type = "SignUp";

                OpenLogin();
            }
        }

        private void B_SignIn_Click(object sender, EventArgs e)
        {
            if (loggedIn == true)
            {
                DialogResult result = MessageBox.Show("You are already logged in, do you want to change account by signing in to another one?",
                   "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    header = "Sign in an existing account:";
                    type = "SignIn";

                    OpenLogin();
                }
            }
            else
            {
                header = "Sign in an existing account:";
                type = "SignIn";

                OpenLogin();
            }
        }

        public void SetCurrentAccLabel()
        {
            L_CurrentAcc.Text = "Current account: " + loggedInAccount;
        }

        public void SetGuestLabel()
        {
            loggedIn = false;

            L_CurrentAcc.Text = "Not yet logged in...";
        }

        private void OpenLogin()
        {
            DisableButtons();

            int pointX = Width / 2 - 300;
            int pointY = Height / 2 - 125;

            UC_Login uc = new UC_Login();
            Controls.Add(uc);
            uc.Location = new System.Drawing.Point(pointX, pointY);
            uc.BringToFront();
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
