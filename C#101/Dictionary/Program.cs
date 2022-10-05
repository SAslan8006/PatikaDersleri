using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using System.Collections.Generic

            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10, "Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Süleyman ASLAN");
            kullanıcılar.Add(20, "Hatice Nur");

            //Dizinin elemanlarına erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)            
                Console.WriteLine($"{item.Key} {item.Value}"); // Console.WriteLine(item);
            
            //Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            Console.WriteLine("***** Remove *****");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine($"{item.Key} {item.Value}"); // Console.WriteLine(item);

            //Keys
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);

            //Values
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item); 


            Console.ReadKey();
        }
    }
}
