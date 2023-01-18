using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivan","Ivanov");
            //person1.GetInfo();
            Person person2 = new Person("Volha", "Lipova");
            //person2.GetInfo();

            UniversityEmployee employee1 = new UniversityEmployee(person1, 10 );
            UniversityEmployee employee2 = new UniversityEmployee(person2, 11 );

            Course course1 = new Course("Психология", "Введение и основы психологии");
            Course course2 = new Course("Высшая математика", "Введение в высшую математику");
            //Course num3 = new Course("Экономика", "Основы экономики");

            Teacher course_num1 = new Teacher (person1, 10, course1);
            Teacher course_num2 = new Teacher (person2, 11, course2);


           



        }
    }
}