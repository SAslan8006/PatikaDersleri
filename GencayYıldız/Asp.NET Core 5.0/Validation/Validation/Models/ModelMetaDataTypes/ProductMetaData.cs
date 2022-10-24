using System.ComponentModel.DataAnnotations;

namespace Validation.Models.ModelMetaDataTypes
{
    // Ayrı bir class oluşturup sadece product classının validate edilecek propertylerini burada annotations ile validate ettik.
    public class ProductMetaData
    {
        [Required(ErrorMessage ="Ürün adı giriniz")]
        public string ProductName { get; set; }
        
        // Direk entity olan classımızda validations yapmaktansa bu tür kullanım solid prensipleri için daha uygundur.
        // Bu tür validationslar için solid prensiplerine uygun farklı farklı yollar vardır.
        
    }
}
