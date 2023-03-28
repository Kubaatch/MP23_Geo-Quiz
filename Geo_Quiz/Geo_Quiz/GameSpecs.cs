namespace Geo_Quiz
{
    public class GameSpecs
    {
        private int category;
        private string[] continents;
        private int questionCount;   

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
    }
}
