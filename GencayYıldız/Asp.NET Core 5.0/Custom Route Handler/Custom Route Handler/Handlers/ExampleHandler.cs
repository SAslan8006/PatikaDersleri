using Microsoft.AspNetCore.Http;

namespace Custom_Route_Handler.Handlers
{
    public class ExampleHandler
    {
        public RequestDelegate Handler() // Geriye task döndürmesi gerekiyormuş. Task döndürmesi için de async verdik delege falan kullandık tam anlamadım burada dönen olayın arka planını
        {
            return async c =>  // c contexti temsil ediyor.
            {
               await c.Response.WriteAsync("hello world");
            };
            
        }
    }
}
