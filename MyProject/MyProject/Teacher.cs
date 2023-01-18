using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_3
{
    internal class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }


        public Teacher(Person personEmployee, int taxID, Course course) : base(personEmployee, taxID)
        { 
            Course = course;
        }
        
    }
}
