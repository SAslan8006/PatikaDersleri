using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time< 11)
            {
                System.Console.WriteLine("Günaydın!");
            }
            else if (time <= 18)
            {
                System.Console.WriteLine("İyi Günler!");
            }
            else
            {
                System.Console.WriteLine("İyi geceler!");
            }

            string sonuc  =time <= 18 ? "İyi Günler" : "İyi Geceler";

            sonuc = time>=6 && time<11 ?"Günaydın" : time<=18 ? "İyi Günler" : "İyi Geceler";
            System.Console.WriteLine(sonuc);
        }
    }
}
