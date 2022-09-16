namespace Inheritance
{
    public class Bitkiler : Canlılar
    {
        protected void FotosentezYapmak()
        {
            System.Console.WriteLine("Bitkiler fotosentez yapar");
        }
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            System.Console.WriteLine("Bitkiler güneşe tepki verir");
        }
    }
    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();

        }
        public void TohumlaCogalma()
        {
            System.Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }
    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();

        }
        public void SporlaCogalma()
        {
            System.Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
        }
    }
}