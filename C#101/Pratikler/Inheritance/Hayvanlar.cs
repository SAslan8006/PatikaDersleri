namespace Inheritance
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon()
        {
            System.Console.WriteLine("Hayvanlar adaptasyon yapabilir");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            System.Console.WriteLine("Hayvanlar Temasa Tepki Verir");
        }
    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
        }
        public void SurunerekHareketEderler()
        {
             System.Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            System.Console.WriteLine("Kuşlar uçar");
        }
    }

}