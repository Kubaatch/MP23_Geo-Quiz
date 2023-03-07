using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Quiz
{
    internal class GameSpecs
    {
        private int gamemode;
        private string[] continents;
        private int qCount;
        private string[] questions;        

        public GameSpecs() { }

        public int Gamemode
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
