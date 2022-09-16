using System;

namespace HazirMetotlarDatetimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);


            System.Console.WriteLine(DateTime.Now.DayOfWeek);
            System.Console.WriteLine(DateTime.Now.DayOfYear);

            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            System.Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Console.WriteLine(DateTime.Now.ToLongTimeString());
            System.Console.WriteLine(DateTime.Now.ToShortTimeString());

            System.Console.WriteLine(DateTime.Now.AddDays(2));
            System.Console.WriteLine(DateTime.Now.AddHours(3));
            System.Console.WriteLine(DateTime.Now.AddSeconds(30));
            System.Console.WriteLine(DateTime.Now.AddMonths(5));
            System.Console.WriteLine(DateTime.Now.AddYears(10));
            System.Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            //Datetime Format 
            System.Console.WriteLine(DateTime.Now.ToString("dd"));//24
            System.Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday

            System.Console.WriteLine(DateTime.Now.ToString("MM"));//04
            System.Console.WriteLine(DateTime.Now.ToString("MMM"));//April
            System.Console.WriteLine(DateTime.Now.ToString("MMMM"));//April

            System.Console.WriteLine(DateTime.Now.ToString("YY"));//22
            System.Console.WriteLine(DateTime.Now.ToString("YYYY"));//2022


            //Math Kütüphanesi
            System.Console.WriteLine("********* Math Kütüphanesi ********");

            System.Console.WriteLine(Math.Abs(-25));
            System.Console.WriteLine(Math.Sin(10));
            System.Console.WriteLine(Math.Cos(10));
            System.Console.WriteLine(Math.Tan(10));
            
            System.Console.WriteLine(Math.Ceiling(22.3));
            System.Console.WriteLine(Math.Round(22.3));
            System.Console.WriteLine(Math.Round(22.7));
            System.Console.WriteLine(Math.Floor(22.7));

            System.Console.WriteLine(Math.Max(2,6));
            System.Console.WriteLine(Math.Min(2,6));

            System.Console.WriteLine(Math.Pow(3,4));
            System.Console.WriteLine(Math.Sqrt(9));
            System.Console.WriteLine(Math.Log(9));// 9 un e tabanındaki logaritmik karşılığı
            System.Console.WriteLine(Math.Exp(3));// e üzeri 3 verir
            System.Console.WriteLine(Math.Log10(10));// Log 10 tabanında karılığı
            


        }
    }
}
