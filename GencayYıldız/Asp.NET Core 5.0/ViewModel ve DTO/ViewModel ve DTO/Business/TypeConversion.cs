using System.Linq;
using System.Reflection;

namespace ViewModel_ve_DTO.Business
{
    public static class TypeConversion
    {

        // Karşılıklı dönüştürme yapacağız ve bunun için aynı kodu iki kere yazıp tekrardan kaçınmak için generic tür olarak kullanıcaz
        public static TResult Conversion<T, TResult>(T model) where TResult : class, new() // TResulta constraint verdik: nesne oluşturulabilir bir sınıf olmalı dedik
        {
            // generic tanımladık bu sayede personelden personelvmye veya personelvmden personele çevirme yapabileceğiz.
            // Generic'ler tasarlandığımız interface, class, metod yada parametrelerin (argümanların) belirli bir tip için değil
            // bir şablon yapısına uyan her tip için çalışmasını sağlayan bir yapıdır.

            // yani burada Conversion metoduna <tip1, tip2> olmak üzere iki tip vereceğiz ve bu tipleri yerine yerleştirecek.
            // ilk verdiğimiz parametre olarak girecek ve ikinci verdiğimiz sonuç olarak çıkacak.

            TResult result = new TResult();

            typeof(T).GetProperties().ToList().ForEach(p => // T'nin propertylerini aldık liste yaptık ve foreach ile döndük.
            {             
                PropertyInfo property = typeof(TResult).GetProperty(p.Name); // eğer TResult'un içinde T'deki ile aynı isimde bir property varsa getirecek
                property.SetValue(result, p.GetValue(model)); // result objesine p.Getvalue(model) değerini atadık.
                // p her bir propertyi temsil ediyor yani o sırada foreach hangi propertyi dönüyorsa onun değerini alıp atıyoruz.
                // özetle son satırda o propertynin result nesnesi içindeki değerine modelin içindeki değeri atadık.
                // (akut beyin erimesi yaşıyorum şu an)
            });

            return result;
        }
    }
}
