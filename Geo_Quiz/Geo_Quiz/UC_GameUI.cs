﻿using System;
using System.Collections.Generic;
using System.Data;
using Image = System.Drawing.Image;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;

namespace Geo_Quiz
{
    public partial class UC_GameUI : UserControl
    {
        public static readonly string[] categories = {
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

        readonly string filepath = UC_Login.filepath;
        readonly List<Image> flags = new List<Image>();
        Image[] qFlags = new Image[0];

        private int SelectedCategory;
        private string[] SelectedContinents;
        private int QuestionCount;

        private object[] questions;

        public UC_GameUI()
        {
            InitializeComponent();

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

            SetQuestionCount();

            if (SelectedContinents == null || SelectedContinents.Length == 0)
            {
                DialogResult result1 = MessageBox.Show("You haven't chosen any continents, are you sure you want to continue?"
                    + "\nSelecting no continents works as if all were selected...", "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);

                if (result1 == DialogResult.Yes)
                {
                    SelectedContinents = continents.ToArray();                    
                    goto Success;
                }
                else
                {
                    return;
                }
            }

            Success:;

            LoadQuestions();

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

        private void LoadQuestions()
        {
            if (SelectedCategory == 0)
            {
                questions = LoadFlags();
            }
            else
            {
                questions = GetQuestions();
            }

            if (QuestionCount > questions.Length)
            {
                QuestionCount = questions.Length;
            }
        }

        private string[] GetQuestions()
        {
            List<string> tempQsList = new List<string>();

            string path = Path.Combine(filepath, "Questions.txt");

            string[] qArr = File.ReadAllLines(path);

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

            for (int i = 0; i < SelectedContinents.Length; i++)
            {
                string continentPath = Path.Combine(path, SelectedContinents[i]);
                GetContinentFlags(continentPath);
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

        private void GetContinentFlags(string path)
        {
            string[] files = Directory.GetFiles(path, "*.png");

            for (int i = 0; i < files.Length; i++)
            {
                Image image = Image.FromFile(files[i]);
                flags.Add(image);
                flags.Last().Tag = Path.GetFileName(files[i]);
            }
        }

        private void StartGame(object sender)
        {
            Button clickedButton = sender as Button;
            UserControl uc;

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

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
