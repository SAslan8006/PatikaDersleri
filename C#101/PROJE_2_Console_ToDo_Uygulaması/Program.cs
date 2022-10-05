using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            PersonInfo personInfo = new PersonInfo();

            Menu.MenuUI();
        }
    }
}
