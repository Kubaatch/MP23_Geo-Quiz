using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Quiz
{
    internal class GameSpecs
    {
        public string Gamemode;
        public string[] Continents;
        public int QCount;
        
        public GameSpecs(string ChosenGameMode, string[] ChosenContinents, int ChosenQCount)
        {
            Gamemode = ChosenGameMode;
            Continents = ChosenContinents;
            QCount = ChosenQCount;
        }
    }
}
