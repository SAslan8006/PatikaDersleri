namespace ArayuzlerOrnek
{
    public class NewCivic:Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}