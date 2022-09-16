using System;
using System.Collections.Generic;
using ToDoUygulamasi.Business.Concrete;
using ToDoUygulamasi.DataAccess.Concrete;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi
{
    class Program
    {
        static CardManager cardManager = new CardManager(new CardDal());
        static PersonManager personManager = new PersonManager(new PersonDal());
        static void Main()
        {
            Giris();
        }
        static void Giris()
        {
            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            System.Console.WriteLine("*******************************************");
            System.Console.WriteLine("(1) Board Listelemek");
            System.Console.WriteLine("(2) Board'a Kart Eklemek");
            System.Console.WriteLine("(3) Board'dan Kart Silmek");
            System.Console.WriteLine("(4) Kart Taşımak");
            string gelenDeger = Console.ReadLine();
            string deger = gelenDeger.Trim().ToLower();
            switch (deger)
            {
                case "1":
                    BoardListele();
                    Giris();
                    break;
                case "2":
                    AddCard();
                    Giris();
                    break;
                case "3": break;
                case "4": break;
                default:
                    System.Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                    Giris();
                    break;


            }

        }
        static void BoardListele()
        {
            System.Console.WriteLine("TODO Line");
            System.Console.WriteLine("************************");
            Listele(cardManager.GetToDoList());

            System.Console.WriteLine("IN PROGRESS Line");
            System.Console.WriteLine("************************");
            Listele(cardManager.GetInProgressList());

            System.Console.WriteLine("DONE Line");
            System.Console.WriteLine("************************");
            Listele(cardManager.GetDoneList());


        }
        static void Listele(List<Card> cardList)
        {
            foreach (var card in cardList)
            {
                System.Console.WriteLine("Başlık      :" + card.Baslik);
                System.Console.WriteLine("İçerik      :" + card.Icerik);
                System.Console.WriteLine("Atanan Kişi :" + personManager.Get(card.AtananKisiId).FullName);
                System.Console.WriteLine("Büyüklük    :" + ((Buyuklukler)card.Buyukluk).ToString());
                System.Console.WriteLine("-");
            }
        }
        static void AddCard()
        {
            Card card = new Card();
            Console.Write("Başlık Giriniz:");
            card.Baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz:");
            card.Icerik = Console.ReadLine();
            KisiListele();
            Console.Write("Kişi Seçiniz (Lütfen Id Değerini Giriniz) :");
            int id = int.Parse(Console.ReadLine());
            card.AtananKisiId = id;
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5):");
            int sayi = int.Parse(Console.ReadLine());
            System.Console.WriteLine(card.Baslik + " Başlıklı Kart Eklendi");
            cardManager.Add(card);


        }

        static void KisiListele()
        {
            foreach (var person in personManager.GetAll())
            {
                System.Console.WriteLine("Id: {0}  Adı: {1}  Soyadı: {2}", person.Id, person.Name, person.Surname);
                
            }
            System.Console.WriteLine("**************************************");
        }
        static void DeleteCard()
        {
            System.Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            System.Console.WriteLine("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();
            var toDoCard = Board.ToDoList.Find(x=>x.Baslik.ToLower()==baslik.ToLower());
            var doneCard = Board.DoneList.Find(x=>x.Baslik.ToLower()==baslik.ToLower());
            var inProgressCard = Board.InProgressList.Find(x=>x.Baslik.ToLower()==baslik.ToLower());
            
           if (toDoCard!=null)
           {
              cardManager.Delete(toDoCard);
           }
           else if (doneCard!=null)
           {
               cardManager.Delete(toDoCard);
           }
           else if (inProgressCard !=null)
           {
               cardManager.Delete(toDoCard);
           }
           else
           {
               DeleteCard();
           }
            
        }
        

    }
}
