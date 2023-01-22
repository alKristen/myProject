namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectScore subjectScore1 = new ("Math", 10);
            SubjectScore subjectScore2 = new ("Literature", 9);
            SubjectScore[] scoreArray1 = new [] {subjectScore1, subjectScore2};
            Address address1 = new ("Minsk", "Plehanova", 25, 4);
            Person person1 = new ("Ivan", "Ivanovich", address1);
            Candidate candidate1 = new (person1, scoreArray1);

            SubjectScore subjectScore3 = new ("Math", 9);
            SubjectScore subjectScore4 = new ("Literature", 7);
            SubjectScore[] scoreArray2 = new [] { subjectScore3, subjectScore4};
            Address address2 = new ("Minsk", "Pushkina", 24, 1);
            Person person2 = new ("Maksim", "Petrovich", address2);
            Candidate candidate2 = new (person2, scoreArray2);

            SubjectScore subjectScore5 = new ("Math", 8);
            SubjectScore subjectScore6 = new ("Literature", 7);
            SubjectScore[] scoreArray3 = new [] { subjectScore5, subjectScore6 };
            Address address3 = new ("Minsk", "Yakybova", 30, 4);
            Person person3 = new ("Ivan", "Ivanovich", address3);
            Candidate candidate3 = new (person3, scoreArray3);

            SubjectScore subjectScore7 = new ("Math", 7);
            SubjectScore subjectScore8 = new ("Literature", 10);
            SubjectScore[] scoreArray4 = new [] { subjectScore7, subjectScore8 };
            Address address4 = new ("Minsk", "Filatova", 121, 4);
            Person person4 = new ("Igor", "Zaharovich", address4);
            Candidate candidate4 = new (person4, scoreArray4);

            SubjectScore subjectScore9 = new ("Math", 7);
            SubjectScore subjectScore10 = new ("Literature", 10);
            SubjectScore[] scoreArray5 = new [] { subjectScore9, subjectScore10 };
            Address address5 = new ("Minsk", "Karskogo", 17, 5);
            Person person5 = new ("Petya", "Yrevich", address5);
            Candidate candidate5 = new (person5, scoreArray5);


            var candidates = new Candidate[]
            {
                candidate1,
                candidate2,
                candidate3,
                candidate4,
                candidate5
            };

            foreach (var candidate in candidates)
            { 
                Console.WriteLine(candidate.Person.Address.Street);
            }

            int maxValue = 0;

            foreach (var candidate in candidates)
            {
                foreach (var score in candidate.SubjectScores)
                { 
                    if (score.Subject == "Math")
                    {
                        if (score.Score > maxValue)
                        {
                            maxValue = score.Score;
                        }
                    }
                }
            }

            Console.WriteLine($"Максимальна оценка по математике:{ maxValue}");                 
        }
    }
}