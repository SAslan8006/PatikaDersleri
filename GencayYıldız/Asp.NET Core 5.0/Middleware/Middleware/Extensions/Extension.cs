using Microsoft.AspNetCore.Builder;
using Middleware.Middlewares;

namespace Middleware.Extensions
{
    static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
            // standarta göre bütün middlewareler IApplicationBuilder döndürüyormuş burda o yüzden bir statik metot yazdık
            // ve oluşturduğumuz HelloMiddleware'ini koyduk içine. Burada tam neden böyle şeyler yaptığımız anlayamadım.
            // şimdi startup dosyasında istediğimiz yerde app.UseHello(); diyerek middleware'imizi çağırabiliriz.
        }
    }
}
