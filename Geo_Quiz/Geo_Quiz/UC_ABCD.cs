using Geo_Quiz.Properties;
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

        readonly private string filepath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\", "Data");
        readonly private string[] imageFileNames = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\", "Data"), "*.png", SearchOption.AllDirectories);

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
            L_Question.Visible = true;

            switch (GS_ABCD.Category)
            {
                case 0:
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


            SetButtonAnswers();

            Button_A.Visible = true;
            Button_B.Visible = true;
            Button_C.Visible = true;
            Button_D.Visible = true;
        }

        private void SetButtonAnswers()
        {
            int correctAnswer;
            correctAnswer = random.Next(4);

            switch (correctAnswer)
            {
                case 0:
                    Button_A.Tag = "Correct";
                    break;
                case 1:
                    Button_B.Tag = "Correct";        
                    break;
                case 2:
                    Button_C.Tag = "Correct";
                    break;
                case 3:
                    Button_D.Tag = "Correct";
                    break;
            }

            Button[] buttons = new Button[] { Button_A, Button_B, Button_C, Button_D };

            switch (GS_ABCD.Category)
            {
                case 0:
                    AnswerFlag(buttons);
                    break;
                case 1:
                    AnswerCapitalCity(buttons);
                    break;
                case 2:
                case 3:
                    AnswerPopulationArea(buttons);
                    break;
            }
        }

        private void AnswerFlag(Button[] buttons)
        {
            string answer = GetAnswer();

            List<string> Countries = new List<string>();
            int randNum;
            string imageFileName;

            foreach (string s in imageFileNames)
            {
                imageFileName = Path.GetFileNameWithoutExtension(s);
                Countries.Add(imageFileName.Split('.')[0]);
            }

            foreach (Button b in buttons)
            {
                if (b.Tag != null && b.Tag.ToString() == "Correct")
                {
                    b.Text = answer;
                }
                else
                {
                    do
                    {
                        randNum = random.Next(Countries.Count);
                        b.Text = Countries[randNum];
                    } while (Countries[randNum] == answer);
                }
            }
        }

        private void AnswerCapitalCity(Button[] buttons)
        {
            string answer = GetAnswer();
            string[] fakecities = Resources.Cities.Split('\n');
            int randNum;

            foreach (Button b in buttons)
            {
                if (b.Tag != null && b.Tag.ToString() == "Correct")
                {
                    b.Text = answer;
                }
                else
                {
                    randNum = random.Next(fakecities.Length);
                    b.Text = fakecities[randNum];

                    while (fakecities[randNum] == answer)
                    {
                        randNum = random.Next(fakecities.Length);
                        b.Text = fakecities[randNum];
                    }
                }
            }
        }

        private void AnswerPopulationArea(Button[] buttons)
        {
            string answer = GetAnswer();
            double.TryParse(answer, out double intAnswer);

            double fakeAnswer;

            foreach (Button b in buttons)
            {

                if (b.Tag != null && b.Tag.ToString() == "Correct")
                {
                    b.Text = GS_ABCD.Questions[questionNumber].Split('\t')[GS_ABCD.Category];
                }
                else
                {
                    fakeAnswer = random.Next((int)(intAnswer / 1.5), (int)(intAnswer * 1.5));
                    b.Text = fakeAnswer.ToString();

                    while (fakeAnswer == intAnswer)
                    {
                        fakeAnswer = random.Next((int)(intAnswer / 1.5), (int)(intAnswer * 1.5));
                        b.Text = fakeAnswer.ToString();
                    }
                }
            }
        }

        private void Button_Click_Answer(object sender, EventArgs e)
        {
            string answer = GetAnswer();

                //copied from https://stackoverflow.com/questions/13853028/how-to-detect-which-button-was-clicked-in-code-behind
            Button clickedButton = sender as Button;
                //end
            Button[] buttons = new Button[] { Button_A, Button_B, Button_C, Button_D };

            L_Result.Visible = true;

            if (clickedButton.Text == answer)
            {
                L_Result.Text = "Correct!";
                clickedButton.BackColor = Color.ForestGreen;
            }
            else
            {
                L_Result.Text = "Wrong...";
                clickedButton.BackColor = Color.Red;
                foreach (Button b in buttons)
                {
                    if (b.Text == answer)
                    {
                        b.BackColor = Color.ForestGreen;                        
                    }
                }
            }

            foreach (Button b in buttons)
            {
                b.Enabled = false;
                b.Tag = null;
            }
            B_Next.Visible = true;
        }
        
        private void B_Next_Click(object sender, EventArgs e)
        {
            B_Next.Visible = false;
            L_Result.Visible = false;
            progressBar1.Increment(1);

            Button[] buttons = new Button[] { Button_A, Button_B, Button_C, Button_D };

            foreach (Button b in buttons)
            {
                b.BackColor = Color.White;
                b.Enabled = true;
            }            
            
            questionNumber++;
            SetButtonAnswers();
            PB_Flag.Image = qFlags[questionNumber];
        }

        private string GetAnswer()
        {
            switch (GS_ABCD.Category)
            {
                case 0:
                    return qFlags[questionNumber].Tag.ToString().Split('.')[0];
                case 1:
                case 2:                    
                case 3:
                    return GS_ABCD.Questions[questionNumber].Split('\t')[GS_ABCD.Category];
            }

            throw new NotImplementedException();
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
            tableLayoutPanel1.Controls.Add(B_Start, 1, 3);
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
    }
}

