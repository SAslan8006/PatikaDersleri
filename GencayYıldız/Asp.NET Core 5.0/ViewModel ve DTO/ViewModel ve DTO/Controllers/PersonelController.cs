using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ViewModel_ve_DTO.Business;
using ViewModel_ve_DTO.Models;
using ViewModel_ve_DTO.Models.ViewModels;

namespace ViewModel_ve_DTO.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            /* Kullanıcıya sunulan hiçbir veri direkt olarak entity model olmamalıdır. Bunlar için ViewModel kullanılmalıdır.
             * Veriyi viewe taşırken 50 propertyli bir nesnenin 5propertysini kullanmak için tüm propertyleri taşımamak gerekir.
             * Aynı şekilde kullanıcıdan alınan veriler de viewmodel olarak alınmalıdır ve tüm validasyonlar bu viewmodeller üzerinde gerçekleştirilmelidir.
             * 
             ***** ViewModel ve EntityModel Dönüşümleri *****
             * 1-Manuel Dönüştürme
             * 2-Implicit Operator Overload ile Dönüştürme
             * 3-Explicit Operator Overload ile Dönüştürme
             * 4-Reflection ile Dönüştürme
             * 5-AutoMapper Kütüphanesi ile Dönüştürme
             * 
             * --> Dönüşümler aşağıda
             */
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonelCreateVM personelCreateVM)
        {
            #region 1-Manuel Dönüştürme
            //Personel p = new Personel()
            //{
            //    Adi = personelCreateVM.Adi,
            //    Soyadi = personelCreateVM.Soyadi,
            //};
            #endregion

            #region 2-Implicit Operator Overload ile Dönüştürme
            // --> Personel classına git
            //Personel personel = personelCreateVM; // artık bu şekilde iki türlü de implicit convertion yapabiliyoruz
            //PersonelCreateVM vm = personel;
            #endregion

            #region 3-Explicit Operator Overload ile Dönüştürme

            // --> Personel Classına git
            //Personel personel = (Personel)personelCreateVM; // cast ile explicit dönüştürdük
            //PersonelCreateVM perss = (PersonelCreateVM)personel;
            #endregion

            #region 4-Reflection ile Dönüştürme
            // --> Business/TypeConversiona git

            //Personel p = TypeConversion.Conversion<PersonelCreateVM, Personel>(personelCreateVM);
            //PersonelListelemeIcınVM personelListeVM = TypeConversion.Conversion<Personel, PersonelListelemeIcınVM>(p);
            #endregion

            #region AutoMapper ile Dönüştürme

            // Package managerdan Install-package AutoMapper -Version 10.1.1 kodu ile kütüphaneyi kurduk
            //  --> AutoMappers/PersonelProfile git

            // startupcs'den geldin bu controllerin ctoruna git orada nasıl aldığımızı gör (ctor aşağıda)

            Personel p = Mapper.Map<Personel>(personelCreateVM); // önceden tanımladığımız maplere göre personel girdiğinde personel mv çıkacak
            PersonelCreateVM p2 = Mapper.Map<PersonelCreateVM>(p); // ( ) içinde bunu al, < > içinde de bana bu tipten getir diyoruz.
            #endregion
            return View();
        }
        public IMapper Mapper { get;}

        public PersonelController(IMapper mapper)
        {
            Mapper = mapper;
        }

        public IActionResult Listele()
        {
            List<PersonelListelemeIcınVM> personeller = new List<Personel>
            {
                new Personel{ Adi = "A", Soyadi = "B1"},
                new Personel{ Adi = "A1", Soyadi = "B2"},
                new Personel{ Adi = "A2", Soyadi = "B3"},
                new Personel{ Adi = "A3", Soyadi = "B4"},
                new Personel{ Adi = "A4", Soyadi = "B5"},
            }.Select(p => new PersonelListelemeIcınVM
            {
                Adi = p.Adi,
                Soyadi = p.Soyadi,
                Pozisyon = p.Pozisyon,
            }).ToList();

                return View(personeller);
        }
    }
}
