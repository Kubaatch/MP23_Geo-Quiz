using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Quiz
{
    internal class GameSpecs
    {
        private string gamemode;
        private string[] continents;
        private int qCount;
        private string[] questions;
        
        public GameSpecs(string ChosenGameMode, string[] ChosenContinents, int ChosenQCount, string[] RandQuestions)
        {
            Gamemode = ChosenGameMode;
            Continents = ChosenContinents;
            QCount = ChosenQCount;
            Questions = RandQuestions;
        }

        public GameSpecs() { }

        public string Gamemode
        {
            get { return gamemode; }
            set { gamemode = value; }
        }

        public string[] Continents
        {
            get { return continents; }
            set { continents = value; }
        }

        public int QCount
        {
            get { return qCount; }
            set { qCount = value; }
        }

        public string[] Questions
        {
            get { return questions; }
            set { questions = value; }
        }

    }
}
