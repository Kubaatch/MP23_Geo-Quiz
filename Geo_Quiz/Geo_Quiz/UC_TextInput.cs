using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Geo_Quiz
{
    public partial class UC_TextInput : UserControl
    {
        readonly GameSpecs GS_Text = new GameSpecs();

        readonly List<Image> flags = new List<Image>();
        public Image[] qFlags = new Image[0];

        public string answer;
        public int qnumber = 0;

        public int score = 0;
        public static System.Timers.Timer timer;
        public int timerticked = 0;

        public UC_TextInput(int category, string[] continents, int QCount)
        {
            GS_Text.Category = category;                        
            GS_Text.Continents = continents;
            GS_Text.QCount = QCount;

            Array.Resize(ref qFlags, QCount);

            TimerSetup();                        
            
            InitializeComponent();

            L_QCount.Text = "1 / " + GS_Text.QCount;
            L_QCount.Visible = true;

            PBar.Maximum = GS_Text.QCount;
        }

        private void TB_Answer_KeyUpEnter(object sender, KeyEventArgs f)
        {
            if ( f.KeyCode == Keys.Enter)
            {
                SelCheckAnswer();             
            }
        }
        
        private void B_Enter_Click(object sender, EventArgs e)
        {
            SelCheckAnswer();
        }

        private void SelCheckAnswer()
        {
            switch (GS_Text.Category)
            {
                case 0:
                    CheckAnswer_0();
                    break;
                case 1:
                    CheckAnswer_1();
                    break;
                case 2:
                case 3:
                    CheckAnswer_2();
                    break;
            }
        }

        private void CheckAnswer_0()
        {
            answer = qFlags[qnumber].Tag.ToString().Split('.')[0];

            if (TB_Answer.Text.ToLower() == answer.ToLower())
            {
                IfCorrect();
            }
            else
            {
                IfWrong(answer);
            }

            StatsEdit();                        
        }

        private void CheckAnswer_1()
        {
            answer = GS_Text.Questions[qnumber].Split('\t')[GS_Text.Category];
            string ansInput = TB_Answer.Text;

            if (ansInput.ToLower() == answer.ToLower())
            {
                IfCorrect();
            }
            else
            {
                IfWrong(answer);
            }

            StatsEdit();
        }

        private void CheckAnswer_2()
        {
            answer = GS_Text.Questions[qnumber].Split('\t')[GS_Text.Category];
            double dCorrect = Convert.ToDouble(answer);

            bool success = double.TryParse(TB_Answer.Text, out double dInput);

            if (success)
            {
                if ((dCorrect / 1.15) < dInput && dInput < (dCorrect * 1.15))
                {
                    IfCorrect();
                }
                else
                {
                    IfWrong(answer);
                }
            }
            else
            {
                IfWrong(answer);
            }

            StatsEdit();
        }

        private void IfCorrect()
        {
            L_Result.Text = "Correct!";
            L_Result.ForeColor = Color.Green;
            L_Result.Visible = true;

            if (GS_Text.Category > 1)
            {            
                L_CorrectResult.Text = "The exact number is: ";
                L_CorrectResult.Text += answer;
                L_CorrectResult.Visible = true;
            }

            if (timerticked > 100)
            {
                score += 0;
            }
            else
            {
                score += 100 - timerticked;
            }
            L_Score.Text = "Score: " + score;
        }

        private void IfWrong(string answer)
        {
            L_Result.Text = "Wrong...";
            L_Result.Visible = true;

            L_CorrectResult.Text += answer;
            L_CorrectResult.Visible = true;

            score -= 50;
            L_Score.Text = "Score: " + score;
        }

        private void StatsEdit()
        {
            B_Skip.Enabled = false;
            B_Enter.Enabled = false;
            B_Next.Enabled = true;

            TB_Answer.Enabled = false;

            PBar.Increment(1);
        }

        private void B_Skip_Click(object sender, EventArgs e)
        {           
            if (GS_Text.Category == 0)
            {
                answer = qFlags[qnumber].Tag.ToString().Split('.')[0];
            }
            else
            {            
                answer = GS_Text.Questions[qnumber].Split('\t')[GS_Text.Category]; 
            }

            IfWrong(answer);

            StatsEdit();
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            qnumber++;
            L_QCount.Text = qnumber + 1 + " / " + GS_Text.QCount;

            if (qnumber == GS_Text.QCount - 1)
            {
                B_Next.Text = "End Quiz";
            }

            if (qnumber == GS_Text.QCount)
            {
                PBar.Visible = false;

                UC_Statistics uc = new UC_Statistics();
                uc.Dock = DockStyle.Fill;
                Controls.Add(uc);
                uc.BringToFront();
            }
            else
            {
                if (GS_Text.Category == 0)
                {
                    PB_Flag.Image = qFlags[qnumber];
                }
                else
                {                
                    L_Country.Text = GS_Text.Questions[qnumber].Split('\t')[0];
                }
            }

            NextQSetup();
        }

        private void NextQSetup()
        {
            timerticked = 0;

            B_Skip.Enabled = true;
            B_Enter.Enabled = true;
            B_Next.Enabled = false;

            L_Result.Visible = false;
            L_Result.ForeColor = Color.Red;
            L_CorrectResult.Visible = false;
            L_CorrectResult.Text = "Correct answer is: ";

            TB_Answer.Text = "Enter answer here";
            TB_Answer.Enabled = true;

            TB_Answer.Focus();
        }

        private void B_Start_Click(object sender, EventArgs e)
        {   
            switch (GS_Text.Category)
            {
                case 0:
                    L_Question.Visible = false;
                    L_Country.Visible = false;
                    
                    LoadFlags(GS_Text.Continents);

                    PB_Flag.Image = qFlags.First();
                    PB_Flag.Visible = true;
                    break;
                case 1:
                    L_Question.Text = "What is the capital city of: ";
                    GS_Text.Questions = GetQuestions();
                    L_Country.Text = GS_Text.Questions[0].Split('\t')[0];
                    break;
                case 2:
                    L_Question.Text = "What is the population of: ";
                    GS_Text.Questions = GetQuestions();
                    L_Country.Text = GS_Text.Questions[0].Split('\t')[0];
                    break;
                case 3:
                    L_Question.Text = "What is the area of: ";
                    GS_Text.Questions = GetQuestions();
                    L_Country.Text = GS_Text.Questions[0].Split('\t')[0];
                    break;                
            }

            TB_Answer.Enabled = true;
            B_Skip.Enabled = true;
            B_Enter.Enabled = true;
            B_Start.Visible = false;

            timer.Start();
        }

        private string[] GetQuestions()
        {            
            List<string> tempQsList = new List<string>();            

            string fixedpath = Directory.GetCurrentDirectory();
            fixedpath = Path.Combine(fixedpath, "Flags", "Questions.txt");

            string[] qArr1 = File.ReadAllLines(fixedpath); 
                
            for (int i = 0; i < GS_Text.Continents.Length; i++)
            {
                int startIndex = Array.IndexOf(qArr1, GS_Text.Continents[i]) + 1;
                for (int j = startIndex; j < qArr1.Length; j++)
                {
                    if (string.IsNullOrWhiteSpace(qArr1[j]))
                    { break; }

                    tempQsList.Add(qArr1[j]);
                }
            }                       
                        
            Random rand = new Random();
            string[] tempQs = tempQsList.ToArray();
            string[] questions = new string[GS_Text.QCount];

                //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, tempQs.Length).OrderBy(x => rand.Next()).Distinct().Take(GS_Text.QCount);
            questions = tempList.Select(j => tempQs[j]).ToArray();
                //end
            
            return questions;
        }

        private void LoadFlags(string[] continents)
        {
            string fixedpath = Directory.GetCurrentDirectory();
            fixedpath = Path.Combine(fixedpath, "Flags");

            for (int i = 0; i < continents.Length; i++)
            {
                string path = Path.Combine(fixedpath, continents[i]);
                GetContinentFlags(path);
            }

            Random rand = new Random();

            //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, flags.Count).OrderBy(x => rand.Next()).Distinct().Take(GS_Text.QCount);
            qFlags = tempList.Select(j =>
            {
                Image image = flags[j];
                image.Tag = Path.GetFileName(image.Tag.ToString());
                return image;
            }).ToArray();
            //end
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

        private void TimerSetup()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            timerticked += 1;
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TB_Answer_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;                
            }
        }

        private void TB_Answer_GotFocus(object sender, EventArgs e)
        {
            TB_Answer.Text = string.Empty;
        }
    }
}
