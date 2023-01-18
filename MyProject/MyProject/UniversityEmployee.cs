using System;


namespace Task_3
{
    internal class UniversityEmployee
    {
        public Person PersonEmployee { get; set; }
        public int TaxID { get; set; }

        public UniversityEmployee(Person personEmployee, int taxID)
        {
            PersonEmployee = personEmployee;
            TaxID = taxID;
        }

        public virtual void GetOfficialDuties()
        { 
            Console.WriteLine()
        }

    }
}
