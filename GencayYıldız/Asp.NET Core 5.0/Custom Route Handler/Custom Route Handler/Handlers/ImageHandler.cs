using ImageMagick;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Custom_Route_Handler.Handlers
{
    public class ImageHandler
    {
        public RequestDelegate Handler(string filePath)
        {
            return async c =>
            {
                FileInfo fileInfo = new FileInfo($"{filePath}\\{c.Request.RouteValues["imageName"].ToString()}");
                // contextten gelen istekteki imageName'i yakaladık. Startupta verdiğimiz rotaya göre gelecek bu.
                using MagickImage magick = new MagickImage(fileInfo);
                // boyutlandırma operasyonu için magickimage kütüphanesini kurduk
                // IDisposable interface'inden türemiş herhangi bir nesneyi dispose fonksiyonuyla dispose etmek yerine
                // using ile kullanarak ilgili fonksiyon görevini bitirdiği zaman garbage collector tarafından kaynakların salınmasını sağlıyoruz.

                int width = magick.Width, height = magick.Height;

                // https://localhost:5001/image/resim.png?w=500 vs şeklinde query string geldiğinde boyutlandırma işlemi gerçekleşecek

                if (!string.IsNullOrEmpty(c.Request.Query["w"].ToString())) // requestteki query stringdeki w değeri boş değilse
                {
                    width = int.Parse(c.Request.Query["w"].ToString()); // query stringdeki w değerini atadık
                }
                if (!string.IsNullOrEmpty(c.Request.Query["h"].ToString()))
                {
                    height = int.Parse(c.Request.Query["h"].ToString());
                }

                magick.Resize(width, height); // atadığımız yeni değerlerle resmi boyutlandırdık

                var buffer = magick.ToByteArray(); // resim formatında gösterebilmek için byte dizisine çevirdik
                c.Response.Clear(); // responseda yani gönderilecek şeyde bir şey varsa temizliyoruz çünkü kendimiz ayarlıycaz responsu şimdi
                                    // bu silme olayı bi genel kullanımmış.
                c.Response.ContentType = string.Concat("image/", fileInfo.Extension.Replace(".", ""));

                await c.Response.Body.WriteAsync(buffer, 0, buffer.Length); // bufferı 0. haneden başlatıp uzunluğu kadar komple bastırdık.
                await c.Response.WriteAsync(filePath);
            };
        }
    }
}
