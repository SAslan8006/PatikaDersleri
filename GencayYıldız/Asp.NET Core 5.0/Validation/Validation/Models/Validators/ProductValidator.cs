using FluentValidation;

namespace Validation.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product> /* Hangi sınıfın validator sınıfı olduğunun ayırt edilebilmesi için
                                                                * abstractvalidator'den türettik ve hangi entityi kullanacağımızı belirttik.*/
    {
        // Startupta eklediğimiz fonksiyon AbstractValidator'den türeyen classları yakalayıp ona göre işleme alacak.
        public ProductValidator()
        {
            // Sonrasında gerekli kuralları ctor içinde veriyoruz

            RuleFor(x => x.Email).NotNull().WithMessage("Email boş olamaz!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Doğru bir e-mail adresi giriniz");
            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("Ürün adı boş olamaz"); // Mesajını yazmadığımız validasyon kendi default validasyon mesajıyla gider. Burada notempty için yazmadık. Yazılan mesaj ilk validasyonun olur.
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Ürün adı 50 karakterden fazla olamaz");
            /* Data annotationsdaki attributeların karşılığı burada fonksiyonlardır. */
            // Validasyon sonuçları önceki yöntemlerde olduğu gibi ModelState içinde kontrollera gelecektir.
        }
    }
}
