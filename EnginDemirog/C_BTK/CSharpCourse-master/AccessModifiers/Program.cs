using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
     class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        private int Id { get; set; }// sadece clasında  (private - protected - internal)
        protected int Id1 { get; set; } //İnherated edile sınıflarda kullanılı birde classında
        public void Save()
        { 
        
        }
        public void Delete() 
        { 
        
        }
    }
    class student :Customer
    {
        public void Save2()
        { 
            Customer customer = new Customer();
            
        }
    }
    public class Course 
    {
        public string Name { get; set; }
        private class NestedClass 
        { 
        
        }
    }
}
