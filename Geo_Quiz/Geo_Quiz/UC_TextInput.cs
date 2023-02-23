using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Geo_Quiz
{
    public partial class UC_TextInput : UserControl
    {
        GameSpecs GS_Text = new GameSpecs();
        public string answer;
        public int qnumber = 0;

        public UC_TextInput(int gamemode, string[] continents, int QCount)
        {
            GS_Text.Gamemode = gamemode;
            GS_Text.Continents = continents;
            //string[] continents with Europe and such
            //remove unused continents here -> .Skip(x).Take(y);

            GS_Text.QCount = QCount;            
            GS_Text.Questions = GetQuestions();                        


            InitializeComponent();
        }

        private void TB_Answer_KeyUpEnter(object sender, KeyEventArgs f)
        {
            if ( f.KeyCode == Keys.Enter)
            {                
                answer = GS_Text.Questions[qnumber].Split('\t')[1];

                if (TB_Answer.Text == answer)
                {                    
                    L_Result.Text = "Correct!";
                    L_Result.Visible = true;
                }
                else
                {                   
                    L_Result.Text = "Wrong...";
                    L_Result.Visible = true;

                    L_CorrectResult.Text += answer;
                    L_CorrectResult.Visible = true;
                }

                qnumber++;
                B_Skip.Visible = false;
                B_Next.Visible = true;
                TB_Answer.Enabled = false;
            }
        }                     

        private void B_Skip_Click(object sender, EventArgs e)
        {
            L_Result.Text = "Wrong...";
            L_Result.Visible = true;

            L_CorrectResult.Text += answer;
            L_CorrectResult.Visible = true;
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            TB_Answer.Text = "Enter answer here";
            
            L_Result.Visible = false;

            L_CorrectResult.Visible = false;
            L_CorrectResult.Text = "Correct answer is: ";

            L_Country.Text = GS_Text.Questions[qnumber].Split('\t')[0];

            B_Skip.Visible = true;
            B_Next.Visible = false;
            TB_Answer.Enabled = true;
        }

        private string[] GetQuestions()
        {
            string[] file = File.ReadAllLines(@"C:\Users\kubik\source\repos\MP23_Geo-Quiz\Geo_Quiz\Questions.txt");
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

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            TB_Answer.Enabled = true;
            B_Skip.Enabled = true;
            
            L_Country.Text = GS_Text.Questions[0].Split('\t')[0];

            B_Start.Visible = false;
        }

        private void L_Question_Click(object sender, EventArgs e)
        {
            
        }

        private void L_CorrectResult_Click(object sender, EventArgs e)
        {

        }
    }
}
