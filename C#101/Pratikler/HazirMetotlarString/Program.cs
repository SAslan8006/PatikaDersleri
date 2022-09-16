using System;

namespace HazirMetotlarString
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";

            //Length
            System.Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            System.Console.WriteLine(degisken.ToUpper());
            System.Console.WriteLine(degisken.ToLower());

            //Concat
            System.Console.WriteLine(String.Concat(degisken," Merhaba!"));

            //Compare , CompareTo
            System.Console.WriteLine(degisken.CompareTo(degisken2));//0 1 -1
            System.Console.WriteLine(String.Compare(degisken,degisken2,true));
            System.Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains
            System.Console.WriteLine(degisken.Contains(degisken2));
            System.Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            System.Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            System.Console.WriteLine(degisken.IndexOf("CS"));
            System.Console.WriteLine(degisken.IndexOf("MUSA"));
            System.Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            System.Console.WriteLine(degisken.Insert(0,"Merhaba! "));
           
            //PadLeft PadRight
            System.Console.WriteLine(degisken + degisken2.PadLeft(30));
            System.Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            System.Console.WriteLine(degisken.PadRight(50) + degisken2);
            System.Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove 
            System.Console.WriteLine(degisken.Remove(10));
            System.Console.WriteLine(degisken.Remove(5,3));
            System.Console.WriteLine(degisken.Remove(0,1));

            //Replace
            System.Console.WriteLine(degisken.Replace("CSharp","C#"));
            System.Console.WriteLine(degisken.Replace(" ","*"));

            //Split!!!
            System.Console.WriteLine(degisken.Split(" ")[1]);

            //Substring!!!
            System.Console.WriteLine(degisken.Substring(4));
            System.Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
