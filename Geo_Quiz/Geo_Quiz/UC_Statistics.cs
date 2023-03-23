using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_Statistics : UserControl
    {
        readonly private string filepath = UC_Login.filepath;
        
        private string selectedGamemode;
        readonly private string stats1file = "Stats4Variants.txt";
        readonly private string stats2file = "StatsTextInput.txt";

        readonly private string gameMode1 = "4 Options";
        readonly private string gameMode2 = "Written answer";

        private static string fUsername;
        private static string fCategory;
        private static string fContinents;
        private static string fQCount;

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

            LoadAllStats();
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

            LoadAllStats();
        }

        private void SetFilters()
        {
            F_Username.Items.AddRange(GetUsernames());

            F_Category.Items.AddRange(UC_GameUI.categories);

            F_Continents.Items.AddRange(UC_GameUI.continents);
            string[] multipleConts = new string[] { "2", "3", "4", "5", "6" };
            F_Continents.Items.AddRange(multipleConts);

            F_QCount.Items.AddRange(UC_GameUI.questionCounts);
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

        private void LoadAllStats()
        {
            StatsTable.Rows.Clear();

            string fullpath = Path.Combine(filepath, selectedGamemode);
            string[] statsLines = File.ReadAllLines(fullpath);

            List<string[]> temp = new List<string[]>();

            foreach (string s in statsLines)
            {
                temp.Add(s.Split('\t'));
            }

            foreach (string[] statsLine in temp)
            {
                StatsTable.Rows.Add(statsLine);
            }
        }

        private void FilterStats()
        {
            StatsTable.Rows.Clear();
            
            string fullpath = Path.Combine(filepath, selectedGamemode);
            string[] statsLines = File.ReadAllLines(fullpath);

            List<string> filteredStats = statsLines.ToList();

            if (usernameValueChanged == true)
            {
                for (int i = 0; i < filteredStats.Count; i++)
                {
                    if (filteredStats[i].Contains(fUsername) != true)
                    {
                        filteredStats.RemoveAt(i);
                    }
                }
            }

            if (categoryValueChanged == true)
            {
                for (int i = 0; i < filteredStats.Count; i++)
                {
                    if (filteredStats[i].Contains(fCategory) != true)
                    {
                        filteredStats.RemoveAt(i);
                    }
                }
            }

            if (continentsValueChanged == true)
            {
                for (int i = 0; i < filteredStats.Count; i++)
                {
                    if (filteredStats[i].Contains(fContinents) != true)
                    {
                        filteredStats.RemoveAt(i);
                    }
                }
            }

            if (qCountValueChanged == true)
            {
                for (int i = 0; i < filteredStats.Count; i++)
                {
                    if (filteredStats[i].Contains(fQCount) != true)
                    {
                        filteredStats.RemoveAt(i);
                    }
                }
            }

            ValuesChangedToFalse();
        }

        private void B_SaveFilters_Click(object sender, EventArgs e)
        {
            fUsername = F_Username.SelectedItem as string;
            fCategory = F_Category.SelectedItem as string;
            fContinents = F_Continents.SelectedItem as string;
            fQCount = F_QCount.SelectedItem as string;
            
            FilterStats();
        }

        private void B_ResetFilters_Click(object sender, EventArgs e)
        {
            ComboBox[] filters = { F_Username, F_Category, F_Continents, F_QCount };

            foreach (ComboBox f in filters)
            {
                f.SelectedIndex = -1;
            }

            LoadAllStats();

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