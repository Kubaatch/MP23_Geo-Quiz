using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_QuizResult : UserControl
    {
        private readonly GameSpecs gameInfo = new GameSpecs();
        private readonly TimeSpan totalTime = new TimeSpan();

        private readonly int finalScore;
        private readonly int correctAnswers;
        private double successRate;
        private readonly string gameMode;

        private readonly string filepath = F_SignIn.filepath;

        private bool savedStats = false;

        public UC_QuizResult(int score, TimeSpan ts, GameSpecs gamespecs, string mode, int correctAns)
        {
            gameInfo = gamespecs;
            totalTime = ts;
            finalScore = score;
            gameMode = mode;
            correctAnswers = correctAns;

            InitializeComponent();

            SetResults();

            AddRows();
        }

        private void SetResults()
        {
            L_Score.Text += finalScore + " pts.";

            successRate = (correctAnswers * 100) / gameInfo.QuestionCount;
            L_AvgScore.Text += successRate + " pts.";

            L_TimeSpent.Text += totalTime.Minutes + "mins, " + totalTime.Seconds + "s, " + totalTime.Milliseconds + "ms.";
        }

        private void AddRows()
        {
            string statsMode;
            if (gameMode == "Text")
            {
                statsMode = "StatsTextInput.txt";
            }
            else
            {
                statsMode = "Stats4Variants.txt";
            }

            string path = Path.Combine(filepath, statsMode);
            string[] statsLines;

            while (true)
            {
                try
                {
                    statsLines = File.ReadAllLines(path);
                    break;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e.Message}\nPlease resolve the problem to continue.");
                }
            }

            statsLines = FilterCategories(statsLines);

            List<object[]> temp = new List<object[]>();

            foreach (string s in statsLines)
            {
                temp.Add(s.Split('\t'));
            }

            foreach (object[] statsLine in temp)
            {
                StatsTable.Rows.Add(statsLine);
            }

            AddCurrentGame();

            StatsTable.Refresh();
        }

        private string[] FilterCategories(string[] statsLines)
        {
            List<string> filteredStats = new List<string>();

            string cat = UC_GameUI.categories[gameInfo.Category];
            string conts = SetContinents();

            for (int i = 0; i < statsLines.Length; i++)
            {
                if (statsLines[i].Contains(cat) && statsLines[i].Contains(conts))
                {
                    filteredStats.Add(statsLines[i]);
                }
            }

            return filteredStats.ToArray();
        }

        private void AddCurrentGame()
        {
            object[] currentGame = SetCurrentGameStats();

            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(StatsTable, currentGame);
            row.DefaultCellStyle.BackColor = Color.Gold;
            row.DefaultCellStyle.SelectionBackColor = Color.Gold;

            StatsTable.Rows.Add(row);
        }

        private void B_SaveStats_Click(object sender, EventArgs e)
        {
            SaveStats();
        }

        private void SaveStats()
        {
            object[] stats = SetCurrentGameStats();

            string scoreText = string.Join("\t", stats);

            if (gameMode == "ABCD")
            {
                string abcdPath = Path.Combine(filepath, "Stats4Variants.txt");
                File.AppendAllText(abcdPath, scoreText + '\n');
            }
            else
            {
                string textPath = Path.Combine(filepath, "StatsTextInput.txt");
                File.AppendAllText(textPath, scoreText + '\n');
            }

            B_SaveStats.Enabled = false;
            savedStats = true;
        }

        private object[] SetCurrentGameStats()
        {
            object[] stats = new object[7];

            stats[0] = SetUsername();
            stats[1] = finalScore;
            stats[2] = successRate + "%";
            //copied from https://stackoverflow.com/questions/2058637/custom-format-timespan-with-string-format
            stats[3] = string.Format("{0:00}hrs., {1:00}min., {2:00}s.", Math.Truncate(totalTime.TotalHours), totalTime.Minutes, totalTime.Seconds);
            //end
            stats[4] = UC_GameUI.selQuestionCount;
            stats[5] = UC_GameUI.categories[gameInfo.Category];
            stats[6] = SetContinents();

            return stats;
        }

        private string SetContinents()
        {
            if (gameInfo.Continents.Length > 1)
            {
                return gameInfo.Continents.Length.ToString();
            }
            else
            {
                return gameInfo.Continents[0];
            }
        }

        private string SetUsername()
        {
            if (F_SignIn.loggedIn == true)
            {
                return F_SignIn.loggedInAccount;
            }
            else
            {
                return "Guest";
            }
        }

        private void StatsTable_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            //copied from https://stackoverflow.com/a/18923791
            if (e.Column.Index == 1 || e.Column.Index == 2)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString().Replace("%", string.Empty)).CompareTo(int.Parse(e.CellValue2.ToString().Replace("%", string.Empty)));
                e.Handled = true;
            }
            //end
        }

        private void GameInfoButton_Click(object sender, EventArgs e)
        {
            string info = string.Format("The quiz you just finished had these specs:\n" +
                "\nCategory: {0}\nContinents: {1}\nQuestion number: {2}\nTotal time: {3}",
                UC_GameUI.categories[gameInfo.Category], SetContinents(), gameInfo.QuestionCount, totalTime.ToString());

            MessageBox.Show(info, "Current game info");
        }

        private void B_ReturnToMenu_Click(object sender, EventArgs e)
        {
            if (savedStats == false)
            {
                string info = "You have not saved the stats from this game yet.\nDo you want to save them before you return to menu?";
                DialogResult result = MessageBox.Show(info, "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveStats();
                }
            }

            CloseAllUserControls(this.Parent.Parent.Parent);
        }

        //generated by an AI (ChatGPT)
        private void CloseAllUserControls(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is UserControl userControl)
                {
                    CloseAllUserControls(userControl);
                    userControl.Dispose();
                }
            }
        }
        //end
    }
}