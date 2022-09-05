using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(topla(12,23)); // Ref out referans tiplerini tanımlamak
            Console.ReadKey();
        }
        static int topla(int a,int b) 
        {
            b = 20;
            a = 25;
            return a + b;
           
        }

    }
}
