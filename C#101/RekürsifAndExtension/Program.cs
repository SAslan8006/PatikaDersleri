using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------recursive metotlar-----------------

            //3^4

            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
            islemler instance = new islemler(); // ya da islemler instance = new(); //instance oluşturmanın 2 yolu

            Console.WriteLine(instance.expo(3, 4));
            // recursive oluşturmak için class oluşturuyoruz

            //--------------extension metotlar-----------------

            string ifade = "elif buse alp";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc) //metinde boşluk varsa
                Console.WriteLine(ifade.RemoveWhiteSpaces());

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase() + "<-----lowercase");


            int[] dizi = { 93, 73, 6, 17, 8, 9 };
            dizi.SortArray();

            dizi.EkranaYazdir();

            int sayi2 = 5;
            Console.WriteLine(sayi2.isEven());

            Console.WriteLine(ifade.GetFirstCharacter());
            Console.ReadKey();
        }
    }

    public class islemler
    {
        public int expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;

            return expo(sayi, us - 1) * sayi;
        }
        //expo(3,4) çağırıldığında 
        //expo( 3, 3 ) * 3  ===> return satırı açıklama

        //expo (3,3) çağırıldığında
        //expo ( 3, 2 ) * 3 

        //expo ( 3,2) çağırıldığında
        //expo (3,1)*3

        //expo ( 3,2) çağırıldığında
        //return 3

        //sonuc = 3*3*3*3 = 81
    }

    public static class extensions //verilen cümle içinde boşluk olup olmadığını kontrol eder
    {
        public static bool CheckSpaces(this string param) //this ifadesi eklediğimizde extension metot olur
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)// metindeki boşlukları siler
        {
            string[] dizi = param.Split();  //bu stringi boşluklara göre ayır ve bir diziye at
            return string.Join("*", dizi); // diziyi boşluksuz olarak birleştirir, istenen char eklenebilir ilk parametreye
        }

        public static string MakeUpperCase(this string param) //metni uppercase yapar
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param) //metni uppercase yapar
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param) //array sort eder
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)//int diziyi ekrana yazdıran metot, ekrana yazdırdığımız için geri dönüş tipi yok void
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool isEven(this int param)    //int sayının  çift olup olmadığını kontrol eder
        {
            return param % 2 == 0; //çift ise true döner
        }

        public static string GetFirstCharacter(this string param)// verilen stringin ilk karakterini kesip getirir
        {
            return param.Substring(0, 1);  //0. indexten başlayarak 1 tane karaker verir (index, istenen karakter sayısı)
        }
    }
}