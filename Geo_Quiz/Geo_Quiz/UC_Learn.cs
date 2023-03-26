using Image = System.Drawing.Image;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Geo_Quiz
{
    public partial class UC_Learn : UserControl
    {
        readonly string filepath = UC_Login.filepath;
        readonly string[] continents = UC_GameUI.continents;

        private string[] countries;
        private string[] capitals;
        private string[] population;
        private string[] area;
        readonly List<Image> flags = new List<Image>();

        public UC_Learn()
        {
            InitializeComponent();

            LoadDatabase();
            LoadFlags();

            SetListsInTextBoxes();
        }

        private void SetListsInTextBoxes()
        {
            var acscCountries = new AutoCompleteStringCollection();
            acscCountries.AddRange(countries);
            TB_Country.AutoCompleteCustomSource = acscCountries;

            var acscCapitals = new AutoCompleteStringCollection();
            acscCapitals.AddRange(capitals);
            TB_Capital.AutoCompleteCustomSource = acscCapitals;
        }

        private void LoadDatabase()
        {
            List<string> tempQuestionsList = new List<string>();

            string path = Path.Combine(filepath, "Questions.txt");
            string[] qArr = File.ReadAllLines(path);

            for (int i = 0; i < continents.Length; i++)
            {
                int startIndex = Array.IndexOf(qArr, continents[i]) + 1;
                for (int j = startIndex; j < qArr.Length; j++)
                {
                    if (string.IsNullOrWhiteSpace(qArr[j]))
                    { break; }

                    tempQuestionsList.Add(qArr[j]);
                }
            }

            string[] allData = tempQuestionsList.ToArray();
            string[] onelineValues;

            Array.Resize(ref countries, allData.Length);
            Array.Resize(ref capitals, allData.Length);
            Array.Resize(ref area, allData.Length);
            Array.Resize(ref population, allData.Length);

            int k = 0;
            foreach (string data in allData)
            {
                onelineValues = data.Split('\t');

                foreach (string s in onelineValues)
                {
                    Console.WriteLine(s);
                }
                
                countries[k] = onelineValues[0];
                capitals[k] = onelineValues[1];
                population[k] = onelineValues[2];
                area[k] = onelineValues[3];
                
                k++;
            }
        }

        private void LoadFlags()
        {
            string path = Path.Combine(filepath, "");
            
            for (int i = 0; i < continents.Length; i++)
            {
                string continentPath = Path.Combine(path, continents[i]);
                string[] files = Directory.GetFiles(continentPath, "*.png");

                for (int j = 0; j < files.Length; j++)
                {
                    Image image = Image.FromFile(files[j]);
                    image.Tag = Path.GetFileName(files[j]);
                    flags.Add(image);
                }
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
