using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Geo_Quiz
{
    public partial class UC_TextInput : UserControl
    {
        readonly GameSpecs GS_Text = new GameSpecs();
        readonly Button B_Start = new Button();

        readonly string filepath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\", "Data");
        readonly List<Image> flags = new List<Image>();
        public static Image[] qFlags = new Image[0];

        private string categoryPrint = "";        
        private string labelQuestion;

        public string answer;
        public int qnumber = 0;

        public int score = 0;
        public static System.Timers.Timer timer;
        public int timerticked = 0;

        public UC_TextInput(int category, string[] continents, int QCount)
        {            
            GS_Text.Category = category;                        
            GS_Text.Continents = continents;
            GS_Text.QuestionCount = QCount;

            Array.Resize(ref qFlags, QCount);
                        
            InitializeComponent();
            SetStartButton();
            ControlsSetup();
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

            IfWrong(answer, 30);

            ControlsEdit();
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            qnumber++;
            L_QCount.Text = qnumber + 1 + " / " + GS_Text.QuestionCount;

            if (qnumber == GS_Text.QuestionCount - 1)
            {
                B_Next.Text = "End Quiz";
            }

            if (qnumber == GS_Text.QuestionCount)
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
                    L_Question.Text = labelQuestion + GS_Text.Questions[qnumber].Split('\t')[0];
                }
            }

            NextQSetup();
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
                IfWrong(answer, 50);
            }

            ControlsEdit();                        
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
                IfWrong(answer, 50);
            }

            ControlsEdit();
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
                    IfWrong(answer, 50);
                }
            }
            else
            {
                IfWrong(answer, 60);
            }

            ControlsEdit();
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

        private void IfWrong(string answer, int minusPoints)
        {
            L_Result.Text = "Wrong...";
            L_Result.Visible = true;

            L_CorrectResult.Text += answer;
            L_CorrectResult.Visible = true;

            score -= minusPoints;
            L_Score.Text = "Score: " + score;
        }

        private void ControlsEdit()
        {
            B_Skip.Enabled = false;
            B_Enter.Enabled = false;
            B_Next.Enabled = true;

            TB_Answer.Enabled = false;

            PBar.Increment(1);
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
            B_Start.Visible = false;
            L_Question.Visible = true;
            TB_Answer.Visible = true;

            switch (GS_Text.Category)
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

            if (GS_Text.Category != 0)
            {
                labelQuestion = "What is the " + categoryPrint + " of:\n";
                GS_Text.Questions = GetQuestions();
                L_Question.Text = labelQuestion + GS_Text.Questions[0].Split('\t')[0];
            }

            TB_Answer.Enabled = true;
            B_Skip.Enabled = true;
            B_Enter.Enabled = true;

            timer.Start();
        }

        private string[] GetQuestions()
        {            
            List<string> tempQsList = new List<string>();

            string path = Path.Combine(filepath, "Questions.txt");

            string[] qArr1 = File.ReadAllLines(path); 
                
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
            string[] questions = new string[GS_Text.QuestionCount];

                //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, tempQs.Length).OrderBy(x => rand.Next()).Distinct().Take(GS_Text.QuestionCount);
            questions = tempList.Select(j => tempQs[j]).ToArray();
                //end
            
            return questions;
        }

        public void LoadFlags()
        {            
            string path = Path.Combine(filepath, "");

            for (int i = 0; i < GS_Text.Continents.Length; i++)
            {
                string continentPath = Path.Combine(path, GS_Text.Continents[i]);
                GetContinentFlags(continentPath);
            }

            Random rand = new Random();

            //generated by an AI (ChatGPT)
            IEnumerable<int> tempList = Enumerable.Range(0, flags.Count).OrderBy(x => rand.Next()).Distinct().Take(GS_Text.QuestionCount);
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

        private void ControlsSetup()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;

            L_QCount.Text = "1 / " + GS_Text.QuestionCount;
            L_QCount.Visible = true;

            PBar.Maximum = GS_Text.QuestionCount;
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            timerticked += 1;
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
            B_Start.Size = new Size(130, 150);
            B_Start.UseVisualStyleBackColor = false;
            B_Start.Click += new EventHandler(this.B_Start_Click);
            B_Start.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;

            tableLayoutPanel1.SetColumnSpan(B_Start, 3);
            tableLayoutPanel1.SetRowSpan(B_Start, 2);
            tableLayoutPanel1.Controls.Add(B_Start, 1, 3);
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
