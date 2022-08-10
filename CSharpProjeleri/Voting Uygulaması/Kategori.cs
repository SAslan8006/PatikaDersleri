using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Uygulaması
{
    public class Kategori
    {
        public class Categories
        {
            private int catId;
            private static int sayac = 0;
            private int catVote;
            private string catAdi;
            public static List<Categories> catList = new List<Categories>();

            public int CatId { get => catId; set => catId = value; }
            public int CatVote { get => catVote; set => catVote = value; }
            public string CatAdi { get => catAdi; set => catAdi = value; }

            public Categories(string catAdi)
            {
                this.CatAdi = catAdi;
                sayac++;
                catId = sayac;
                catList.Add(this);
            }

            public void addVote()
            {
                catVote++;
                CatVote = catVote;
            }
        }
    }
}
