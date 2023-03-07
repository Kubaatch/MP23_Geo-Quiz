using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using Geo_Quiz.Properties;
using System.Reflection;
using System.Web;

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

        public UC_TextInput(int gamemode, string[] continents, int QCount)
        {
            GS_Text.Gamemode = gamemode;            
            GS_Text.Continents = continents;
            GS_Text.QCount = QCount;

            Array.Resize(ref qFlags, QCount);

            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;            
            InitializeComponent();

            L_QCount.Text = "1 / " + GS_Text.QCount;
            L_QCount.Visible = true;

            PBar.Maximum = GS_Text.QCount;
        }

        private void TB_Answer_KeyUpEnter(object sender, KeyEventArgs f)
        {
            if ( f.KeyCode == Keys.Enter)
            {
                CheckAnswer();
            }
        }
        
        private void B_Enter_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            if (GS_Text.Gamemode == 1)
            {
                answer = GS_Text.Questions[qnumber].Split('\t')[GS_Text.Gamemode];

                if (TB_Answer.Text.ToLower() == answer.ToLower())
                {
                    L_Result.Text = "Correct!";
                    L_Result.ForeColor = Color.Green;
                    L_Result.Visible = true;
                }
                else
                {
                    L_Result.Text = "Wrong...";
                    L_Result.Visible = true;

                    L_CorrectResult.Text += answer;
                    L_CorrectResult.Visible = true;
                }
            }
            else if (GS_Text.Gamemode == 0)
            {
                answer = qFlags[qnumber].Tag.ToString().Split('.')[0];

                if (TB_Answer.Text.ToLower() == answer.ToLower())
                {
                    L_Result.Text = "Correct!";
                    L_Result.ForeColor = Color.Green;
                    L_Result.Visible = true;
                }
                else
                {
                    L_Result.Text = "Wrong...";
                    L_Result.Visible = true;

                    L_CorrectResult.Text += answer;
                    L_CorrectResult.Visible = true;
                }
            }
            else
            {
                answer = GS_Text.Questions[qnumber].Split('\t')[GS_Text.Gamemode];

                double dCorrect = Convert.ToDouble(answer);
                double dAnswer = Convert.ToDouble(TB_Answer.Text);

                if ((dCorrect / 1.15) < dAnswer && dAnswer < (dCorrect * 1.15))
                {
                    L_Result.Text = "Correct!";
                    L_Result.ForeColor = Color.Green;
                    L_Result.Visible = true;

                    L_CorrectResult.Text = "The exact number is: ";
                    L_CorrectResult.Text += answer;
                    L_CorrectResult.Visible = true;
                }
                else
                {
                    L_Result.Text = "Wrong...";
                    L_Result.Visible = true;

                    L_CorrectResult.Text += answer;
                    L_CorrectResult.Visible = true;
                }
            }

            if (L_Result.Text == "Correct!")
            {
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
            else
            {
                score -= 50;
                L_Score.Text = "Score: " + score;
            }

            B_Skip.Enabled = false;
            B_Enter.Enabled = false;
            B_Next.Enabled = true;

            TB_Answer.Enabled = false;

            PBar.Increment(1);            
        }

        private void B_Skip_Click(object sender, EventArgs e)
        {
            B_Skip.Enabled = false;
            B_Enter.Enabled = false;
            B_Next.Enabled = true;

            L_Result.Text = "Wrong...";
            L_Result.Visible = true;

            score -= 50;
            L_Score.Text = "Score: " + score;

            if (GS_Text.Gamemode == 0)
            {
                answer = qFlags[qnumber].Tag.ToString().Split('.')[0];
            }
            else
            {            
                answer = GS_Text.Questions[qnumber].Split('\t')[GS_Text.Gamemode]; 
            }
            
            L_CorrectResult.Text += answer;
            L_CorrectResult.Visible = true;

            TB_Answer.Enabled = false;
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
                if (GS_Text.Gamemode == 0)
                {
                    PB_Flag.Image = qFlags[qnumber];
                }
                else
                {                
                    L_Country.Text = GS_Text.Questions[qnumber].Split('\t')[0];
                }                

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
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            switch (GS_Text.Gamemode)
            {
                case 0:
                    L_Question.Visible = false;
                    L_Country.Visible = false;
                    
                    LoadFlags(GS_Text.Continents);
                    LoadqFlags();

                    PB_Flag.Image = qFlags.First();
                    PB_Flag.Visible = true;
                    break;
                case 1:
                    GS_Text.Questions = GetQuestions();
                    L_Question.Text = "What is the capital city of: ";
                    L_Country.Text = GS_Text.Questions[0].Split('\t')[0];

                    break;
                case 2:
                    GS_Text.Questions = GetQuestions();
                    L_Question.Text = "What is the population of: ";
                    L_Country.Text = GS_Text.Questions[0].Split('\t')[0];
                    break;
                case 3:
                    GS_Text.Questions = GetQuestions();
                    L_Question.Text = "What is the area of: ";
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
            string[] lines = new string[0];          
            string[] file = Resources.Questions.Split('\n');            

            if (GS_Text.Continents == null || GS_Text.Continents.Length == 0)
            {
                lines = file;
            }
            else
            {
                if (GS_Text.Continents.Contains("Europe"))
            {
                string[] europe = file.Take(47).ToArray();
                lines = lines.Concat(europe).ToArray();
            }

                if (GS_Text.Continents.Contains("Asia"))
            {
                string[] asia = file.Skip(47).Take(47).ToArray();
                lines = lines.Concat(asia).ToArray();
            }

                if (GS_Text.Continents.Contains("Africa"))
            {
                string[] africa = file.Skip(129).Take(54).ToArray();
                lines = lines.Concat(africa).ToArray();
            }

                if (GS_Text.Continents.Contains("America (North & Central)"))
            {
                string[] nAmerica = file.Skip(106).Take(23).ToArray();
                lines = lines.Concat(nAmerica).ToArray();
            }

                if (GS_Text.Continents.Contains("America (South)"))
            {
                string[] sAmerica = file.Skip(94).Take(12).ToArray();
                lines = lines.Concat(sAmerica).ToArray();
            }

                if (GS_Text.Continents.Contains("Oceania"))
            {
                string[] oceania = file.Skip(183).Take(14).ToArray();
                lines = lines.Concat(oceania).ToArray();
            }            
            }
                        
            Random rand = new Random();
            string[] questions = new string[GS_Text.QCount];

                //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, lines.Length).OrderBy(x => rand.Next()).Distinct().Take(GS_Text.QCount);
            questions = tempList.Select(j => lines[j]).ToArray();
                //end
            
            return questions;
        }

        private void LoadFlags(string[] continents)
        {
            if (continents == null || continents.Length == 0)
            {
                Array.Resize(ref continents, 6);
                continents[0] = "Europe";
                continents[1] = "Asia";
                continents[2] = "Africa";
                continents[3] = "America (North & Central)";
                continents[4] = "America (South)";
                continents[5] = "Oceania";
            }            

            string fixedpath = Directory.GetCurrentDirectory();
            fixedpath = Path.Combine(fixedpath, "Flags");

            for (int i = 0; i < continents.Length; i++)
            {
                string path = Path.Combine(fixedpath, continents[i]);
                GetContinentFlags(path);
            }

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

        private void LoadqFlags()
        {
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

        private void TB_Answer_GotFocus(object sender, EventArgs e)
        {
            TB_Answer.Text = string.Empty;
        }


        private void Timer_Elapsed(object sender, EventArgs e)
        {
            timerticked += 1;
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
