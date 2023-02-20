using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Geo_Quiz
{
    public partial class UC_TextInput : UserControl
    {
        
        public UC_TextInput(string Gamemode, string[] Continents, int QCount)
        {
            //GameSpecs gamespecs = new GameSpecs(Gamemode, Continents, QCount);
            //do something with this lol

            string[] countries = GetCountries();

            Random rand = new Random();
            int Qnumber = rand.Next(1, 196);

            Label L_Country = new Label();
                L_Country.Text = countries[Qnumber];
                L_Country.Location = new Point(354, 287);
                L_Country.AutoSize = true;
                L_Country.Font = new Font("Microsoft YaHei UI", 12);
                L_Country.BackColor = SystemColors.ControlLightLight;
                this.Controls.Add(L_Country);
            
            InitializeComponent();
        }

        private void TB_Answer_TextChanged(object sender, EventArgs e)
        {
            string[] capitals = GetCapitals();
            int i = 0;

            if (TB_Answer.Text == capitals[i])
            {
                TB_Answer.Text = "That is correct!";
            }
        }

        private string[][] LoadFile()
        {
            string[] file = File.ReadAllLines(@"C:\Users\kubik\source\repos\MP23_Geo-Quiz\Geo_Quiz\Capitals.txt");
            string separator = "\t";
            string[] substrings;
            string[] countries = new string[file.Length];
            string[] capitals = new string[file.Length];

            for (int i = 0; i < file.Length; i++)
            {
                substrings = file[i].Split(separator.ToCharArray());

                countries[i] = substrings[0];
                capitals[i] = substrings[1];
            }

            return new string[][] { countries, capitals };
        }

        private string[] GetCountries()
        {
            string[][] result = LoadFile();
            string[] countries = result[0];

            return countries;
        }
        private string[] GetCapitals()
        {
            string[][] result = LoadFile();
            string[] capitals = result[1];

            return capitals;
        }

        private void L_Question_Click(object sender, EventArgs e)
        {
            
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
