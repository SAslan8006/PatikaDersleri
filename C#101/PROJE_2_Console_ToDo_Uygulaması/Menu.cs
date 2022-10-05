using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    public class Menu
    {
        public static void MenuUI()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    SelectionOperations.ListBoard();
                    break;
                case 2:
                    SelectionOperations.AddBoard();
                    break;
                case 3:
                    SelectionOperations.RemoveBoard();
                    break;
                case 4:
                    SelectionOperations.TransBoard();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    Menu.MenuUI();
                    break;


            }


        }

    }
}