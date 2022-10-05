using Proje_1_Console_Telefon_Rehberi_Uygulamasi.ContactPhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1_Console_Telefon_Rehberi_Uygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreatedPhoneBookList.CreatPhoneBook(); //Hazır listedir isteyen kişiler silebilir istendiği de cıkartılabilir
            string secim = "";
            while (secim != "exit")
            {
                Console.Clear();
                Console.WriteLine("\nProgramdan Çıkış için 'exit' giriniz");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :");
                secim = Console.ReadLine().ToLower();

                switch (secim)
                {
                    case "1":                        
                        CreatedPhoneBookList.PhoneNumberAdd();
                        break;
                    case "2":
                        CreatedPhoneBookList.PhoneNumberDelete();
                        break;
                    case "3":
                        CreatedPhoneBookList.PhoneNumberUpdate();
                        break;
                    case "4":
                        CreatedPhoneBookList.PhoneNumberList();
                        break;
                    case "5":
                        CreatedPhoneBookList.PhoneNumberSearch();
                        break;
                    case "exit": continue; 
                    default:
                        Console.WriteLine("1 ile 5 arası seçimini yapınız ya da exit ile çıkınız.");
                        Console.ReadKey();
                        break;
                }
            }
            
        }
    }
}
