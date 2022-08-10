using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulaması
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Adınızı Giriniz..:");
            string name = Console.ReadLine().TrimEnd();
            if (!LogUser.UserControl(name))
            {
                Console.WriteLine("Adınıza kayıtlı bir hesap bulunamadı,Hesap Oluşturmak İçin (1) giriniz,istemiyorsanız rastgele bir veri giriniz.");
                if (Console.ReadLine() == "1")
                    LogUser.AddUser(name);
                else return;
            }

            Console.WriteLine("\nHoşgeldiniz {0}, Lütfen yapmak istediğiniz işlemi seçiniz:\n", name);
            while (true)
            {
            a:
                Console.WriteLine("\n Para Yatırma için (1)," +
                "\n Para Çekmek için (2)," +
                "\n Borç Ödemek için (3)," +
                "\n GünSonuKontrolü için (0) yazıp giriş yapın.");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\n Yatırmak istediğiniz miktarı giriniz: ");
                        TransAction.LodgementMoney(name, int.Parse(Console.ReadLine().TrimEnd()));
                        break;
                    case 2:
                        Console.WriteLine("\n Çekmek istediğiniz miktarı giriniz: ");
                        TransAction.WithdrawMoney(name, int.Parse(Console.ReadLine().TrimEnd()));
                        break;
                    case 3:
                        Console.WriteLine("\n Borcunuzu giriniz");
                        int debt = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Yatıracağınız miktarı girin");
                        int amount = int.Parse(Console.ReadLine());
                        TransAction.Payment(name, amount, debt);
                        break;
                    case 0:
                        Console.WriteLine("\nGün sonu Raporu..:");
                        TransAction.EndOfDayCheck();
                        break;
                    default:
                        Console.WriteLine("Böyle bi işlem bulunmamakta lütfen kontrol edip tekrar giriniz");
                        goto a;
                }
            }
        }
    }
}
