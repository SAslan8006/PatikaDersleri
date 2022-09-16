using System.Collections.Generic;

namespace ToDoUygulamasi.Entities.Concrete
{
    public static class Board
    {
        public static List<Card> ToDoList = new List<Card>() { new Card() { Id = 1, AtananKisiId = 1, Baslik = "Elektrik Motorları", Buyukluk = 1, Icerik = "Motor Araştırma Ödevini Yapmalısın" } };
        public static List<Card> InProgressList = new List<Card>() { new Card() { Id = 2, AtananKisiId = 2, Baslik = "C# 101", Buyukluk = 2, Icerik = "Projeyi Bitir Ve Sertifika Kazan" } };
        public static List<Card> DoneList = new List<Card>() { new Card() { Id = 3, AtananKisiId = 3, Baslik = "Telefon  Rehberi", Buyukluk = 3, Icerik = "Telefon Rehberi Uygulamasını Tamamla" } };
    }
}