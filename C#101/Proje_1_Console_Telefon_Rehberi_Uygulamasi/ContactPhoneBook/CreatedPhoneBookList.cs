using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1_Console_Telefon_Rehberi_Uygulamasi.ContactPhoneBook
{
    class CreatedPhoneBookList 
    {
        public static List<PhoneBookSabitler> Kisiler = new List<PhoneBookSabitler>();

        public static void CreatPhoneBook()
        {
           // CreatedPhoneBookList createdPhoneBookList = new CreatedPhoneBookList();      


            Kisiler.Add(new PhoneBookSabitler() { FirstName = "Ahmet", LastName = "Senocak", PhoneNumber = "05541283445" });
            Kisiler.Add(new PhoneBookSabitler() { FirstName = "Aldulselam", LastName = "Aslan", PhoneNumber = "05511283445" });
            Kisiler.Add(new PhoneBookSabitler() { FirstName = "Süleyman", LastName = "Aslan", PhoneNumber = "05515546574" });
            Kisiler.Add(new PhoneBookSabitler() { FirstName = "Tenefüs", LastName = "Can", PhoneNumber = "05411457899" });
            Kisiler.Add(new PhoneBookSabitler() { FirstName = "Programcı", LastName = "Hamdi", PhoneNumber = "05554874849" });                   

        }

        public static void PhoneNumberAdd()
        {

            Console.Write("Lütfen isim giriniz             : ");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          : ");
            string lastName = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz : ");
            string phoneNumber = Console.ReadLine();

            Kisiler.Add(new PhoneBookSabitler() { FirstName = name, LastName = lastName, PhoneNumber = phoneNumber });

            Console.WriteLine("Numara eklenmiştir.");
            Console.ReadKey();
        }

        public static void PhoneNumberList()
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var item in Kisiler)
            {
                Console.WriteLine($"İsim             : {item.FirstName}" );
                Console.WriteLine($"Soyisim          : {item.LastName}");
                Console.WriteLine($"Telefon Numarası : {item.PhoneNumber}");
                Console.WriteLine("*");
            }

            Console.WriteLine($"Rehberde {Kisiler.Count} mevcuttur.Ana menüye dönmek için bir tuşa basınız.. ");
            Console.ReadKey();
        }

        public static void PhoneNumberDelete()
        {
            //int arananindex = -1;
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string name = Console.ReadLine();
            foreach (var item in Kisiler)
            {
                if (item.FirstName == name || item.LastName == name)
                {
                    Console.Write(item.FirstName + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    char check = char.Parse(Console.ReadLine());
                    if (check == 'y')
                    {
                        Kisiler.Remove(item);
                        //Kisiler.RemoveAll(x => x.FirstName == input || x.LastName == input); tümünü silmek içindir
                        Console.WriteLine(item.FirstName + " Başarı ile silindi");
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız");
                        Console.ReadKey();
                        break;
                    }

                    else if (check == 'n')
                    {
                        break;                        
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("*Yeniden denemek için      : (2)");
                    var secim = Console.ReadLine();
                    if (secim == "1") { return; }
                    else if (secim == "2") { PhoneNumberDelete(); }
                    else { Console.WriteLine("Gecersiz bir karakter girdiniz "); Console.ReadKey(); }
                }
            }         
               
        }

        public static void PhoneNumberSearch()
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisim arama yapmak için (1) :");
            Console.WriteLine("Telefon numarasına göre arama yapmak (2) :");
            char selection = char.Parse(Console.ReadLine());
            if (selection == '1')
            {

                Console.Clear();
                Console.Write("İsim veya soyisim giriniz : ");
                string name = Console.ReadLine();
                foreach (var item in Kisiler)
                {
                    if (item.FirstName == name || item.LastName == name)
                    {
                        Console.WriteLine("İsim : " + item.FirstName);
                        Console.WriteLine("Soyisim : " + item.LastName);
                        Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                        Console.WriteLine();
                        Console.ReadKey();                       

                    }
                }
                Console.WriteLine("Böyle bir kayıt bulunamadı");
                Console.ReadKey();               

            }
            else if (selection == '2')
            {
                Console.Clear();
                Console.WriteLine("Telefon numarası giriniz.");
                string telefonNo = Console.ReadLine();
                foreach (var item in Kisiler)
                {
                    if (item.PhoneNumber == telefonNo)
                    {
                        Console.WriteLine("İsim : " + item.FirstName);
                        Console.WriteLine("Soyisim : " + item.LastName);
                        Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                        Console.WriteLine();
                        Console.ReadKey();                       

                    }
                }
                Console.WriteLine("Böyle bir kayıt bulunamadı");               

            }

        }

        public static void PhoneNumberUpdate() 
        {
            List<PhoneBookSabitler> Kisiler1 = new List<PhoneBookSabitler>();
            Console.Clear();
            Console.WriteLine("Güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine();

            foreach (var item in Kisiler)
            {
                if (item.FirstName == name || item.LastName == name)
                {

                    Console.WriteLine("İsim : " + item.FirstName);
                    Console.WriteLine("Soyisim : " + item.LastName);
                    Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                    Console.WriteLine();
                    Console.Write("Yeni isim gir : ");
                    string firstName = Console.ReadLine();
                    Console.Write("Yeni soyisim gir : ");
                    string lastName = Console.ReadLine();
                    Console.Write("Yeni numara gir : ");
                    string phoneNumber = Console.ReadLine();
                    Kisiler1.Add(new PhoneBookSabitler() { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber });
                    Console.WriteLine("Başarı ile güncellendi");
                    
                }
                else
                {
                    Kisiler1.Add(new PhoneBookSabitler() { FirstName = item.FirstName, LastName = item.LastName, PhoneNumber = item.PhoneNumber });
                }


            }
            
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            int selection = int.Parse(Console.ReadLine());
            if (selection==1)
            {
                Kisiler.Clear();
                Kisiler = Kisiler1;
            }
            if (selection == 2)
            {
                PhoneNumberUpdate();
            }
            
            Console.ReadKey();
        }

    }
}
