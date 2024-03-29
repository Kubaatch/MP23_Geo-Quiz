﻿using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_Login : UserControl
    {
        private string[] fileAccounts;
        private string newAccount;

        private string enteredUsername;
        private string enteredPassword;
        private string[] usernames = new string[0];
        private string[] passwords = new string[0];

        private readonly string fullpath;

        public UC_Login()
        {
            InitializeComponent();
            L_Header.Text = F_SignIn.header;

            fullpath = Path.Combine(F_SignIn.filepath, "Accounts.txt");

            while (true)
            {
                try
                {
                    fileAccounts = File.ReadAllLines(fullpath);
                    break;
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show($"{e.Message}\nPlease resolve the problem to continue. " +
                        $"Click on retry to try again, cancelling fully closes the app.", "¯\\_(ツ)_/¯", MessageBoxButtons.RetryCancel);

                    if (result == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
            }

            SetUsernamesAndPasswords();
        }

        private void SetUsernamesAndPasswords()
        {
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

            L_WrongPass.Visible = false;
            L_WrongUsername.Visible = false;

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
            bool successUsername = true;
            bool successPass = true;

            enteredUsername = enteredUsername.Trim();
            if (enteredUsername == null || enteredUsername == "" || enteredUsername.Length > 32 || enteredUsername.Contains('\t'))
            {
                successUsername = false;
                L_WrongUsername.Visible = true;
            }

            enteredPassword = enteredPassword.Trim();
            if (enteredPassword == null || enteredPassword == "" || enteredPassword.Length > 32 || enteredPassword.Contains('\t'))
            {
                successPass = false;
                L_WrongPass.Visible = true;
            }

            foreach (string s in usernames)
            {
                if (enteredUsername == s)
                {
                    L_WrongUsername.Visible = true;
                    TB_Username.Text = "";
                    TB_Password.Text = "";
                    successUsername = false;
                }
            }

            if (successUsername == true && successPass == true)
            {
                newAccount = enteredUsername + '\t' + HashPasswords(enteredPassword) + '\n';

                File.AppendAllText(fullpath, newAccount);

                CloseLogInUC();
            }
        }

        private void SignIn()
        {
            bool success = false;

            for (int j = 0; j < usernames.Length; j++)
            {
                if (enteredUsername == usernames[j])
                {
                    success = true;
                    if (passwords[j] == HashPasswords(enteredPassword))
                    {
                        SuccessfulLogIn(usernames[j]);
                    }
                    else
                    {
                        L_WrongPass.Visible = true;
                        TB_Password.Text = "";
                    }
                }
            }

            if (success == false)
            {
                L_WrongUsername.Visible = true;
            }
        }

        private void SuccessfulLogIn(string setUsername)
        {
            F_SignIn.loggedIn = true;
            F_SignIn.loggedInAccount = setUsername;

            //generated by an AI (ChatGPT)
            F_SignIn form = ParentForm as F_SignIn;
            form.SetCurrentAccLabel();
            //end

            CloseLogInUC();
        }

        //copied tutorial from https://www.youtube.com/watch?v=IO4xdQVuRZQ
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
        //end

        private void B_Exit_Click(object sender, EventArgs e)
        {
            CloseLogInUC();
        }

        private void CloseLogInUC()
        {
            F_SignIn form = ParentForm as F_SignIn;
            form.EnableButtons();

            Dispose();
        }
    }
}
