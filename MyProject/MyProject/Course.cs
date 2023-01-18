using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }

        public Course( string courseName, string courseDescription) 
        {
            CourseName = courseName;
            CourseDescription = courseDescription;
        }
    }
}
