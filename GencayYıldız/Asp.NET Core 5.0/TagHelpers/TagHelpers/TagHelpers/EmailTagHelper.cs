using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    public class EmailTagHelper : TagHelper // bir sınıfın taghelper olabilmesi için taghelper sınıfı içinden türemelidir.
    {
        // Burada tanımladığımız propertyler taghelperdaki attributelara denk gelir. 
        public string Mail { get; set; }
        public string Display { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output) // taghelperın çalışması için process metodu override edilmelidir.
        {
            // context parametresi içinde cshtml sayfasında tetiklenen taghelperın tüm attributelerini getirir.
            // output ise kullanılan taghelpera ne çıktı vereceğini ayarlamanı sağlar.

            output.TagName = "a"; //email taghelperı tetiklendiğinde a tagı çıkaracak 
            output.Attributes.Add("href", $"mailto:{Mail}");
            //a tagının içine href attribute'u verip valuesine 2.parametreyi verecek
            // tam çıktısı şöyle olacak: <a href="mailto:furkan.ince123@hotmail.com"></a>
            output.Content.Append(Display); // bu kısımda kullanıcıya nasıl gözükeceği yani kullanıcı Display propertysinde verilen değeri görecek

            /* Yani taghelper ile bir nevi kendi html tagımızı oluşturuyoruz gibi bir şey */

            
        }
    }

    public class MailGonderFormTagHelper : TagHelper
    {

    }
}
