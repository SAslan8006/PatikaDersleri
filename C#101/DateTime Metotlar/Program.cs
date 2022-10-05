using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------DateTime-------------

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(3));  //3 gün ekler
            Console.WriteLine(DateTime.Now.AddHours(9));
            Console.WriteLine(DateTime.Now.AddMinutes(87));
            Console.WriteLine(DateTime.Now.AddYears(3));

            ///--DateTime Format  -- ToString ile formatlama yapılır

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //-------Math Kütüphanesi----------

            Console.WriteLine(Math.Abs(-25));  ///mutlak değer
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(25));
            Console.WriteLine(Math.Tan(35));

            Console.WriteLine(Math.Ceiling(22.3)); //double üzerinde çalışır  yukarı yuvarlar = 23
            Console.WriteLine(Math.Round(22.3));  // 22
            Console.WriteLine(Math.Round(22.7));  //23
            Console.WriteLine(Math.Floor(22.3)); // aşağı yuvarlar  =22

            Console.WriteLine(Math.Max(8, 9));
            Console.WriteLine(Math.Min(1, 8));

            Console.WriteLine(Math.Pow(3, 4));  //3 üssü 4 
            Console.WriteLine(Math.Sqrt(9));  //9 un karekökü
            Console.WriteLine(Math.Log(5));  //log e tabanında 5
            Console.WriteLine(Math.Log10(8)); //log10 tabanında 8
            Console.WriteLine(Math.Exp(8)); // e üstü 8
            Console.ReadKey();
        }
    }
}
