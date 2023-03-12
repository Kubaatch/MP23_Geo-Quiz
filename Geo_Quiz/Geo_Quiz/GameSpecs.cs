using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Quiz
{
    internal class GameSpecs
    {
        private int category;
        private string[] continents;
        private int questionCount;
        private string[] questions;        

        public GameSpecs() { }

        public int Category
        {
            get { return category; }
            set { category = value; }
        }

        public string[] Continents
        {
            get { return continents; }
            set { continents = value; }
        }

        public int QuestionCount
        {
            get { return questionCount; }
            set { questionCount = value; }
        }

        public string[] Questions
        {
            get { return questions; }
            set { questions = value; }        
        }
    }
}
