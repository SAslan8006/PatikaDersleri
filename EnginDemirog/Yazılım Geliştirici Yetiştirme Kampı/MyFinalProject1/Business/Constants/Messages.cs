using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductNameAlreadyExists="Aynı isimde ürün eklenemez.";
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi gecersiz.";
        public static string ProductListed = "Ürünler Listelendi.";
        public static string MaintenanceTime = "Sistem Bakım Zamanındadır.";
        public static string ProductCountOfCategoryError="Kategori limiti 10 ürünle sınırlıdır.";
        public static string CategoryLimitExceded="Kategori limiti 15 adetle sınırlanmıştır.Bu nedenle yeni ürün eklenemiyor.";
        public static string AuthorizationDenied= "Yetkilendirmeniz yok.";
        public static string UserAlreadyExists="Kullanıcı zaten mevcuttur.";
        public static string AccessTokenCreated="Token güvenli şekilde oluşturuldu.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string PasswordError="Parola hatası.";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string UserRegistered="Kullanıcı kayıt oldu.";
    }
}
