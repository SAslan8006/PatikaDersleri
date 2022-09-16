using System;
using TelefonRehberi.Business.Concrete;
using TelefonRehberi.DataAccess.Concrete;
using TelefonRehberi.Entities;

namespace TelefonRehberi
{
    class Program
    {
        private static PersonManager personManager = new(new PersonDal());

        static void Main(string[] args)
        {
            Islemler();
        }
        private static void Islemler()
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
            System.Console.WriteLine("***************************************************");
            System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
            System.Console.WriteLine("(2) Varolan Numarayı Silmek");
            System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            System.Console.WriteLine("(4) Rehberi Listelemek");
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");
            System.Console.WriteLine("(6) Çıkış Yap");
            Console.Write("Seçiminiz: ");
            string sayi = Console.ReadLine();
            int secilenSayi = 0;
            if (SayiKontrol(sayi))
            {
                secilenSayi = int.Parse(Console.ReadLine());
                switch (secilenSayi)
                {
                    case 1:
                        YeniNumaraKaydet();
                        break;
                    case 2:
                        NumaraSil();
                        break;
                    case 3:
                        NumaraGuncelle();
                        break;
                    case 4:
                        RehberiListele();
                        break;
                    case 5:
                        RehberiTarama();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("Lütfen Belirtilen Sayilar Dışında Giriş Yapmayınız");
                        break;
                }

            }
            System.Console.WriteLine("---------------------------------------------------");



        }
        private static bool SayiKontrol(string deger)
        {
            try
            {
                int.Parse(deger);
                return true;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Lütfen düzgün bir sayi giriniz -- ErrorMessage: {0}", ex.Message);
                Islemler();
                return false;
            }
        }

        private static void YeniNumaraKaydet()
        {
            System.Console.Write("Lütfen İsim Giriniz: ");
            string isim = Console.ReadLine();
            System.Console.Write("Lütfen Soyisim Giriniz:");
            string soyisim = Console.ReadLine();
            System.Console.Write("Lütfen telefon numarası Giriniz:");
            string numara = Console.ReadLine();

            Person person = new() { Id = 0, Name = isim, Surname = soyisim, PhoneNumber = numara };
            personManager.Add(person);
            System.Console.WriteLine("---------------------------------------------------");
            Islemler();

        }
        private static void NumaraSil()
        {
            System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz");
            string gelenDeger = Console.ReadLine();
            var person = personManager.GetByNameOrSurname(gelenDeger);
            System.Console.WriteLine(person.Name + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
            string onay = Console.ReadLine();
            if (onay == "y")
            {
                personManager.Delete(person);
                System.Console.WriteLine(person.Name + " Başarıyla Silindi");
            }
            else if (onay =="n")
            {

                NumaraSil();
            }
            else
            {
                System.Console.WriteLine("Lütfen belirtilen girişlerden birini gerçekleştiriniz");
            }


            System.Console.WriteLine("---------------------------------------------------");
            Islemler();
        }
        private static void NumaraGuncelle()
        {
            System.Console.WriteLine("Lütfen numarasını Güncellemek istediğiniz kişinin adını ya da soyadını giriniz");
            string gelenDeger = Console.ReadLine();
            var person = personManager.GetByNameOrSurname(gelenDeger);
            System.Console.Write("Hangisini Güncellemek İstersiniz:");
            System.Console.WriteLine("Adını:(1)");
            System.Console.WriteLine("Soyadını:(2)");
            System.Console.WriteLine("Numarasını:(3)");

            int sayi = int.Parse(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    System.Console.Write("Yeni Adı Giriniz:");
                    person.Name = Console.ReadLine();
                    break;
                case 2:
                    System.Console.Write("Yeni Soyadını Giriniz:");
                    person.Surname = Console.ReadLine();
                    break;
                case 3:
                    System.Console.Write("Yeni Numarayı Giriniz:");
                    person.PhoneNumber = Console.ReadLine();
                    break;
                default:
                    System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
                    NumaraGuncelle();
                    break;
            }


            personManager.Update(person);
            System.Console.WriteLine("---------------------------------------------------");
            Islemler();
        }
        private static void RehberiListele()
        {
            System.Console.WriteLine("************** Rehber ***************");
            foreach (var kisi in personManager.GetAll())
            {
                Console.WriteLine("İsim : {0}", kisi.Name);
                Console.WriteLine("Soyisim : {0}", kisi.Surname);
                Console.WriteLine("Numara : {0}", kisi.PhoneNumber);
                System.Console.WriteLine("-");
            }
            System.Console.WriteLine("---------------------------------------------------");
            Islemler();
        }
        private static void RehberiTarama()
        {
            System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            Console.Write("Seçiminiz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi == 1)
            {
                System.Console.WriteLine("Lütfen bulmak istediğiniz kişinin adını ya da soyadını giriniz");
                string gelenDeger = Console.ReadLine();
                var person = personManager.GetByNameOrSurname(gelenDeger);

                if (person != null)
                {
                    Console.WriteLine("İsim : {0}", person.Name);
                    Console.WriteLine("Soyisim : {0}", person.Surname);
                    Console.WriteLine("Numara : {0}", person.PhoneNumber);
                }
                else
                {
                    System.Console.WriteLine("Kullanıcı Bulunamadı");
                }


            }
            else if (sayi == 2)
            {
                System.Console.WriteLine("Lütfen bulmak istediğiniz kişinin numarasını giriniz");
                string gelenDeger = Console.ReadLine();
                var person = personManager.GetByNumber(gelenDeger);

                if (person != null)
                {
                    Console.WriteLine("İsim : {0}", person.Name);
                    Console.WriteLine("Soyisim : {0}", person.Surname);
                    Console.WriteLine("Numara : {0}", person.PhoneNumber);
                }
                else
                {
                    System.Console.WriteLine("Kullanıcı Bulunamadı");
                }
            }
            else
            {
                System.Console.WriteLine("Lütfen Doğru Bir Sayi Giriniz");
            }
            System.Console.WriteLine("---------------------------------------------------");
            Islemler();
        }

    }
}
