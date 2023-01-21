# HTTP Nedir?
Hyper Text Transfer Protocol ifadesinin kısaltmasıdır. İstemci ile sunucu arasındaki veri akışının kurallarını belirleyen protokoldür. İstek – Cevap (request, response) modeline göre çalışır.  
![image1](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/rest-api/http-nedir/figures/HTTP.jpeg)  

# HTTP

REST Mimarisinde HTTP'nin Rolü
REST mimarisinin prensiplerinden ilki istemci - sunucu çalışma modelidir. Biz bir istekte bulunuruz ve sunucu isteğimize karşılık olan durumu (state) bize bir sunum (presentation) olarak gönderir. HTTP protokolü burada bu sunum transferi için kurulan iletişimin kurallarını belirler. REST mimarisine uygun API'ların neredeyse tamamında HTTP protokolü kullanılır.

# HTTP Request
İstek (Request) yapısını belirtir. 4 bölümden oluşur.  

![image2](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/rest-api/http-nedir/figures/Request.png)  


Yapılan isteğin detayları belirtilir.

# HTTP Response
Cevap (Response) yapısını belirtir. 4 bölümden oluşur.  

![image3](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/rest-api/http-nedir/figures/Response.png)  


Alınan cevabın detayları belirtilir.   


Daha Fazlası İçin  
https://developer.mozilla.org/en-US/docs/Web/HTTP  
https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol   


#  HTTP Durum Kodları (Status Codes)
Sunucu tarafından ilgili isteğin sonucunu belirten, 3 rakamdan oluşan sayısal ifadelerdir.

# Informational responses (Bidirimsel cevaplar) (100–199)

100 Continue    
102 Processing    
#  Successful responses (Başarılı cevaplar) (200–299)

200 OK  
201 Created  
204 No Content  
# Redirections (Yönlendirme cevapları) (300–399)

300 Multiple Choice  
301 Moved Permanently  
304 Not Modified  
# Client errors (İstemci Hataları) (400–499)

400 Bad Request  
401 Unauthorized  
403 Forbidden  
404 Not Found  
405 Method Not Allowed  
# Server errors (Sunucu Hataları) (500–599)

500 Internal Server Error  
503 Service Unavailable  

Daha Fazlası İçin
HTTP Status Codes - MDN https://developer.mozilla.org/en-US/docs/Web/HTTP/Status#information_responses   
