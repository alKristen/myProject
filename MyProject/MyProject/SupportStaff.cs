using System;

namespace Task_3
{
    internal class SupportStaff : UniversityEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public SupportStaff(Person personEmployee, int taxID, string name, string position) : base(personEmployee, taxID)
        { 
            Name = name; 
            Position = position; 
        }
    }
}
