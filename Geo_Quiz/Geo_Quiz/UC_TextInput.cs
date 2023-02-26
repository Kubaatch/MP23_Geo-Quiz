using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using System.Media;

namespace Geo_Quiz
{
    public partial class UC_TextInput : UserControl
    {
        readonly GameSpecs GS_Text = new GameSpecs();
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
            GS_Text.Questions = GetQuestions();

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
                answer = GS_Text.Questions[qnumber].Split('\t')[GS_Text.Gamemode];

                if (GS_Text.Gamemode == 1)
                {
                    if (TB_Answer.Text.ToLower() == answer.ToLower())
                    {
                        L_Result.Text = "Correct!";
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
                
                }
                else
                {
                    double dCorrect = Convert.ToDouble(answer);
                    double dAnswer = Convert.ToDouble(TB_Answer.Text);

                    if ((dCorrect / 1.15) < dAnswer && dAnswer < (dCorrect * 1.15))
                    {
                        L_Result.Text = "Correct!";
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
                        score = 0;
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

                qnumber++;

                B_Skip.Visible = false;
                B_Next.Visible = true;

                TB_Answer.Enabled = false;
            }
        }                     

        private void B_Skip_Click(object sender, EventArgs e)
        {
            B_Skip.Visible = false;
            B_Next.Visible = true;

            L_Result.Text = "Wrong...";
            L_Result.Visible = true;

            score -= 50;
            L_Score.Text = "Score: " + score;

            answer = GS_Text.Questions[qnumber].Split('\t')[GS_Text.Gamemode];            
            L_CorrectResult.Text += answer;
            L_CorrectResult.Visible = true;

            TB_Answer.Enabled = false;
            qnumber++;
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            PBar.Increment(1);
            L_QCount.Text = qnumber+1 + " / " + GS_Text.QCount;

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
                L_Country.Text = GS_Text.Questions[qnumber].Split('\t')[0];

                timerticked = 0;

                B_Skip.Visible = true;
                B_Next.Visible = false;

                L_Result.Visible = false;
                L_CorrectResult.Visible = false;
                L_CorrectResult.Text = "Correct answer is: ";

                TB_Answer.Text = "Enter answer here";
                TB_Answer.Enabled = true;
            }
        }

        private string[] GetQuestions()
        {
            string[] lines = new string[0];         
            string[] file = File.ReadAllLines(@"C:\Users\kubik\source\repos\MP23_Geo-Quiz\Geo_Quiz\Questions_C.txt");
            //simplify to work on any computer!    

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
                        
            Random random = new Random();
            string[] questions = new string[GS_Text.QCount];

                //generated by an AI (ChatGPT)
            IEnumerable<int> randomIndices = Enumerable.Range(0, lines.Length).OrderBy(x => random.Next()).Distinct().Take(GS_Text.QCount);
            questions = randomIndices.Select(j => lines[j]).ToArray();
                //end
            
            return questions;
        }             
        
        private void B_Start_Click(object sender, EventArgs e)
        {
            switch (GS_Text.Gamemode)
            {
                case 1:
                    L_Question.Text = "What is the capital city of: ";
                    break;
                case 2:
                    L_Question.Text = "What is the population of: ";
                    break;
                case 3:
                    L_Question.Text = "What is the area of: ";
                    break;
            }

            TB_Answer.Enabled = true;
            B_Skip.Enabled = true;
            
            L_Country.Text = GS_Text.Questions[0].Split('\t')[0];

            B_Start.Visible = false;

            timer.Start();
        }

        private void TB_Answer_GotFocus(object sender, EventArgs e)
        {
            TB_Answer.Text = string.Empty;
        }

        private void TB_Answer_LostFocus(object sender, EventArgs e)
        {
            TB_Answer.Text = "Enter answer here";
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
