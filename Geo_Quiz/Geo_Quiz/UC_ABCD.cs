using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Geo_Quiz
{
    public partial class UC_ABCD : UserControl
    {
        readonly Button B_Start = new Button();
        readonly GameSpecs GS_ABCD = new GameSpecs();
        readonly Random random = new Random();

        readonly string filepath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\", "Data");

        private string categoryPrint = "";
        private string labelQuestion;

        private int questionNumber = 0;

        readonly List<Image> flags = new List<Image>();
        public Image[] qFlags = new Image[0];

        public UC_ABCD(int category, string[] continents, int QCount)
        {            
            GS_ABCD.Category = category;
            GS_ABCD.Continents = continents;
            GS_ABCD.QCount = QCount;                       

            InitializeComponent();
            SetStartButton();
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            B_Start.Visible = false;
            
            switch (GS_ABCD.Category)
            {
                case 0:
                    L_Question.Visible = false;

                    LoadFlags();

                    PB_Flag.Image = qFlags.First();
                    PB_Flag.Visible = true;
                    break;
                case 1:
                    categoryPrint = "capital city";
                    break;
                case 2:
                    categoryPrint = "population";
                    break;
                case 3:
                    categoryPrint = "area";
                    break;
            }            

            if (GS_ABCD.Category != 0)
            {
                labelQuestion = "What is the " + categoryPrint + " of:\n";
                GS_ABCD.Questions = GetQuestions();
                L_Question.Text = labelQuestion + GS_ABCD.Questions[0].Split('\t')[0];                
            }
            else
            {
                L_Question.Text = "What country does this flag belong to?";
            }

            progressBar1.Maximum = GS_ABCD.QCount;

            L_Question.Visible = true;

            SetButtonAnswers();

            B_A.Visible = true;
            B_B.Visible = true;
            B_C.Visible = true;
            B_D.Visible = true;
        }

        private void SetButtonAnswers()
        {
            int correctAnswer = random.Next(3);            
            switch (correctAnswer)
            {
                case 0:
                    B_A.Tag = "Correct";
                    SetOtherAnswers();
                    B_A.Text = GS_ABCD.Questions[questionNumber].Split('\t')[GS_ABCD.Category];
                    break;
                case 1:
                    B_B.Tag = "Correct";
                    SetOtherAnswers();
                    B_B.Text = GS_ABCD.Questions[questionNumber].Split('\t')[GS_ABCD.Category];
                    break;
                case 2:
                    B_C.Tag = "Correct";
                    SetOtherAnswers();
                    B_C.Text = GS_ABCD.Questions[questionNumber].Split('\t')[GS_ABCD.Category];
                    break;
                case 3:
                    B_D.Tag = "Correct";
                    SetOtherAnswers();
                    B_D.Text = GS_ABCD.Questions[questionNumber].Split('\t')[GS_ABCD.Category];
                    break;
            }

            //loop through buttons, this is TRASH
            /*
            Button[] buttons = new Button[] { B_A, B_B, B_C, B_D };
            foreach (Button b in buttons)
            {
                if (b.Tag.ToString() == "Correct")
                {
                    b.Text = GS_ABCD.Questions[questionNumber].Split('\t')[GS_ABCD.Category];
                }
                else
                {
                    b.Text = GS_ABCD.Questions[random.Next(193)].Split('\t')[GS_ABCD.Category];
                }
            }
            */
        }

        private void SetOtherAnswers()
        {
            B_A.Text = GS_ABCD.Questions[random.Next(GS_ABCD.Questions.Length)].Split('\t')[GS_ABCD.Category];
            B_B.Text = GS_ABCD.Questions[random.Next(GS_ABCD.Questions.Length)].Split('\t')[GS_ABCD.Category];
            B_C.Text = GS_ABCD.Questions[random.Next(GS_ABCD.Questions.Length)].Split('\t')[GS_ABCD.Category];
            B_D.Text = GS_ABCD.Questions[random.Next(GS_ABCD.Questions.Length)].Split('\t')[GS_ABCD.Category];
        }

        private void AnswerClick(object sender, EventArgs e)
        {
            //this happens everytime -> delay to next question
            questionNumber++;
            progressBar1.Increment(1);
        }

        private void B_A_Click(object sender, EventArgs e)
        {
            //if this is correct, then +
        }

        private void B_B_Click(object sender, EventArgs e)
        {
            //if wrong, then something else
        }

        private void B_C_Click(object sender, EventArgs e)
        {

        }

        private void B_D_Click(object sender, EventArgs e)
        {

        }
        
        private string[] GetQuestions()
        {
            List<string> tempQsList = new List<string>();

            string path = Path.Combine(filepath, "Questions.txt");

            string[] qArr1 = File.ReadAllLines(path);

            for (int i = 0; i < GS_ABCD.Continents.Length; i++)
            {
                int startIndex = Array.IndexOf(qArr1, GS_ABCD.Continents[i]) + 1;
                for (int j = startIndex; j < qArr1.Length; j++)
                {
                    if (string.IsNullOrWhiteSpace(qArr1[j]))
                    { break; }

                    tempQsList.Add(qArr1[j]);
                }
            }

            Random rand = new Random();
            string[] tempQs = tempQsList.ToArray();
            string[] questions = new string[GS_ABCD.QCount];

            //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, tempQs.Length).OrderBy(x => rand.Next()).Distinct().Take(GS_ABCD.QCount);
            questions = tempList.Select(j => tempQs[j]).ToArray();
            //end

            return questions;
        }

        public void LoadFlags()
        {
            string path = Path.Combine(filepath, "");

            for (int i = 0; i < GS_ABCD.Continents.Length; i++)
            {
                string continentPath = Path.Combine(path, GS_ABCD.Continents[i]);
                GetContinentFlags(continentPath);
            }

            Random rand = new Random();

            //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, flags.Count).OrderBy(x => rand.Next()).Distinct().Take(GS_ABCD.QCount);
            qFlags = tempList.Select(j =>
            {
                Image image = flags[j];
                image.Tag = Path.GetFileName(image.Tag.ToString());
                return image;
            }).ToArray();
            //end
        }

        public void GetContinentFlags(string path)
        {
            string[] files = Directory.GetFiles(path, "*.png");

            for (int i = 0; i < files.Length; i++)
            {
                Image image = Image.FromFile(files[i]);
                flags.Add(image);
                flags.Last().Tag = Path.GetFileName(files[i]);
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the game?\n" +
            "You will lose all your progress and your stats will be lost...", "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void SetStartButton()
        {            
            B_Start.Text = "Start";
            B_Start.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Start.BackColor = SystemColors.ButtonHighlight;                            
            B_Start.Size = new Size(200, 100);                        
            B_Start.UseVisualStyleBackColor = false;
            B_Start.Click += new EventHandler(this.B_Start_Click);
            B_Start.Anchor = AnchorStyles.Bottom| AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;

            tableLayoutPanel1.SetColumnSpan(B_Start, 2);
            tableLayoutPanel1.SetRowSpan(B_Start, 2);
            tableLayoutPanel1.Controls.Add(B_Start, 1, 4);
        }

        private void B_Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the game?\n" +
            "You will lose all your progress and your stats will be lost...", "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Dispose();
            }
        }

    }
}

