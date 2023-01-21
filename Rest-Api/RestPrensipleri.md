<div align="center"> 

# ***REST API*** 
</div>

****

![REST](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/rest-api/rest-api-nedir/figures/RestApi.png)

## REST API Nedir?
Representational state transfer; İlgili isteğe karşılık gelen verinin **JSON / XML** gibi dosya formatlarında gönderilmesidir. REST API, REST mimarisinin prensiplerine taşıyan API’lardır. Tüm prensiplerin karşılanması durumunda **RESTful API** olarak da adlandırılır.Özetle, bir uygulamada gerçekleştirmek istediğimiz ek bir işlemi, o işlemi sağlayan başka bir uygulamadan API kullanarak gerçekleştirebiliriz.

## REST Prensipleri
- İstemci – Sunucu: (Client – Server)
- Tek Tip Arayüz: (Uniform Interface)
- Durumsuzluk: (Statelessness)
- Önbelleklenebilir: (Cacheable)
- Katmanlı Sistem: (Layered System)
- İsteğe Bağlı Kod: (Code On Demand - Optional)

## REST Prensipleri (Kısıtlamaları) I
### İstemci - Sunucu (Client - Server) Prensibi
İstemci isteği gönderen, sunucu da ilgili cevabı veren durumundadır. Birbirlerinin sorumluluk alanlarına girmezler. Birbirlerinden bağımsız programlama dilleri ve teknolojiler kullanabilirler.

![Restrict](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/rest-api/rest-prensipleri-I/figures/ReqRes.png)

### Tek Tip Arayüz (Uniform Interface) Prensibi
Aynı kaynağa yönelik olan tüm istekler, isteğin nereden geldiğinden bağımsız olarak aynı şekilde görünmelidir. Bu aynı zamanda istemci – sunucu bağımsızlığını da destekler. 4 temel özelliği bulunmaktadır.

![HATEOAS](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/rest-api/rest-prensipleri-I/figures/UniformInterface.jpg)

### Durumsuzluk (Statelessness) Prensibi
**STATE**
Söz konusu veriyi - durumu belirtir, örneğin bir veritabanı için düşünürsek veritabanında o an için bulunan veridir. Bir React uygulamasını düşünürsek herhangi bir component’ın o an ki durumu. Modal’ın açık veya kapalı olması, kullanıcının giriş, çıkış durumu gibi.
Stateful ( Durum bilgisi olan ) vs Stateless ( Durum bilgisi olmayan ) İstemci tafından gerçekleştirilen her istek birbirinden bağımsızdır ve sunucu bu isteklerin her birini bağımsız olarak değerlendirir. Sunucu istemci tarafından kendisine gönderilen bilgileri tutmamalıdır. Örneğin bir isteğimiz kimlik doğrulama (Authentication) işlemi gerektiriyorsa ilgili tüm bilgiler (token vs..) istemci tarafından sunucuya devamlı olarak gönderilmelidir.

## Stateful vs. Stateless 

![svsslss](https://miro.medium.com/max/720/1*K7FV2rNNzX8AkYkNOOd6qg.webp)

### Stateful
![img](https://miro.medium.com/max/640/1*FGQUrDQYQpoNXc5TWCG17Q.webp)

Yukarıdaki şemada görebileceğiniz gibi, bir uygulamayı barındıran bir sunucumuz var, sunucunun sorgulayabileceği bir veritabanı mevcut, şemada etiketlenmiş uygulamanın iki ana özelliği vardır: Oturum Açma ve Profili Görüntüle, kimse şu ana kadar profili görüntüleyemez. Kimliği doğrulanana kadar... böylece Bob adlı bir kullanıcı kimlik doğrulaması yapmak için oturum açma kimlik bilgilerini sunucuya gönderir

Sunucu, veritabanını sorgular, kullanıcının kayıtlı olup olmadığını ve kimlik bilgilerinin doğru olup olmadığını inceler ve kullanıcının kimliğini doğrular

şimdi başlık altında sunucu, kullanıcının kimliği başarıyla doğrulandıktan sonra oturum açmış bir değişkeni true olarak ayarlayan bir şey daha yapıyor, şimdi bu özel değişkene oturum değişkeni adı veriliyor

Bu stratejinin kullanımı, bu uygulamayı durum bilgili **(Stateful)** yapıyor çünkü kullanıcının durumunu kaydediyor, böylece kullanıcı belirtilen oturum süresi içinde siteyi tekrar ziyaret ettiğinde oturum açma kimlik bilgilerini tekrar sağlamak ve istediklerini almak zorunda kalmıyor.

bu strateji yukarıda verilen senaryoda sorunsuz çalıştı, ancak şimdi aşağıdaki senaryoyu analiz edin.

![img1](https://miro.medium.com/max/640/1*X51MZ4YbkbLJEZXU-PppFA.webp)

şimdi bu senaryoda kullanıcı bob /viewprofile istediğinde ve kimliğini doğruladığı sunucuya yönlendirilmediğinde, bu durumda yönlendirildiği sunucu server2 bob'un kim olduğunu bilmeyecektir çünkü oturum değişkeni logged sorgusuna false cevabini vermistir ve bu sunucu bob kullanıcısının tekrar oturum açmasını gerektirecektir ki bu hiçbir kullanıcı tarafından istenmez.

#### Neden iki sunucu?
Uygulamalar ölçeklendirilmek istediklerinde birden fazla makine veya sunucu kullanırlar, kullanıcı tabanı arttığında uygulamalarını barındıran sunucuların sayısını artırma eğilimindedirler çünkü tek bir sunucu cok istek alacagindan kötü performansa ve dolayısıyla kötü kullanıcı tecrubesine neden olacaktir.

aşağıdaki şemada olduğu gibi, bir kullanıcı bir siteden istekte bulunduğunda, bu istek her iki sunucudaki yükü dengeleyen bir yük dengeleyiciye **-load balancer-(LB)** gider (yük dengeleyici aslinda ters proxy'den **(reverse proxy)** başka bir şey değildir) kullanıcı isteğin hangi sunucuya gittiğini bilmez.


![img2](https://miro.medium.com/max/640/1*wzHt6KQFiixX6_JUo-nYAw.webp)
#### Stateful Dezavantajlari

Gördüğünüz gibi durum bilgisi olan hizmet, uygulamanın ölçeklenmesine izin vermez ve durum bilgisi olan hizmetten çok büyük bir kullanıcı tabanı (örneğin portföyünüz) beklemediğiniz küçük bir uygulama yapmak isterseniz, kötü kullanıcı deneyimi kaçınılmaz olacaktır.

### Stateless Service
Gördüğünüz gibi, durum bilgisi olan hizmet, uygulamayı ölçeklendirmeyi zorlaştırıyor, tahmin edin, burada bizi kurtaracak sey **Stateless** durumudur, bir şema kullanarak açıklamama izin verin.

![img3](https://miro.medium.com/max/640/1*jKFpOFP2MC7gt1zIuoj2sQ.webp)

**Stateless**, durum bilgili hizmetten **(Stateful)** biraz farklıdır, yalnızca oturum değişkenlerini kullanmaz ve bunun yerine belirteçleri **(Tokens)** kullanır, derinlemesine inceleyelim.

Artık uygulamayı barındıran her iki sunucunun da veritabanını paylaştığını fark edebilirsiniz.

Alice kullanıcısı, kimlik doğrulamasından sonra oturum açması gereken sunuculardan herhangi birine ilk isteğini yaptığında, durum bilgisi olan hizmetin aksine sunucu herhangi bir oturum değişkeni ayarlamaz ve bunun yerine, sunucunun bir dahaki sefere kullanıcının kimliğini doğrulamasına yardımcı olacak kullanıcı belirtecini **(Token)** verir.

![img](https://miro.medium.com/max/640/1*-GvT_hAEVu4oWdBoae34cA.webp)

şimdi, kullanıcı bir dahaki sefere /viewprofile erişmeye çalıştığında, istek boyunca belirteci (token) de gönderir, isteği alan sunucu, veritabanını sorgular ve kimliğini doğrular ve **isteneni sunar**.

artık önemsiz hale gelen isteği hangi sunucunun karşıladığının önemi yok, çünkü sunucular aynı veritabanını sorguluyor artık uygulama 100 sunucuya kadar da ölçeklenebilir, ve bu durum artik sorun yaratmaktan cikar.