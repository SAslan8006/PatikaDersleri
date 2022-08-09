using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {                
                string secim = "";
                while (secim != "exit")
                {
                    Console.Clear();
                    Console.WriteLine("\nProgramdan Çıkış için 'exit' giriniz");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("1) Dikdörtgen");
                    Console.WriteLine("2) Kare ");
                    Console.WriteLine("3) Üçgen");
                    Console.WriteLine("4) Daire");
                    Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz [1-4]:");
                    secim = Console.ReadLine().ToLower();

                    switch (secim)
                    {
                        case "1":
                            Dikdortgen();
                            Console.ReadKey();
                            break;
                        case "2":
                            Kare();
                            Console.ReadKey();
                            break;
                        case "3":
                            Ucgen();
                            Console.ReadKey();
                            break;
                        case "4":
                            Daire();
                            Console.ReadKey();
                            break;
                        case "exit": 
                            continue;
                        default:
                            Console.WriteLine("1 ile 4 arası seçimini yapınız ya da exit ile çıkınız.");
                            Console.ReadKey();
                            break;
                    }


                }
                Console.ReadKey();

               
            }
        }

        private static void Daire()
        {
            int yaricap;
            Console.Clear();
            Console.WriteLine("Dairenin Yarı Çapını Girin : ");
            yaricap = int.Parse(Console.ReadLine());
            Console.WriteLine("Alan (1): ");
            Console.WriteLine("Çevre (2): ");
            Console.WriteLine("Hacim (3): ");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz [1-3]:");
            int secim = int.Parse(Console.ReadLine());
           

            if (secim == 1)
            {  
                Console.WriteLine("Dairenin Alanı : " + yaricap * yaricap / 3.14);
            }
            else if (secim == 2)
            {               
                Console.WriteLine("Dairenin Çevresi : " + 2 * 3, 14 * yaricap);
            }
            else if (secim == 3)
            {
                Console.WriteLine("Kürenin Hacmi : " + (((yaricap * yaricap * yaricap) * 3.14) * 4 / 3));
            }
            else
            {
                Console.WriteLine("Hatalı seçim gerçekleştirildi. Ana Menuye yonledirildiniz.");
            }

        }

        private static void Ucgen()
        {
            Console.Clear();
            Console.WriteLine("Alan (1): ");
            Console.WriteLine("Çevre (2): ");
            Console.WriteLine("Hacim (3): ");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz [1-3]:");
            int secim = int.Parse(Console.ReadLine());
            int kenar1, kenar2, kenar3, h;

            if (secim == 1)
            {
                Console.WriteLine("Üçgenin taban uzunluğu : ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin Yüksekliği : ");
                h = int.Parse(Console.ReadLine());

                Console.WriteLine("Üçgenin alanı : " + (kenar1 * h) / 2);
            }
            else if (secim == 2)
            {
                Console.WriteLine("Üçgenin 1.kenar uzunluğu : ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin 2.kenar uzunluğu : ");
                kenar2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin 3.kenar uzunluğu : ");
                kenar3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Üçgenin Çevresi : " + kenar1 + kenar2 + kenar3);

            }
            else if (secim == 3)
            {
                Console.WriteLine("Üçgenin taban uzunluğu : ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin Yüksekliği : ");
                kenar2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Prizmanın yüksekliği ");
                h = int.Parse(Console.ReadLine());

                Console.WriteLine("Üçgenler prizmasının hacmi : " + ((kenar1 * kenar2) / 2) * h);
            }
            else
            {
                Console.WriteLine("Hatalı seçim gerçekleştirildi. Ana Menuye yonledirildiniz.");
            }
        }

        private static void Kare()
        {
            int kenar;
            Console.Clear();
            Console.WriteLine("Kenar uzunluğunu girin : ");
            kenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Alan (1): ");
            Console.WriteLine("Çevre (2): ");
            Console.WriteLine("Hacim (3): ");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz [1-3]:");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {    
                Console.WriteLine("Karenin alanı : " + kenar * kenar);
            }
            else if (secim == 2)
            {
                Console.WriteLine("Karenin Çevresi : " + kenar * 4);
            }
            else if (secim == 3)
            {
                Console.WriteLine("Küpün hacmi : " + kenar * kenar * kenar);
            }
            else
            {
                Console.WriteLine("Hatalı seçim gerçekleştirildi. Ana Menuye yonledirildiniz.");
            }

        }

        private static void Dikdortgen()
        {
            Console.Clear();
            Console.WriteLine("Alan (1): ");
            Console.WriteLine("Çevre (2): ");
            Console.WriteLine("Hacim (3): ");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz [1-3]:");
            int secim = int.Parse(Console.ReadLine());
            int kenar1, kenar2, h;
            if (secim == 1)
            {
                Console.Write("Dikdörtgenin 1. kenar uzunlugu: ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.Write("Dikdörtgenin 2. Kenar uzunluğu: ");
                kenar2 = int.Parse(Console.ReadLine());

                Console.Write("Dikdörtgenin Alanı : " + kenar1 * kenar2);
            }
            else if (secim == 2)
            {
                Console.Write("Dikdörtgenin 1. kenar uzunlugu: ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.Write("Dikdörtgenin 2. Kenar uzunluğu: ");
                kenar2 = int.Parse(Console.ReadLine());

                Console.Write("Dikdörtgenin Çevresi :" + (kenar1 + kenar2) * 2);
            }
            else if (secim == 3)
            {
                Console.Write("Dikdörtgenin 1. kenar uzunlugu: ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.Write("Dikdörtgenin 2. Kenar uzunluğu: ");
                kenar2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin yüksekliği: ");
                h = int.Parse(Console.ReadLine());

                Console.WriteLine("Dikdörtgenini Hacmi : " + kenar1 * kenar2 * h);
            }
            else
            {
                Console.WriteLine("Hatalı seçim gerçekleştirildi. Ana Menuye yonledirildiniz.");
            }
            Console.ReadKey();
        }
    }
}
