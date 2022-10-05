using System;



public class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        string degisken = "Dersimiz CSharp, Hoşgeldiniz";
        string degisken2 = "dersimiz CSharp, Hoşgeldiniz";

        //length; //bu cümle icerisindeki karakter sayisini ögreniyoruz.
        Console.WriteLine(degisken.Length);

        //ToLower; ToUpper;// karakterleri ya büyük ya kücük harfe cevirir
        Console.WriteLine(degisken.ToLower());
        Console.WriteLine(degisken2.ToUpper());

        //Concat;//  merhaba ile birlestiriyor
        Console.WriteLine(string.Concat(degisken, "Merhaba"));

        //Compare; //CompareTo;
        // CompareTo birinci degisenin karakter sayisi 2 degiskene esit olursa 0, büyük  olursa 1, kücük olursa -1 döner.
        // 
        Console.WriteLine(degisken.CompareTo(degisken2));
        Console.WriteLine(string.Compare(degisken, degisken2, true));// true büyük kücük harf duyarsizi karsilastiriyoruz , sagliyorsa burda 0
        Console.WriteLine(string.Compare(degisken, degisken2, false));// false büyük kücük harf duyarli saglamiyorsa 1 konsolda geri döner.

        //Contains;

        Console.WriteLine(degisken.Contains(degisken2));//degisken icinde degisken2 var mi?
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));//  Hosgeldinizle bittiyor mu?
        Console.WriteLine(degisken.StartsWith("Merhaba"));// merhaba ile basliyor mu

        //IndexOf; LastIndexOf;
        Console.WriteLine(degisken.IndexOf("C")); // degiskenin icinde C karakterini ilk buldugu indexi veriyor, hicbirsey bulamazsa -1 döner.
        Console.WriteLine(degisken.LastIndexOf("i")); // i harfinin bulundugu son indexi getirir.

        //Insert;
        Console.WriteLine(degisken.Insert(0, "Merhaba!")); //0. indexten baslayarak stringin basina Merhaba ekler.

        //PadLeft; PadRight;
        Console.WriteLine(degisken + degisken2.PadLeft(30));//degisken2 nin sonuna indexi 30 tamamliycak kadar bosluk ekle
        Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));//degisken2 nin indexini 30 tamamliycak kadar * ekledi.
        Console.WriteLine(degisken.PadRight(50) + degisken2); //degiskenin indexini 50 ye tamamliycak kadar bosluk ekeldi.
        Console.WriteLine(degisken.PadRight(50, '-') + degisken2);//degiskenin indexini 50ye tamaliycak kadar - ekledi.

        //Remove;
        Console.WriteLine(degisken.Remove(10));// 10.indexten basliyarak son indexe kadar siler.
        Console.WriteLine(degisken.Remove(5, 3));// 5.indexten basliyarak 3 tane karakter siler.
        Console.WriteLine(degisken.Remove(0, 1));// 0. indexten basliyarak 1 tane karakter siler.

        //Replace;
        Console.WriteLine(degisken.Replace("CSharp", "C#"));//CSharp yazsini C# yazisiyla degistir.
        Console.WriteLine(degisken.Replace(" ", "*"));//aradaki bosluklari * degisitir.

        //Split;
        Console.WriteLine(degisken.Split(' ')[1]);// bosluklara göre ayir ve diziye ata, yani yani bir dizi tanimlayip ilk indexi getir.

        //Substring;
        Console.WriteLine(degisken.Substring(4));//4.indexten basliyarak sona kadar tüm karakterleri getir
        Console.WriteLine(degisken.Substring(4, 6));// 4.indexten Basliyarak 6 karakter getirir.

        Console.ReadKey();

    }
}