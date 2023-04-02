using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_Statistics : UserControl
    {
        private readonly string filepath = F_SignIn.filepath;
        private readonly List<string> stats4Variants;
        private readonly List<string> statsTextInput;

        public static Control[] controls;

        private string selectedGamemode;
        private const string file4Variants = "Stats4Variants.txt";
        private const string fileTextInput = "StatsTextInput.txt";
        private const string gMode4Variants = "4 Options";
        private const string gModeTextInput = "Written answer";

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
            controls = new Control[] { B_Exit, B_GameMode, B_ResetFilters, B_SaveFilters, F_Category, F_Continents, F_QCount, F_Username };

            SetFilters();

            string fullpath1 = Path.Combine(filepath, file4Variants);
            string fullpath2 = Path.Combine(filepath, fileTextInput);
            
            while (true)
            {
                try
                {
                    stats4Variants = File.ReadAllLines(fullpath1).ToList();
                    statsTextInput = File.ReadAllLines(fullpath2).ToList();
                    break;
                }
                catch (Exception e)
                {
                    DialogResult result = MessageBox.Show($"{e.Message}\nPlease resolve the problem to continue." +
                        $"Click on retry to try again, cancelling fully closes the app.", "¯\\_(ツ)_/¯", MessageBoxButtons.RetryCancel);

                    if (result == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
            }

            LoadAllStats(stats4Variants);

            B_GameMode.Text = gMode4Variants;
            selectedGamemode = file4Variants;
        }

        private void B_GameMode_Click(object sender, EventArgs e)
        {
            if (B_GameMode.Text == gMode4Variants)
            {
                selectedGamemode = fileTextInput;
                B_GameMode.Text = gModeTextInput;
                LoadAllStats(statsTextInput);
            }
            else
            {
                selectedGamemode = file4Variants;
                B_GameMode.Text = gMode4Variants;
                LoadAllStats(stats4Variants);
            }

            RemoveFilterIndexes();
            ValuesChangedToFalse();
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

        private string[] GetUsernames()
        {
            string[] accounts;

            string fullpath = Path.Combine(filepath, "Accounts.txt");
            while (true)
            {
                try
                {
                    accounts = File.ReadAllLines(fullpath);
                    break;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File 'Accounts.txt' was not found.\nPlease add it to the folder 'Data' or redownload the app.");
                }
            }

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

            List<string> filteredStats;

            string fullpath = Path.Combine(filepath, selectedGamemode);
            while (true)
            {
                try
                {
                    filteredStats = File.ReadAllLines(fullpath).ToList();
                    break;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show($"File {selectedGamemode} was not found.\nPlease add it to the folder 'Data' or redownload the app.");
                }
            }

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
            RemoveFilterIndexes();

            if (B_GameMode.Text == gMode4Variants)
            {
                LoadAllStats(stats4Variants);
            }
            else
            {
                LoadAllStats(statsTextInput);
            }

            ValuesChangedToFalse();
        }

        private void RemoveFilterIndexes()
        {
            ComboBox[] filters = { F_Username, F_Category, F_Continents, F_QCount };

            foreach (ComboBox f in filters)
            {
                f.SelectedIndex = -1;
            }
        }

        private void ValuesChangedToFalse()
        {
            usernameValueChanged = false;
            categoryValueChanged = false;
            continentsValueChanged = false;
            qCountValueChanged = false;
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

        public void DisableButtons()
        {
            foreach (Control c in controls)
            {
                c.Enabled = false;
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            UC_MainMenu parent = Parent as UC_MainMenu;
            parent.EnableButtons();

            Dispose();
        }
    }
}