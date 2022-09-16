namespace ToDoUygulamasi.Entities.Concrete
{
    public class Card
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int AtananKisiId { get; set; }
        public int Buyukluk { get; set; }
        
        
    }
}