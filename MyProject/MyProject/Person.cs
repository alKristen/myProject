
namespace test
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person ( string firstname, string lastname, Address address)  
        { 
            FirstName = firstname;
            LastName = lastname;
            Address = address;
        }

    }
      

}
