﻿using System;


namespace Task_3
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //public string GetInfo()
        //{
        //    return FirstName + LastName;
        //}
    }
}
