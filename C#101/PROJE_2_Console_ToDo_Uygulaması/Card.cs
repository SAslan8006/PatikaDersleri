using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    public class Card
    {
        public Card(string title, string content, int personId, int size, string line)
        {
            Title = title;
            Content = content;
            PersonID = personId;
            Size = size;
            Line = line;
        }


        public string Title { get; set; }
        public string Content { get; set; }
        public int PersonID { get; set; }
        public int Size { get; set; }
        public string Line { get; set; }
    }
}