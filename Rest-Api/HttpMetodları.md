# HTTP Metotları
## GET

1. Verileri almak - listelemek için kullanılan istek metodudur.
2. http://api.example.com/users
3. http://api.example.com/users/1
## POST

1. Belirli bir kaynağa veri göndermek için kullanılır.
2. http://api.example.com/users
## PUT

1. Belirli bir kaynaktaki verinin tamamının değiştirilmesi için kullanılan metodtur.
2. http://api.example.com/users/1
{ “name": "Gurcan", "age": 40}
## PATCH

1. Belirli bir kaynaktaki verilerin bir kısmının değiştirilmesi için kullanılan metodtur.
2. http://api.example.com/users/1
{ "name": "Gurcan"}
## DELETE

1. Belirli bir kaynaktaki verilerin silinmesi için kullanılan metodtur.
2. http://api.example.com/users/1
## CONNECT - TRACE - OPTIONS - HEAD

### SAFE Metotlar
1. GET – HEAD – OPTIONS : Sunucu “state” tarafında değişiklik oluşturmazlar. “Read-only” yapısındadırlar.

### IDEMPOTENT Metotlar
1. GET – HEAD - OPTIONS – DELETE – PUT – TRACE : Tekrar durumunda sunucu state yapısında herhangi bir yan etki bırakmazlar. Safe metodlar, idempotent'tır.

### Endpoint (Sorgu Adresi)
REST API kullanımında gönderilen istek ile verilen cevap için belirlenen buluşma noktasıdır.  

Root(Base) /Path yapısından oluşur, isimler kullanılır, fiil ilgili HTTP metodu ile belirtilir. Dökümantasyon tarafından belirtilir.  

1. https://jsonplaceholder.typicode.com /posts   
Değişen değer için genelde (:) kullanılır.  

https://jsonplaceholder.typicode.com/posts/1 => /posts/:id veya /posts/{{id}}   
https://jsonplaceholder.typicode.com/posts/1/comments  
Sorgu parametreleri için (?) kullanılır.  

Aslında sorgu parametreleri REST yapısının bir parçası değildir ancak sorgu adreslerinde sıkça rastlarız.  
http://example.com/articles?sort=author&date=published  

Daha Fazlası İçin  
HTTP Methods - MDN  https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods  