using System;
using System.Collections;
using System.Collections.Generic;
namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            System.Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //AddRange
            System.Console.WriteLine("************ Add Range *************");
            string[] renkler = {"Kırmızı","Sarı","Yeşil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
            //Sort
            System.Console.WriteLine("**** Sort *****");
            liste.Sort();

            //Binary Search
            System.Console.WriteLine("******* Binary Search ********");
            System.Console.WriteLine(liste.BinarySearch(9));
            
            //Reverse
            System.Console.WriteLine("******* Reverse ********");
            liste.Reverse();
            foreach (var item in liste)
                System.Console.WriteLine(item);
            
            //Clear
            System.Console.WriteLine("******* Clear ********");
            liste.Clear();
            foreach (var item in liste)
                System.Console.WriteLine(item);

        }
    }
}
