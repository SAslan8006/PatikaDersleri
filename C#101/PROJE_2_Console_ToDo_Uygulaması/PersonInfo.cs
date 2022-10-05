using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    public class PersonInfo
    {
        public static List<Person> person = new List<Person>();

        public PersonInfo()
        {
            person.Add(new Person(1, "Mahmut Kırac"));
            person.Add(new Person(2, "Tarkan Kare"));
            person.Add(new Person(3, "Yavuz Degısken"));
            person.Add(new Person(4, "Yavuz Yogurt"));
        }
    }
}
