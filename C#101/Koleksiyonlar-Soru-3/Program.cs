using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*              
            Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve 
            dizinin elemanlarını sıralayan programı yazınız. 
            */

            ArrayList sesli = new ArrayList();

            Console.WriteLine("Bir cümle giriniz: ");

            char[] girdi = (Console.ReadLine()).ToCharArray();

            foreach (char c in girdi)
            {
                if (c == 'a' || c == 'e' || c == 'ı' || c == 'i' || c == 'o' || c == 'ö' || c == 'u' || c == 'ü')
                {
                    sesli.Add(c);
                }
            }

            sesli.Sort();
            Console.WriteLine("Girilen cümledeki sesli harfler: ");
            foreach (char c in sesli)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();

        }
    }
}
