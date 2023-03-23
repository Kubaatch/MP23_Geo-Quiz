using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_Statistics : UserControl
    {
        readonly GameSpecs gameInfo = new GameSpecs();
        readonly string gameMode;
        readonly TimeSpan totalTime = new TimeSpan();

        public int finalScore;
        public int averageScore;

        public string filepath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\", "Data");

        public bool savedStats = false;

        public UC_Statistics(int score, TimeSpan ts, GameSpecs gamespecs, string mode)
        {
            gameInfo = gamespecs;
            totalTime = ts;
            finalScore = score;
            gameMode = mode;

            InitializeComponent();

            SetResults();

            AddRows();
        }

        private void SetResults()
        {
            L_Score.Text += finalScore + " pts.";

            averageScore = finalScore / gameInfo.QuestionCount;
            L_AvgScore.Text += averageScore + " pts.";

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
            string[] statsLines = File.ReadAllLines(path);

            statsLines = FilterCategories(statsLines);

            string[] tempRowArray = new string[StatsGridView.ColumnCount];

            for (int i = 0; i < statsLines.Length; i++)
            {
                for (int j = 0; j < tempRowArray.Length; j++)
                {
                    tempRowArray[j] = statsLines[i].Split('\t')[j];
                }
                StatsGridView.Rows.Add(tempRowArray);
            }

            AddCurrentGame();
            
            SortDataGridView();

            StatsGridView.Refresh();
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

        private void SortDataGridView()
        {
            string rowCellValue;

            for (int i = 0; i < StatsGridView.Rows.Count; i++)
            {
                rowCellValue = StatsGridView.Rows[i].Cells[1].Value.ToString();
                StatsGridView.Rows[i].Cells[1].Value = Convert.ToInt32(rowCellValue);

                rowCellValue = StatsGridView.Rows[i].Cells[2].Value.ToString();
                StatsGridView.Rows[i].Cells[2].Value = Convert.ToInt32(rowCellValue);

                rowCellValue = StatsGridView.Rows[i].Cells[4].Value.ToString();
                StatsGridView.Rows[i].Cells[4].Value = Convert.ToInt32(rowCellValue);
            }

            StatsGridView.Sort(StatsGridView.Columns[1], System.ComponentModel.ListSortDirection.Descending);
            StatsGridView.Sort(StatsGridView.Columns[2], System.ComponentModel.ListSortDirection.Descending);
            StatsGridView.Sort(StatsGridView.Columns[4], System.ComponentModel.ListSortDirection.Descending);
        }

        private void AddCurrentGame()
        {
            object[] currentGame = SetCurrentGameStats();

            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(StatsGridView, currentGame);
            row.DefaultCellStyle.BackColor = Color.Gold;
            row.DefaultCellStyle.SelectionBackColor = Color.Gold;

            StatsGridView.Rows.Add(row);
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

            stats[0] = SetAccount();
            stats[1] = finalScore;
            stats[2] = averageScore;
            //copied from https://stackoverflow.com/questions/2058637/custom-format-timespan-with-string-format
            stats[3] = string.Format("{0:00}hrs., {1:00}min., {2:00}s.", Math.Truncate(totalTime.TotalHours), totalTime.Minutes, totalTime.Seconds);
            //end
            stats[4] = gameInfo.QuestionCount;
            stats[5] = UC_GameUI.categories[gameInfo.Category];
            stats[6] = SetContinents();

            return stats;
        }

        private string SetAccount()
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