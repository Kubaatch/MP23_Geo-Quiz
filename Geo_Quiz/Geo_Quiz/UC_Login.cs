using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_Login : UserControl
    {
        string[] fileAccounts;
        static string currentAccount;
        string newAccount;

        string enteredUsername;
        string enteredPassword;
        string[] usernames = new string[0];
        string[] passwords = new string[0];

        public static string filepath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\", "Data", "Accounts.txt");

        public UC_Login()
        {
            InitializeComponent();

            L_Header.Text = F_SignIn.header;

            fileAccounts = File.ReadAllLines(filepath);

            Array.Resize(ref usernames, fileAccounts.Length);
            Array.Resize(ref passwords, fileAccounts.Length);

            int i = 0;
            foreach (string s in fileAccounts)
            {
                usernames[i] = s.Split('\t')[0];
                passwords[i] = s.Split('\t')[1];

                i++;
            }
        }

        private void B_Enter_Click(object sender, EventArgs e)
        {
            enteredUsername = TB_Username.Text;
            enteredPassword = TB_Password.Text;

            switch (F_SignIn.type)
            {
                case "SignIn":
                    SignIn();
                    break;
                case "SignUp":
                    SignUp();
                    break;
            }
        }

        private void SignUp()
        {
            bool success = true;

            foreach (string s in usernames)
            {
                if (enteredUsername == s)
                {
                    L_ExistingUsername.Visible = true;
                    TB_Username.Text = "";
                    TB_Password.Text = "";
                    success = false;
                }
            }
            
            if (success == true)
            {
                currentAccount = enteredUsername;

                newAccount = enteredUsername + "\t" + HashPasswords(enteredPassword);

                File.AppendAllText(filepath, newAccount + '\n');

                Dispose();
                OpenMainMenu();
            }
        }

        private void SignIn()
        {
            for (int j = 0; j < usernames.Length; j++)
            {
                if (enteredUsername == usernames[j])
                {
                    if (passwords[j] == HashPasswords(enteredPassword))
                    {
                        currentAccount = usernames[j];

                        Dispose();
                        OpenMainMenu();
                    }
                    else
                    {
                        L_WrongPass.Visible = true;
                        //add code here
                    }
                }
                //else???
            }
        }

        private string HashPasswords(string password)
        {
            SHA256 sha256 = SHA256.Create();            
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        private void OpenMainMenu()
        {
            UC_MainMenu uc = new UC_MainMenu();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();            
        }
    }
}
