using Geo_Quiz.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_ABCD : UserControl
    {
        private readonly Button B_Start = new Button();
        private readonly GameSpecs GS_ABCD = new GameSpecs();
        private readonly Random random = new Random();
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Stopwatch stopwatchTotal = new Stopwatch();
        public static Button[] buttonsDE;
        private readonly Button[] answerButtons;

        private string categoryPrint = "";
        private string labelQuestion;
        private const int deviation = 2;
        private int questionNumber = 0;
        private int score = 0;
        private int correctAnswers = 0;

        private readonly Image[] qFlags = new Image[0];

        private readonly string[] questions;
        private readonly string[] answers;

        public UC_ABCD(int category, string[] continents, int QCount, object[] setQuestions)
        {
            GS_ABCD.Category = category;
            GS_ABCD.Continents = continents;
            GS_ABCD.QuestionCount = QCount;

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
            buttonsDE = new Button[] { B_Start, B_Next, B_Exit, Button_A, Button_B, Button_C, Button_D };
            answerButtons = new Button[] { Button_A, Button_B, Button_C, Button_D };

            SetStartButton();
        }

        private void SetQuestions(object[] sentQuestions)
        {
            string[] strQuestions = sentQuestions as string[];
            int category = GS_ABCD.Category;

            for (int i = 0; i < strQuestions.Length; i++)
            {
                questions[i] = strQuestions[i].Split('\t')[0];
                answers[i] = strQuestions[i].Split('\t')[category];
            }
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            switch (GS_ABCD.Category)
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
            }

            if (GS_ABCD.Category == 0)
            {
                L_Question.Text = "What country does this flag belong to?";
            }
            else
            {
                labelQuestion = "What is the " + categoryPrint + " of:\n";
                L_Question.Text = labelQuestion + questions[0];
            }

            SetButtonAnswers();
            ControlsSetup();
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

            switch (GS_ABCD.Category)
            {
                case 0:
                    AnswerFlag(answerButtons);
                    break;
                case 1:
                    AnswerCapitalCity(answerButtons);
                    break;
                case 2:
                case 3:
                    AnswerPopulationArea(answerButtons);
                    break;
            }
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
                    return answers[questionNumber];
                default:
                    throw new NotImplementedException();
            }
        }

        private void AnswerFlag(Button[] buttons)
        {
            string correctAnswer = GetAnswer();
            string[] fakeAnswers = new string[buttons.Length - 1];

            int randNum;
            string temp;

            for (int i = 0; i < buttons.Length - 1; i++)
            {
            AGAIN:;

                do
                {
                    randNum = random.Next(qFlags.Length);
                    temp = qFlags[randNum].Tag.ToString().Split('.')[0];
                }
                while (temp == correctAnswer);

                foreach (string s in fakeAnswers)
                {
                    if (temp == s)
                    {
                        goto AGAIN;
                    }
                }

                fakeAnswers[i] = temp;
            }

            int j = 0;
            foreach (Button b in buttons)
            {

                if (b.Tag != null && b.Tag.ToString() == "Correct")
                {
                    b.Text = correctAnswer;
                }
                else
                {
                    b.Text = fakeAnswers[j];
                    j++;
                }
            }
        }

        private void AnswerCapitalCity(Button[] buttons)
        {
            string correctAnswer = GetAnswer();

            string[] fakecities = Resources.Cities.Split('\n');
            string[] fakeAnswers = new string[buttons.Length - 1];

            int randNum;
            string temp;


            for (int i = 0; i < buttons.Length - 1; i++)
            {
            AGAIN:;

                do
                {
                    randNum = random.Next(fakecities.Length);
                    temp = fakecities[randNum];
                }
                while (temp == correctAnswer);

                foreach (string s in fakeAnswers)
                {
                    if (s == temp)
                    {
                        goto AGAIN;
                    }
                }

                fakeAnswers[i] = temp;
            }

            int j = 0;
            foreach (Button b in buttons)
            {
                if (b.Tag != null && b.Tag.ToString() == "Correct")
                {
                    b.Text = correctAnswer;
                }
                else
                {
                    b.Text = fakeAnswers[j];
                    j++;
                }
            }
        }

        private void AnswerPopulationArea(Button[] buttons)
        {
            string answer = GetAnswer();
            int.TryParse(answer, out int intAnswer);

            int[] fakeAnswers = new int[buttons.Length - 1];
            int temp;
            int integerLimit = 2147483647;

            int minValue = intAnswer / deviation;
            int maxValue = intAnswer * deviation;

            int aboveCorrectNum = random.Next(4);
            int aboveCorrectCount = 0;

            for (int i = 0; i < buttons.Length - 1; i++)
            {
                AGAIN:;

                if (intAnswer >= integerLimit / 2)
                {
                    maxValue = integerLimit;
                }
                else if (intAnswer < 10)
                {
                    minValue = 1;
                    maxValue = 10;
                }

                if (aboveCorrectCount < aboveCorrectNum)
                {
                    do
                    {
                        temp = random.Next(intAnswer, maxValue);
                    }
                    while (temp < (intAnswer * 1.05));
                }
                else
                {
                    do
                    {
                        temp = random.Next(minValue, intAnswer);
                    }
                    while (temp > (intAnswer / 1.05));
                }

                foreach (int s in fakeAnswers)
                {
                    if (s == temp)
                    {
                        goto AGAIN;
                    }
                }

                fakeAnswers[i] = temp;
                aboveCorrectCount++;
            }

            int j = 0;
            foreach (Button button in buttons)
            {
                if (button.Tag != null && button.Tag.ToString() == "Correct")
                {
                    button.Text = intAnswer.ToString();
                }
                else
                {
                    button.Text = fakeAnswers[j].ToString();
                    j++;
                }
            }
        }

        private void Button_Click_Answer(object sender, EventArgs e)
        {
            stopwatch.Stop();

            //copied from https://stackoverflow.com/questions/13853028/how-to-detect-which-button-was-clicked-in-code-behind
            Button clickedButton = sender as Button;
            //end

            int tempscore;

            if (clickedButton.Tag != null && clickedButton.Tag.ToString() == "Correct")
            {
                L_Result.Text = "Correct!";
                L_Result.ForeColor = Color.ForestGreen;
                clickedButton.BackColor = Color.ForestGreen;

                correctAnswers += 1;

                int timeSpent = (int)stopwatch.ElapsedMilliseconds / 20;
                tempscore = 1000 - timeSpent;
                if (tempscore < 0) { tempscore = 0; }
            }
            else
            {
                L_Result.Text = "Wrong...";
                L_Result.ForeColor = Color.Red;
                clickedButton.BackColor = Color.Red;
                foreach (Button b in answerButtons)
                {
                    if (b.Tag != null && b.Tag.ToString() == "Correct")
                    {
                        b.BackColor = Color.ForestGreen;
                    }
                }

                tempscore = -100;
            }

            score += tempscore;
            L_Score.Text = "Score: " + score.ToString();

            foreach (Button b in answerButtons)
            {
                b.Enabled = false;
                b.Tag = null;
            }

            L_Result.Visible = true;
            B_Next.Visible = true;
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            questionNumber++;

            if (questionNumber == GS_ABCD.QuestionCount)
            {
                OpenStatistics();
            }
            else
            {
                if (questionNumber + 1 == GS_ABCD.QuestionCount)
                {
                    B_Next.Text = "End quiz";
                }

                B_Next.Visible = false;
                L_Result.Visible = false;
                PBar.Increment(1);

                foreach (Button b in answerButtons)
                {
                    b.BackColor = Color.White;
                    b.Enabled = true;
                }

                SetButtonAnswers();

                if (GS_ABCD.Category == 0)
                {
                    PB_Flag.Image = qFlags[questionNumber];
                }
                else
                {
                    L_Question.Text = labelQuestion + questions[questionNumber];
                }

                L_QCount.Text = questionNumber + 1 + " / " + GS_ABCD.QuestionCount;
            }

            stopwatch.Restart();
        }

        private void ControlsSetup()
        {
            B_Start.Visible = false;
            L_Question.Visible = true;

            L_QCount.Text = "1 / " + GS_ABCD.QuestionCount;
            L_QCount.Visible = true;

            PBar.Maximum = GS_ABCD.QuestionCount;

            Button_A.Visible = true;
            Button_B.Visible = true;
            Button_C.Visible = true;
            Button_D.Visible = true;

            stopwatch.Start();
            stopwatchTotal.Start();
        }

        private void OpenStatistics()
        {
            TimeSpan ts = stopwatchTotal.Elapsed;

            DisableButtons();

            UC_QuizResult uc = new UC_QuizResult(score, ts, GS_ABCD, "ABCD", correctAnswers);
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void SetStartButton()
        {
            B_Start.Text = "Start";
            B_Start.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Start.BackColor = SystemColors.ButtonHighlight;
            B_Start.Size = new Size(200, 100);
            B_Start.UseVisualStyleBackColor = false;
            B_Start.Click += new EventHandler(this.B_Start_Click);
            B_Start.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;

            tableLayoutPanel1.SetColumnSpan(B_Start, 2);
            tableLayoutPanel1.SetRowSpan(B_Start, 2);
            tableLayoutPanel1.Controls.Add(B_Start, 1, 3);
        }

        public void DisableButtons()
        {
            foreach (Button b in buttonsDE)
            {
                b.Enabled = false;
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the game?\n" +
            "You will lose all your progress and your stats will be lost...", "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                UC_GameUI parent = Parent as UC_GameUI;
                parent.EnableButtons();

                Dispose();
            }
        }
    }
}

