using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee suleyman = new Employee() { Name = "Süleyman ASLAN" };
            Employee mahmut = new Employee() { Name = "Mamut ASLAN" };
            Employee Pamuk = new Employee() { Name = "Pamuk ASLAN" };
            suleyman.AddSubordinate(Pamuk);
            suleyman.AddSubordinate(mahmut);
            Contractor ali = new Contractor { Name = "Ali" };
            Pamuk.AddSubordinate(ali);

            Employee ahmet = new Employee() { Name = "Ahmet ASLAN" };
            mahmut.AddSubordinate(ahmet);

            Console.WriteLine(suleyman.Name);
            foreach (Employee manager in suleyman)
            {
                Console.WriteLine($"  {manager.Name}");
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine($"    {employee.Name}");
                }
            }
            Console.ReadLine();
        }
    }
    interface IPerson
    {
        string Name  { get; set; }
    }
    class Contractor : IPerson
    {
        public string Name { get; set ; }
    }
    class Employee : IPerson,IEnumerable<IPerson>
    {
        List<IPerson> _subordinates=new List<IPerson>();

        public void AddSubordinate(IPerson person)
        { 
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubortinate(int index) 
        { 
            return _subordinates[index];
        }

        public string Name { get; set; }

        public IEnumerator <IPerson> GetEnumerator()
        {
            foreach (var item in _subordinates)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
