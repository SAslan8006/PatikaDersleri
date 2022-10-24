using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Middleware.Middlewares
{
    public class HelloMiddleware // kendi middlewareimizi oluşturduk
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next) // bir sonraki çağrılacak middleware'i ctor içinde aldık. Bunu mimari otomatik veriyor.
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context) // bir önceki middleware'in bu middleware'i tetikleyebilmesi için
        {
            Console.WriteLine("hello world");
            await _next.Invoke(context);
        }

        // sonrasında bunu extension olarak ekledik --> extension klasöründe
    }
}
