namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectScore subjectScore1 = new SubjectScore ("Math", 10);
            SubjectScore subjectScore2 = new SubjectScore("Literature", 9);
            SubjectScore[] scoreArray1 = new SubjectScore[] {subjectScore1, subjectScore2};
            Address address1 = new Address("Minsk", "Plehanova", 25, 4);
            Person person1 = new Person ("Ivan", "Ivanovich", address1);
            Candidate candidate1 = new Candidate (person1, scoreArray1);

            SubjectScore subjectScore3 = new SubjectScore("Math", 9);
            SubjectScore subjectScore4 = new SubjectScore("Literature", 7);
            SubjectScore[] scoreArray2 = new SubjectScore[] { subjectScore3, subjectScore4};
            Address address2 = new Address("Minsk", "Pushkina", 24, 1);
            Person person2 = new Person("Maksim", "Petrovich", address2);
            Candidate candidate2 = new Candidate(person2, scoreArray2);

            SubjectScore subjectScore5 = new SubjectScore("Math", 8);
            SubjectScore subjectScore6 = new SubjectScore("Literature", 7);
            SubjectScore[] scoreArray3 = new SubjectScore[] { subjectScore5, subjectScore6 };
            Address address3 = new Address("Minsk", "Yakybova", 30, 4);
            Person person3 = new Person("Ivan", "Ivanovich", address3);
            Candidate candidate3 = new Candidate(person3, scoreArray3);

            SubjectScore subjectScore7 = new SubjectScore("Math", 7);
            SubjectScore subjectScore8 = new SubjectScore("Literature", 10);
            SubjectScore[] scoreArray4 = new SubjectScore[] { subjectScore5, subjectScore6 };
            Address address4 = new Address("Minsk", "Filatova", 121, 4);
            Person person4 = new Person("Igor", "Zaharovich", address4);
            Candidate candidate4 = new Candidate(person4, scoreArray4);

            SubjectScore subjectScore9 = new SubjectScore("Math", 7);
            SubjectScore subjectScore10 = new SubjectScore("Literature", 10);
            SubjectScore[] scoreArray5 = new SubjectScore[] { subjectScore9, subjectScore10 };
            Address address5 = new Address("Minsk", "Karskogo", 17, 5);
            Person person5 = new Person("Petya", "Yrevich", address5);
            Candidate candidate5 = new Candidate(person5, scoreArray5);



            string[] streets = { candidate1.Person.Address.Street, candidate2.Person.Address.Street, candidate3.Person.Address.Street, candidate4.Person.Address.Street, candidate5.Person.Address.Street };
            Console.WriteLine($"Список всех улиц: {String.Join(",",streets)}");


            int[] scores = { candidate1.SubjectScores[0].Score, candidate2.SubjectScores[0].Score, candidate3.SubjectScores[0].Score, candidate4.SubjectScores[0].Score, candidate5.SubjectScores[0].Score };
            int maxValue = scores.Max();
            Console.WriteLine($"Максимальна оценка по математике:{ maxValue}");                 
        }
    }
}