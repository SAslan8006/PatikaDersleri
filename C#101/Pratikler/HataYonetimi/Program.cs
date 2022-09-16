using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girmiş Olduğunuz Sayı :" + sayi);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hata :" + ex.Message.ToString());
            }
            finally
            {
                System.Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
                // int a = int.Parse(null);
                // int b = int.Parse("test");
                int c = int.Parse("-20000000000");

            }
            catch (ArgumentNullException ex)
            {

                System.Console.WriteLine("Boş Değer Girdiniz ");
                System.Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Veri Tipi Uygun Değil");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                System.Console.WriteLine("Çok Küçük Ya da Çok büyük  değer girdiniz");
                System.Console.WriteLine(ex);
            }
            finally
            {
                System.Console.WriteLine("İşlem Tamamlandı");
            }
        }
    }
}
