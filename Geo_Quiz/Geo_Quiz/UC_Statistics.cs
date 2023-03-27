using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_Statistics : UserControl
    {
        private readonly string filepath = UC_Login.filepath;
        List<string> statsLines;

        private string selectedGamemode;
        const string stats1file = "Stats4Variants.txt";
        const string stats2file = "StatsTextInput.txt";
        const string gameMode1 = "4 Options";
        const string gameMode2 = "Written answer";

        private string filterUsername;
        private string filterCategory;
        private string filterContinents;
        private string filterQCount;

        private bool usernameValueChanged = false;
        private bool categoryValueChanged = false;
        private bool continentsValueChanged = false;
        private bool qCountValueChanged = false;

        public UC_Statistics()
        {
            InitializeComponent();
            
            B_GameMode.Text = gameMode1;
            selectedGamemode = stats1file;

            SetFilters();

            string fullpath = Path.Combine(filepath, selectedGamemode);
            statsLines = File.ReadAllLines(fullpath).ToList();
            LoadAllStats(statsLines);
        }

        private void SetFilters()
        {
            F_Username.Items.AddRange(GetUsernames());

            F_Category.Items.AddRange(UC_GameUI.categories);

            F_Continents.Items.AddRange(UC_GameUI.continents);
            string[] multipleConts = new string[] { "2", "3", "4", "5", "6", "7" };
            F_Continents.Items.AddRange(multipleConts);

            F_QCount.Items.AddRange(UC_GameUI.questionCounts);
        }

        private void B_GameMode_Click(object sender, EventArgs e)
        {
            if (B_GameMode.Text == gameMode1)
            {
                B_GameMode.Text = gameMode2;
                selectedGamemode = stats2file;
            }
            else
            {
                B_GameMode.Text = gameMode1;
                selectedGamemode = stats1file;
            }

            string fullpath = Path.Combine(filepath, selectedGamemode);
            statsLines = File.ReadAllLines(fullpath).ToList();
            LoadAllStats(statsLines);
        }

        private string[] GetUsernames()
        {
            string fullpath = Path.Combine(filepath, "Accounts.txt");
            string[] accounts = File.ReadAllLines(fullpath);
            string[] usernames = new string[accounts.Length];

            for (int i = 0; i < accounts.Length; i++)
            {
                usernames[i] = accounts[i].Split('\t')[0];
            }

            return usernames;
        }

        private void LoadAllStats(List<string> statsToLoad)
        {
            StatsTable.Rows.Clear();

            List<string[]> temp = new List<string[]>();

            foreach (string s in statsToLoad)
            {
                temp.Add(s.Split('\t'));
            }

            foreach (string[] statsLine in temp)
            {
                StatsTable.Rows.Add(statsLine);
            }

            foreach (DataGridViewRow row in StatsTable.Rows)
            {
                if ((string)row.Cells[0].Value == F_SignIn.loggedInAccount)
                {
                    row.DefaultCellStyle.BackColor = Color.Gold;
                    row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                }
            }
        }

        private void B_SaveFilters_Click(object sender, EventArgs e)
        {
            StatsTable.Rows.Clear();

            string fullpath = Path.Combine(filepath, selectedGamemode);
            List<string> allStats = File.ReadAllLines(fullpath).ToList();
            List<string> filteredStats = allStats;

            if (usernameValueChanged == true)
            {
                filterUsername = F_Username.SelectedItem.ToString();

                filteredStats = RemoveFilteredLines(filterUsername, filteredStats);
            }

            if (categoryValueChanged == true)
            {
                filterCategory = F_Category.SelectedItem.ToString();

                filteredStats = RemoveFilteredLines(filterCategory, filteredStats);
            }

            if (continentsValueChanged == true)
            {
                filterContinents = F_Continents.SelectedItem.ToString();

                filteredStats = RemoveFilteredLines(filterContinents, filteredStats);
            }

            if (qCountValueChanged == true)
            {
                filterQCount = F_QCount.SelectedItem.ToString();

                filteredStats = RemoveFilteredLines(filterQCount, filteredStats);
            }

            LoadAllStats(filteredStats);

            ValuesChangedToFalse();
        }

        private List<string> RemoveFilteredLines(string filter, List<string> statsToFilter)
        {
            List<string> filtered = new List<string>();
            string[] oneLineValues;

            for (int i = 0; i < statsToFilter.Count; i++)
            {
                oneLineValues = statsToFilter[i].Split('\t');
                foreach (string s in oneLineValues)
                {
                    if (s == filter)
                    {
                        filtered.Add(statsToFilter[i]);
                    }
                }
            }

            return filtered;
        }

        private void B_ResetFilters_Click(object sender, EventArgs e)
        {
            ComboBox[] filters = { F_Username, F_Category, F_Continents, F_QCount };

            foreach (ComboBox f in filters)
            {
                f.SelectedIndex = -1;
            }

            string fullpath = Path.Combine(filepath, selectedGamemode);
            statsLines = File.ReadAllLines(fullpath).ToList();
            LoadAllStats(statsLines);

            ValuesChangedToFalse();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void F_Username_SelectedValueChanged(object sender, EventArgs e)
        {
            usernameValueChanged = true;
        }

        private void F_Category_SelectedValueChanged(object sender, EventArgs e)
        {
            categoryValueChanged = true;
        }

        private void F_Continents_SelectedValueChanged(object sender, EventArgs e)
        {
            continentsValueChanged = true;
        }

        private void F_QCount_SelectedValueChanged(object sender, EventArgs e)
        {
            qCountValueChanged = true;
        }

        private void ValuesChangedToFalse()
        {
            usernameValueChanged = false;
            categoryValueChanged = false;
            continentsValueChanged = false;
            qCountValueChanged = false;
        }
    }
}