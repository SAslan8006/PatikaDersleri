using ViewModel_ve_DTO.Models.ViewModels;

namespace ViewModel_ve_DTO.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Pozisyon { get; set; }
        public int Maas { get; set; }
        public bool MedeniHal { get; set; }

        #region Implicit/Örtük
        //public static implicit operator PersonelCreateVM(Personel model)
        //{
        //    return new PersonelCreateVM
        //    {
        //        Adi = model.Adi,
        //        Soyadi = model.Soyadi,
        //    };
        //}

        //public static implicit operator Personel(PersonelCreateVM model)
        //{
        //    return new Personel
        //    {
        //        Adi = model.Adi,
        //        Soyadi = model.Soyadi,
        //    };
        //}

        // --> PersonelControllera geri dön 
        #endregion

        #region Explicit/Açık
        public static explicit operator PersonelCreateVM(Personel model)
        {
            return new PersonelCreateVM
            {
                Adi = model.Adi,
                Soyadi = model.Soyadi,
            };
        }

        public static explicit operator Personel(PersonelCreateVM model)
        {
            return new Personel
            {
                Adi = model.Adi,
                Soyadi = model.Soyadi,
            };
        }

        // --> PersonelControllera geri dön 

        #endregion
    }
}
