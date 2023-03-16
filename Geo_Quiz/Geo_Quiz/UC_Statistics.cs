﻿using System;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_Statistics : UserControl
    {
        readonly GameSpecs gameInfo = new GameSpecs();

        readonly TimeSpan totalTime = new TimeSpan();

        public int finalScore;
        public int avgScore;
        public int gameScore;

        public UC_Statistics(int score, TimeSpan ts, GameSpecs gamespecs)
        {
            gameInfo = gamespecs;
            totalTime = ts;
            finalScore = score;

            InitializeComponent();

            L_Score.Text += finalScore + " pts.";

            ComputePerQuestionScore();
            
            L_TimeSpent.Text += totalTime.Minutes + "mins, " + totalTime.Seconds + "s, " + totalTime.Milliseconds + "ms.";
        }

        private void ComputePerQuestionScore()
        {
            avgScore = finalScore / gameInfo.QuestionCount;

            L_AvgScore.Text += avgScore + " pts.";
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