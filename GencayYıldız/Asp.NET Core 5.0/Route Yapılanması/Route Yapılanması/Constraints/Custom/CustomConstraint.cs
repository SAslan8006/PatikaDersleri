using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Route_Yapılanması.Constraints.Custom
{
    public class CustomConstraint : IRouteConstraint // bu interface'i ekleyip implement ettik. Sağ tık refactoring.
    {
        public bool Match(
            HttpContext httpContext,
            IRouter route,
            string routeKey, // hangi parametrede kullanıldığı
            RouteValueDictionary values, // gelen değerler
            RouteDirection routeDirection)
        {
            var gelenDeger = values[routeKey];
            return true;
        }
        // oluşturduğumuz bu constraint classını startup.cs'te ConfigureServices metodunun içinde yazarak ayar config olarak ekledik.
        // bu constraintin kullanıldığı bir parametreye veri girildiğinde bu classın içine düşecek. burada çeşitli kontroller yaparak
        // true/false döndürebiliyoruz
    }
}
