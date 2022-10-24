using AutoMapper;
using ViewModel_ve_DTO.Models;
using ViewModel_ve_DTO.Models.ViewModels;

namespace ViewModel_ve_DTO.AutoMappers
{
    public class PersonelProfil : Profile // kütüphaneden gelen profile sınıfından türettik
    {
        public PersonelProfil()
        {
            CreateMap<Personel, PersonelCreateVM>(); // neyi neye dönüştüreceğimizi tanımladık 
            CreateMap<PersonelCreateVM, Personel>(); // bu sayede personel girdiğinde personelmv çıkacak, personelmv girdiğinde de personel çıkacak
            // neyin gireceğini de çağırırken ayarlıyoruz personelcontrollerda göreceksin.
            // bu da aslında reflection kullanıyormuş arka planda

            // --> Startup.csye git ConfigureServices kısmından ekleme yaptık
        }
    }
}
