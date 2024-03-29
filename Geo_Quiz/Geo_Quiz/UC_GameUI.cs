﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Geo_Quiz
{
    public partial class UC_GameUI : UserControl
    {
        public static string[] categories = {
            "Flags",
            "Capitals",
            "Population",
            "Area"
        };

        public static readonly string[] continents = {
            "Europe",
            "Asia",
            "Africa",
            "North America",
            "South America",
            "Oceania",
            "Others"
        };

        public static readonly string[] questionCounts = {
            "5",
            "10",
            "20",
            "25",
            "50",
            "75",
            "100",
            "Max"
        };

        public static Button[] buttons;
        private readonly string filepath = F_SignIn.filepath;

        private Image[] qFlags = new Image[0];

        private int SelectedCategory;
        private string[] SelectedContinents;
        private int QuestionCount;
        public static string selQuestionCount;

        private object[] questions;

        public UC_GameUI()
        {
            InitializeComponent();

            buttons = new Button[] { B_ABCD, B_TextBox, B_Exit };

            LB_Category.Items.AddRange(categories);
            LB_Continents.Items.AddRange(continents);
            SetQCount.Items.AddRange(questionCounts);
        }

        private void B_Play_Click(object sender, EventArgs e)
        {
            if (LB_Category.SelectedIndices.Count == 0)
            {
                MessageBox.Show("You have to choose a category to start playing!", "¯\\_(ツ)_ /¯");
                return;
            }

            LoadSpecs(sender);
        }

        private void LoadSpecs(object sender)
        {
            SelectedCategory = LB_Category.SelectedIndex;
            SelectedContinents = LB_Continents.SelectedItems.Cast<string>().ToArray();

            if (SetQCount.SelectedItem == null)
            {
                selQuestionCount = "Max";
            }
            else
            {
                selQuestionCount = (string)SetQCount.SelectedItem;
            }

            SetQuestionCount();

            if (SelectedContinents == null || SelectedContinents.Length == 0)
            {
                DialogResult result1 = MessageBox.Show("You haven't chosen any continents, are you sure you want to continue?"
                    + "\nSelecting no continents works as if all were selected...", "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);

                if (result1 == DialogResult.Yes)
                {
                    SelectedContinents = continents.ToArray();
                }
                else
                {
                    return;
                }
            }

            GetQuestions();

            StartGame(sender);
        }

        private void SetQuestionCount()
        {
            bool success = int.TryParse(SetQCount.Text, out int result);
            if (success == true)
            {
                QuestionCount = result;
            }
            else
            {
                QuestionCount = 500;
            }
        }

        private void GetQuestions()
        {
            if (SelectedCategory == 0)
            {
                questions = LoadFlags();
            }
            else
            {
                questions = LoadQuestions();
            }

            if (QuestionCount > questions.Length)
            {
                QuestionCount = questions.Length;
            }
        }

        private string[] LoadQuestions()
        {
            List<string> tempQsList = new List<string>();

            string path = Path.Combine(filepath, "Questions.txt");
            string[] qArr = new string[0];

            while (true)
            {
                try
                {
                    qArr = File.ReadAllLines(path);
                    break;
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show($"{e.Message}\nPlease resolve the problem to continue." +
                        $"Click on retry to try again, cancelling fully closes the app.", "¯\\_(ツ)_/¯", MessageBoxButtons.RetryCancel);

                    if (result == DialogResult.Retry)
                    {
                        Environment.Exit(0);
                    }
                }
            }

            for (int i = 0; i < SelectedContinents.Length; i++)
            {
                int startIndex = Array.IndexOf(qArr, SelectedContinents[i]) + 1;
                for (int j = startIndex; j < qArr.Length; j++)
                {
                    if (string.IsNullOrWhiteSpace(qArr[j]))
                    { break; }

                    tempQsList.Add(qArr[j]);
                }
            }

            Random rand = new Random();
            string[] tempQs = tempQsList.ToArray();
            string[] questions = new string[QuestionCount];

            //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, tempQs.Length).OrderBy(x => rand.Next()).Distinct().Take(QuestionCount);
            questions = tempList.Select(j => tempQs[j]).ToArray();
            //end

            return questions;
        }

        private Image[] LoadFlags()
        {
            string path = Path.Combine(filepath, "");
            List<Image> flags = new List<Image>();

            for (int i = 0; i < SelectedContinents.Length; i++)
            {
                string continentPath = Path.Combine(path, SelectedContinents[i]);
                GetContinentFlags(continentPath, flags);
            }

            Random rand = new Random();

            //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, flags.Count).OrderBy(x => rand.Next()).Distinct().Take(QuestionCount);
            qFlags = tempList.Select(j =>
            {
                Image image = flags[j];
                image.Tag = Path.GetFileName(image.Tag.ToString());
                return image;
            }).ToArray();
            //end

            return qFlags;
        }

        private void GetContinentFlags(string path, List<Image> flags)
        {
            string[] files;

            while (true)
            {
                try
                {
                    files = Directory.GetFiles(path, "*.png");
                    break;
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show($"{e.Message}\nPlease resolve the problem to continue." +
                        $"Click on retry to try again, cancelling fully closes the app.", "¯\\_(ツ)_/¯", MessageBoxButtons.RetryCancel);

                    if (result == DialogResult.Retry)
                    {
                        Environment.Exit(0);
                    }
                }
            }

            Image image;

            for (int i = 0; i < files.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        image = Image.FromFile(files[i]);
                        break;
                    }
                    catch (Exception e)
                    {
                        DialogResult result = MessageBox.Show($"{e.Message}\nPlease resolve the problem to continue." +
                            $"Click on retry to try again, cancelling fully closes the app.", "¯\\_(ツ)_/¯", MessageBoxButtons.RetryCancel);

                        if (result == DialogResult.Retry)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                flags.Add(image);
                flags.Last().Tag = Path.GetFileName(files[i]);
            }
        }

        private void StartGame(object sender)
        {
            Button clickedButton = sender as Button;
            UserControl uc;

            DisableButtons();

            if (clickedButton == B_ABCD)
            {
                uc = new UC_ABCD(SelectedCategory, SelectedContinents, QuestionCount, questions);
            }
            else
            {
                uc = new UC_TextInput(SelectedCategory, SelectedContinents, QuestionCount, questions);
            }
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
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
            UC_MainMenu parent = Parent as UC_MainMenu;
            parent.EnableButtons();

            Dispose();
        }
    }
}
