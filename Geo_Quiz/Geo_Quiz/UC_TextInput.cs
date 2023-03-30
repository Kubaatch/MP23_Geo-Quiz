using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Geo_Quiz
{
    public partial class UC_TextInput : UserControl
    {
        private readonly GameSpecs GS_Text = new GameSpecs();
        private readonly Button B_Start = new Button();
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Stopwatch stopwatchTotal = new Stopwatch();
        public static Control[] controls;

        private string categoryPrint;
        private string labelQuestion;

        private string answer;
        private int questionNumber = 0;
        private int score = 0;
        const int minuspoints = 100;
        private int correctAnswers = 0;

        private readonly Image[] qFlags = new Image[0];

        private readonly string[] questions;
        private readonly string[] answers;

        public UC_TextInput(int category, string[] continents, int QCount, object[] setQuestions)
        {
            GS_Text.Category = category;
            GS_Text.Continents = continents;
            GS_Text.QuestionCount = QCount;

            Array.Resize(ref qFlags, QCount);

            if (category == 0)
            {
                qFlags = setQuestions as Image[];
            }
            else
            {
                Array.Resize(ref questions, QCount);
                Array.Resize(ref answers, QCount);

                SetQuestions(setQuestions);
            }

            InitializeComponent();
            StartSetup();

            controls = new Control[] { B_Start, B_Next, B_Enter, B_Exit, TB_Answer };
        }

        private void SetQuestions(object[] sentQuestions)
        {
            string[] strQuestions = sentQuestions as string[];
            int category = GS_Text.Category;

            for (int i = 0; i < strQuestions.Length; i++)
            {
                questions[i] = strQuestions[i].Split('\t')[0];
                answers[i] = strQuestions[i].Split('\t')[category];
            }
        }

        private void TB_Answer_KeyUpEnter(object sender, KeyEventArgs f)
        {
            if (f.KeyCode == Keys.Enter)
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
            stopwatch.Stop();

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
            answer = qFlags[questionNumber].Tag.ToString().Split('.')[0];

            if (TB_Answer.Text.ToLower() == answer.ToLower())
            {
                IfCorrect();
            }
            else
            {
                IfWrong(answer, minuspoints);
            }

            ControlsEdit();
        }

        private void CheckAnswer_1()
        {
            answer = answers[questionNumber];
            string ansInput = TB_Answer.Text;

            if (ansInput.ToLower() == answer.ToLower())
            {
                IfCorrect();
            }
            else
            {
                IfWrong(answer, minuspoints);
            }

            ControlsEdit();
        }

        private void CheckAnswer_2()
        {
            answer = answers[questionNumber];
            double dCorrect = Convert.ToDouble(answer);

            bool success = double.TryParse(TB_Answer.Text, out double dInput);
            double deviation = 1.2;

            if (success)
            {
                if ((dCorrect / deviation) < dInput && dInput < (dCorrect * deviation))
                {
                    IfCorrect();
                }
                else
                {
                    IfWrong(answer, minuspoints);
                }
            }
            else
            {
                IfWrong(answer, 150);
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

            int timeSpent = (int)stopwatch.ElapsedMilliseconds / 25;
            int tempscore = 1000 - timeSpent;
            if (tempscore < 0) { tempscore = 0; }

            score += tempscore;
            correctAnswers++;

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

        private void B_Next_Click(object sender, EventArgs e)
        {
            questionNumber++;
            L_QCount.Text = questionNumber + 1 + " / " + GS_Text.QuestionCount;

            if (questionNumber == GS_Text.QuestionCount - 1)
            {
                B_Next.Text = "End quiz";
            }

            if (questionNumber == GS_Text.QuestionCount)
            {
                stopwatchTotal.Stop();
                OpenStatistics();
            }
            else
            {
                if (GS_Text.Category == 0)
                {
                    PB_Flag.Image = qFlags[questionNumber];
                }
                else
                {
                    L_Question.Text = labelQuestion + questions[questionNumber];
                }
            }

            NextQSetup();
        }

        private void ControlsEdit()
        {
            B_Enter.Enabled = false;
            B_Next.Enabled = true;

            TB_Answer.Enabled = false;

            PBar.Increment(1);
        }

        private void NextQSetup()
        {
            B_Enter.Enabled = true;
            B_Next.Enabled = false;

            L_Result.Visible = false;
            L_Result.ForeColor = Color.Red;
            L_CorrectResult.Visible = false;
            L_CorrectResult.Text = "The correct answer is:\n";

            TB_Answer.Text = "Enter answer here";
            TB_Answer.Enabled = true;

            TB_Answer.Focus();
            stopwatch.Restart();
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            switch (GS_Text.Category)
            {
                case 0:
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
                default:
                    throw new NotImplementedException();
            }

            if (GS_Text.Category != 0)
            {
                labelQuestion = "What is the " + categoryPrint + " of:\n";
                L_Question.Text = labelQuestion + questions[questionNumber];
            }
            else
            {
                L_Question.Text = "What country does this flag belong to?";
            }

            ControlsSetup();
        }

        private void OpenStatistics()
        {
            PBar.Visible = false;

            TimeSpan ts = stopwatchTotal.Elapsed;

            UC_QuizResult uc = new UC_QuizResult(score, ts, GS_Text, "Text", correctAnswers);
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void StartSetup()
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

            L_QCount.Text = "1 / " + GS_Text.QuestionCount;
            L_QCount.Visible = true;

            PBar.Maximum = GS_Text.QuestionCount;
        }

        private void ControlsSetup()
        {
            B_Start.Visible = false;
            L_Question.Visible = true;
            TB_Answer.Visible = true;

            TB_Answer.Enabled = true;
            B_Enter.Enabled = true;

            stopwatch.Start();
            stopwatchTotal.Start();
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
        
        public void DisableButtons()
        {
            foreach (Control c in controls)
            {
                c.Enabled = false;
            }
        }

        public void EnableButtons()
        {
            foreach (Control c in controls)
            {
                c.Enabled = true;
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
    }
}
