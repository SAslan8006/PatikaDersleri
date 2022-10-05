using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    public class SelectionOperations
    {
        public static void ListBoard() // bütün listeyi görüntüleme
        {
            Console.WriteLine("\nTODO Line");
            Console.WriteLine("**********************");
            ListAll(Board.Line, "TODO");

            Console.WriteLine("\nIN PROGRESS Line");
            Console.WriteLine("**********************");
            ListAll(Board.Line, "IN PROGRESS");

            Console.WriteLine("\nDONE Line");
            Console.WriteLine("**********************");
            ListAll(Board.Line, "DONE");

            Menu.MenuUI();


        }

        public static void ListAll(List<Card> cards, string lines)// listeyi görüntülemek
        {
            foreach (var item in cards)
            {
                if (lines == item.Line)
                {
                    Console.WriteLine("\nBaşlık: " + item.Title);
                    Console.WriteLine("İçerik: " + item.Content);
                    Console.WriteLine("Atanan Kişi: " + PersonInfo.person.Find(a => a.PersonId == item.PersonID).Name);
                    Console.WriteLine("Büyüklük: " + ((EnumSize)item.Size).ToString());
                    Console.WriteLine("-");
                }

            }
        }


        public static void AddBoard()
        {
            Console.Write("\nBaşlık Giriniz\t: ");
            string titleAdd = Console.ReadLine();
            Console.Write("İçerik Giriniz\t: ");
            string contentAdd = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int sizeAdd = int.Parse(Console.ReadLine());
            Console.Write("Kişi Seçiniz\t: ");
            int personidAdd = int.Parse(Console.ReadLine());

            if (PersonInfo.person.Find(a => a.PersonId == personidAdd).PersonId == personidAdd) // listede böyle bir kullanıcı var mı diye kontrol ediyor.
            {
                Board.Line.Add(new Card(titleAdd, contentAdd, personidAdd, sizeAdd, "TODO")); // person da kayırlı kullanıcı ise boarda yeni işlemi ekliyor. ilk tanımlama yapılırken todo listesine eklenir. (yapılacaklar listesinde öyle olur)
            }
            else
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
            }

            Menu.MenuUI();
        }


        public static void RemoveBoard()
        {
            Console.WriteLine("\nÖncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string titleBoard = (Console.ReadLine()).ToLower();
            var removeBoard = Board.Line.Where(x => x.Title.ToLower() == titleBoard).ToList(); // kullanıcının girdigi başlıkla listede ekli olan başlık var mı bakıyor
            if (removeBoard.Count > 0)
            {
                for (int i = 0; i < removeBoard.Count; i++) // aynı başlıktaki bütün boardları siliyor
                {
                    Board.Line.RemoveAll(x => x.Title.ToLower() == titleBoard);
                }
                Console.WriteLine("Silme işlemi gerçekleştirildi.");
                Menu.MenuUI();
            }

            else
            {
                NotFoundBoard();
            }
        }

        public static void TransBoard() // Line degiştirme
        {
            Console.WriteLine(" \nÖncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string titleBoard = (Console.ReadLine()).ToLower();
            var linqPerson = Board.Line.Where(x => x.Title.ToLower() == titleBoard).ToList();
            if (linqPerson.Count > 0)
            {
                TransBoardList(titleBoard);

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine(" (1) TODO");
                Console.WriteLine(" (2) IN PROGRESS");
                Console.WriteLine(" (3) DONE");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    linqPerson[0].Line = "TODO";
                    TransBoardList(titleBoard);
                }

                else if (selection == 2)
                {
                    linqPerson[0].Line = "IN PROGRESS";
                    TransBoardList(titleBoard);
                }

                else if (selection == 3)
                {
                    linqPerson[0].Line = "DONE";
                    TransBoardList(titleBoard);
                }
                else
                    Console.WriteLine("Hatalı bir seçim yaptınız!");
                Menu.MenuUI();
            }
            else
            {
                NotFoundBoard();
            }
        }

        public static void TransBoardList(string titleBoard)
        {
            var linqPerson = Board.Line.Where(x => x.Title.ToLower() == titleBoard).ToList();
            Console.WriteLine("\nBulunan Kart Bilgileri:");
            Console.WriteLine(" **************************************");
            Console.WriteLine("Başlık: " + linqPerson[0].Title);
            Console.WriteLine("İçerik: " + linqPerson[0].Content);
            Console.WriteLine("Atanan Kişi: " + PersonInfo.person.Find(a => a.PersonId == linqPerson[0].PersonID).Name);
            Console.WriteLine("Büyüklük: " + ((EnumSize)linqPerson[0].Size).ToString());
            Console.WriteLine("Line: " + linqPerson[0].Line);
        }


        public static void NotFoundBoard([CallerMemberName] string callermemberName = "") // silmek veya degiştirmek istedigimiz başlık bulunamayınca
        {
            Console.WriteLine("\nAradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine(" * İşlemi sonlandırmak için : (1).");
            Console.WriteLine(" * Yeniden denemek için : (2)");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
                Menu.MenuUI();
            else if (select == 2)
            {
                if (callermemberName == "RemoveBoard")
                {
                    RemoveBoard();
                }
                else if (callermemberName == "TransBoard")
                {
                    TransBoard();
                }
            }
            else { Console.WriteLine("Yanlış seçim yaptınız."); Menu.MenuUI(); }
        }
    }
}
