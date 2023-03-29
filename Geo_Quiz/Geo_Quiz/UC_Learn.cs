using Image = System.Drawing.Image;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Text;
using System.Globalization;

namespace Geo_Quiz
{
    public partial class UC_Learn : UserControl
    {
        private readonly string filepath = UC_Login.filepath;
        private readonly string[] continents = UC_GameUI.continents;

        private string[] countries;
        private string[] capitals;
        private string[] population;
        private string[] area;
        private readonly List<Image> flags = new List<Image>();

        const string labelAreaText = "Area: ";
        const string areaUnit = " km²";
        const string labelPopulationText = "Population: ";

        private int countryIndex = 0;

        public UC_Learn()
        {
            InitializeComponent();

            LoadDatabase();
            LoadFlags();

            SetListsInTextBoxes();
        }

        private void TB_Capital_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < capitals.Length; i++)
                {
                    if (TB_Capital.Text.ToLower() == capitals[i].ToLower())
                    {
                        countryIndex = i;
                        break;
                    }
                }

                SetCountryText();
                SetFlagImage();
                SetAreaAndPopulation();
            }
        }

        private void TB_Country_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < countries.Length; i++)
                {
                    if (TB_Country.Text.ToLower() == countries[i].ToLower())
                    {
                        countryIndex = i;
                        break;
                    }
                }

                SetCapitalCityText();
                SetFlagImage();
                SetAreaAndPopulation();
            }
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            countryIndex++;

            if (countryIndex >= countries.Length)
            {
                countryIndex = 0;
            }
                
            SetCountryText();
            SetCapitalCityText();
            SetFlagImage();
            SetAreaAndPopulation();
        }

        private void B_Previous_Click(object sender, EventArgs e)
        {
            countryIndex--;

            if (countryIndex < 0)
            {
                countryIndex = countries.Length - 1;
            }
                
            SetCountryText();
            SetCapitalCityText();
            SetFlagImage();
            SetAreaAndPopulation();
        }

        private void SetFlagImage()
        {
            string flagname;
            string selCountry = countries[countryIndex].ToLower();

            foreach (Image img in flags)
            {
                flagname = img.Tag.ToString().ToLower();
                flagname = flagname.Split('.')[0];

                if (flagname == selCountry)
                {
                    PB_Image.Image = img;
                    break;
                }
            }
        }

        private void SetCapitalCityText()
        {
            TB_Capital.Text = capitals[countryIndex];
        }

        private void SetCountryText()
        {
            TB_Country.Text = countries[countryIndex];
        }

        private void SetAreaAndPopulation()
        {
            L_Area.Text = labelAreaText + area[countryIndex] + areaUnit;
            L_Population.Text = labelPopulationText + population[countryIndex];
        }

        private void LoadDatabase()
        {
            List<string> tempQuestionsList = new List<string>();

            string path = Path.Combine(filepath, "Questions.txt");
            string[] qArr;

            while (true)
            {
                try
                {
                    qArr = File.ReadAllLines(path);
                    break;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e.Message}\nPlease resolve the problem to continue.");
                }
            }

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

            countries = new string[allData.Length];
            capitals = new string[allData.Length];
            area = new string[allData.Length];
            population = new string[allData.Length];

            allData = OrderDatabaseAlphabetically(allData);

            int k = 0;
            foreach (string data in allData)
            {
                onelineValues = data.Split('\t');

                countries[k] = onelineValues[0];
                capitals[k] = onelineValues[1];
                population[k] = SplitThousands(onelineValues[2]);
                area[k] = SplitThousands(onelineValues[3]);
                
                k++;
            }
        }

        private string[] OrderDatabaseAlphabetically(string[] unsortedData)
        {
            int length = unsortedData.Length;
            string temp;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (unsortedData[j].CompareTo(unsortedData[i]) > 0)
                    {
                        temp = unsortedData[i];
                        unsortedData[i] = unsortedData[j];
                        unsortedData[j] = temp;
                    }
                }
            }

            return unsortedData;
        }

        private void LoadFlags()
        {
            string path = Path.Combine(filepath, "");
            string[] files;
            
            for (int i = 0; i < continents.Length; i++)
            {
                string continentPath = Path.Combine(path, continents[i]);

                while (true)
                {
                    try
                    {
                        files = Directory.GetFiles(continentPath, "*.png");
                        break;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"{e.Message}\nPlease resolve the problem to continue.");
                    }
                }

                for (int j = 0; j < files.Length; j++)
                {
                    Image image = Image.FromFile(files[j]);
                    image.Tag = Path.GetFileName(files[j]);
                    flags.Add(image);
                }
            }
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

        public static string SplitThousands(string input)
        {
            bool success = int.TryParse(input, out int result);
            string formatted;

            if (success == true)
            { 
                    //copied from https://stackoverflow.com/a/17527989
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                formatted = result.ToString("#,0", nfi);
                    //end
            }
            else
            {
                formatted = input;
            }

            return formatted;
        }

        private void TB_Country_LostFocus(object sender, EventArgs e)
        {
            TB_Country.Text = countries[countryIndex];
        }

        private void TB_Capital_LostFocus(object sender, EventArgs e)
        {
            TB_Capital.Text = capitals[countryIndex];
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
