

namespace test
{
    internal class SubjectScore
    {
        private int _score;
        private const int Max_Score_Number = 10;
        private const int Min_Score_Number = 0;

        public string Subject { get; set; }
        public int Score 
        { 
            get
            {
                return _score;
            }
            set
            {
                if (value >= Min_Score_Number && value <= Max_Score_Number)
                { 
                    _score = value;
                }
            }
        } 

        public SubjectScore (string subject, int score)
        {
            Subject = subject;
            Score = score;
        }
    }
}
