using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Voting_Uygulaması.Kategori;
using static Voting_Uygulaması.VotingoUygulamasi;

namespace Voting_Uygulaması
{
    public class Program
    {
        static string username = "suleyman";
        static string password = "1234";
        private static bool loggedIn = false;
        private static bool isVoted = false;


        static void Main(string[] args)
        {

            Calistir();

        }
        public static void Calistir()
        {
            if (!loggedIn)
                Giris();

            if (loggedIn)
            {
                while (!isVoted)
                {
                    Console.WriteLine("Oy vermek istediğiniz kategoriyi seçiniz:");
                    if (Categories.catList.Count < 1)
                        CatEkle();

                    foreach (var item in Categories.catList)
                    {
                        Console.WriteLine(item.CatId + " " + item.CatAdi);

                    }

                    Categories GetCatty = GetCat(Int32.Parse(Console.ReadLine()));
                    GetCatty.addVote();
                    isVoted = User.UserList.Find(x => x.UserName == username).voted;
                    isVoted = true;
                    foreach (var item in Categories.catList)
                    {
                        Console.WriteLine(item.CatId + " " + item.CatAdi + " - toplam oy: " + item.CatVote);
                    }
                }
                if (isVoted)
                {
                    Console.WriteLine("Oyunuz başarıyla kaydedildi.");
                }
                Giris();

            }
            else
            {
                Console.WriteLine("Önce Giriş Yapınız");
            }
        }
        public static void CatEkle()
        {
            new Categories("Film");
            new Categories("Tech");
            new Categories("Spor");

        }

        public static void KategorileriEkranaYaz()
        {
            foreach (var item in Categories.catList)
            {
                Console.WriteLine(item.CatAdi);
            }
        }
        public static Categories GetCat(int catId)
        {
            return Categories.catList.Find(x => x.CatId == catId);

        }


        public static bool isUserExists(string userName)
        {
            foreach (User item in User.UserList)
            {
                if (item.UserName == userName)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddUser()
        {
            System.Console.WriteLine("Kullanıcı adınızı giriniz:");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Parolanızı giriniz:");
            string password = Console.ReadLine();
            bool voted = false;
            isVoted = voted;
            User.UserList.Add(new User(userName, password, voted));
            loggedIn = true;
        }

        public static void Giris()
        {
            Console.WriteLine("Kullanıcı adınızı giriniz: ");
            username = Console.ReadLine();
            Console.WriteLine("şifrenizi password: ");
            password = Console.ReadLine();
            if (User.UserList.Exists(x => x.UserName == username && x.Password == password))
            {
                Console.WriteLine("Welcome " + username + "!");
                loggedIn = true;


            }
            else
            {
                Console.WriteLine("Invalid username or password!");
                AddUser();
                Calistir();

            }

        }
    }
    
}
