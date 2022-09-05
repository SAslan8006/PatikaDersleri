using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Customer
    {
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        // field 
        //Property
        //private string _firstName;
        //public string FirstName
        //{ 
        //    get { return "Mr." + _firstName; } 
        //    set { _firstName = value; } 
        //}

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string City{ get; set; }
        public override string ToString()
        {
            return $"{Id,-3} {FirstName,-10} {LastName,-10} {City,-10}";
        }
    }
}
