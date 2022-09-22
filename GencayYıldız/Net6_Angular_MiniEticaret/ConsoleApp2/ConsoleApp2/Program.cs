using System;
using System.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(15);
            FizzBuzz2(15);
        }

        private static void FizzBuzz(int i)
        {
            Console.WriteLine(String.Join(" ",Enumerable.Range(1, i)
                .Select(i => i % 15 == 0 ? "FizzBuzz"
                               : i % 3 == 0 ? "Fizz"
                               : i % 5 == 0 ? "Buzz"
                               : i.ToString())
                ));           
        }

        private static void FizzBuzz2(int i) {
            for (int n = 1; n <= i; n++)
            {
                if (n % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }

        }


    }
}
