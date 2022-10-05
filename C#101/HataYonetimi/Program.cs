using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata" + ex.Message.ToString());
            }
            finally // optional an area 
            {
                Console.WriteLine("İşlem Tamamlandı.");
            }


            try
              {
                  //int a = int.Parse(null);
                 // int a = int.Parse("test");
                 int a = int.Parse("20000000000");
              }
              catch(ArgumentNullException ex)
              {
                  Console.WriteLine("Boş değer girdiniz: " + ex);
                  Console.WriteLine(ex);
              }
              catch(FormatException ex)
              {
                  Console.WriteLine("Veri tipi uygun değil. " + ex);
              }
              catch(OverflowException ex)  //veritipin aralıgına uygun olmayan değer verilince alınan hata
              {
                  Console.WriteLine("Çok küçük veya çok büyük değer girdiniz. " + ex);
              }
              finally
              {
                  Console.WriteLine("İşlem başarıyla tamamlandı.");
              }
             
            Console.ReadKey();
        }
    }
}