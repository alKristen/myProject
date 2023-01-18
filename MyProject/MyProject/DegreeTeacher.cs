using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Task_3
{
    internal class DegreeTeacher : Teacher  
    {
        public string ScientificDegree { get; set; }
        public string Title_of_the_teacher { get; set; }

        public DegreeTeacher(Person personEmployee, int taxID, string scientificDegree, string title_of_the_teacher, Course course) : base (personEmployee, taxID, course)
        {
            ScientificDegree = scientificDegree;
            Title_of_the_teacher = title_of_the_teacher;
        }
    }
}
