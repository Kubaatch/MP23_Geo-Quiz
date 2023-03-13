﻿using System;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_Statistics : UserControl
    {
        readonly GameSpecs gameInfo = new GameSpecs();

        public int finalScore;
        public int avgScore;
        public int gameScore;

        public double totalTime;
        public int seconds;
        public int minutes;

        public UC_Statistics(int score, double totaltime, GameSpecs gamespecs)
        {
            gameInfo = gamespecs;

            finalScore = score;
            totalTime = totaltime;

            InitializeComponent();

            L_Score.Text += finalScore + " pts.";

            ComputePerQuestionScore();
            L_AvgScore.Text += avgScore + " pts.";

            ComputeTimeSpent();            
            L_TimeSpent.Text += totalTime + " seconds and " + minutes + " minutes";
        }

        private void ComputePerQuestionScore()
        {
            avgScore = finalScore / gameInfo.QuestionCount;
        }

        private void ComputeTimeSpent()
        {
            totalTime /= 100;
            
            while (totalTime > 60)
            {
                minutes += 1;
                totalTime -= 60;
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
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
