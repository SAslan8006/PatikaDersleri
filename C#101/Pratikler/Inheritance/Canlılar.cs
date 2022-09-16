namespace Inheritance
{
    //selaed anahtar kelimesi sınıfın kalıtım yapılmamasını sağlar
    public class Canlılar
    {
        protected void Beslenme()
        {
            System.Console.WriteLine("Canlılar Beslenir");
        }
        protected void Solunum()
        {
            System.Console.WriteLine("Canlılar solunum yapar");
        }
        protected void Bosaltim()
        {
            System.Console.WriteLine("Canlılar boşaltım yapar");
        }
        public virtual void UyaranlaraTepki(){
            System.Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
    }

}