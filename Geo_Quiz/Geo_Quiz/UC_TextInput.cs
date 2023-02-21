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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Geo_Quiz
{
    public partial class UC_TextInput : UserControl
    {
        GameSpecs GS_Text = new GameSpecs();
        public string answer;

        public UC_TextInput(string gamemode, string[] continents, int QCount)
        {
            GS_Text.Gamemode = gamemode;
            GS_Text.Continents = continents;
            GS_Text.QCount = QCount;

            //remove unused continents here -> .Skip(x).Take(y);
            GS_Text.Questions = GetQuestions();

            //editing before I declare it - solve!
            //L_Country.Text = GS_Text.Questions[0];

            InitializeComponent();
        }

        private void TB_Answer_Entered(object sender, EventArgs e)
        {
            TB_Answer.Enabled = true;
            
            int i = 0;
            answer = GS_Text.Questions[i].Split('\t')[1];
            if (TB_Answer.Text == answer)
            {
                B_Skip.Text = "Next";
                //edit what button does
                
                L_Result.Text = "Correct";
                L_Result.Visible = true;

                TB_Answer.Enabled = false;
            }


            i++;
        }                

        private void B_Skip_Click(object sender, EventArgs e)
        {

        }

        private string[] GetQuestions()
        {
            string[] file = File.ReadAllLines(@"C:\Users\kubik\source\repos\MP23_Geo-Quiz\Geo_Quiz\Capitals.txt");
            //simplify to work on any computer!    

            string[] questions = new string[GS_Text.QCount];
            Random rand = new Random();

            int i = 0;
            while (i < GS_Text.QCount)
            {
                //CAN REPEAT QUESTIONS!
                questions[i] = file[rand.Next(1,196)];
                i++;
            }

            return questions;
        }

        private void TB_Answer_GotFocus(object sender, EventArgs e)
        {
            TB_Answer.Text = string.Empty;
        }

        private void TB_Answer_LostFocus(object sender, EventArgs e)
        {
            TB_Answer.Text = "Enter answer here";
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
