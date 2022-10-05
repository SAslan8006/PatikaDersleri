using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    public class Board
    {
        public static List<Card> Line = new List<Card>();
        //public static List<Card> ToDo = new List<Card>();
        //public static List<Card> InProgress = new List<Card>();
        //public static List<Card> Done = new List<Card>();

        public Board()
        {
            Line.Add(new Card("Ödevler", "Web API ödevini yapacak. ", 1, 1, "TODO"));
            Line.Add(new Card("Proje", "Proje dosyalarını tamamlayacak. ", 2, 2, "IN PROGRESS"));
            Line.Add(new Card("Toplantı", "08.05.2022 00.00 da toplantı yapılacak ", 3, 3, "DONE"));
            Line.Add(new Card("Kedi", "Kedileri sevin. ", 4, 4, "DONE"));
        }

    }
}
