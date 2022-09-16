using System;
namespace ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " +name +" "+surname );
        }
    }
}
