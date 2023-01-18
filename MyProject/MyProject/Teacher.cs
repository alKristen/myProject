using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_3
{
    internal class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }

        public Teacher (UniversityEmployee universityEmployee, Course course) : base (universityEmployee)
        {
            Course = Course;
        }
    }
}
