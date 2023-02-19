# Notlar 

## NoScript Etiketi kullanımı  

```JS
<noscript>Sayın kullanıcımız, tarayıcınızda Javascript kodlarının çalıştırılması pasif durumdadır.</noscript>
```

## document.write and document.writeln kullanımı  

```JS  
// document.write() 	=	Dökümana çıktı yapar. (nesnesel - DOM)
// document.writeln() 	=	Dökümana çıktı yapar. (yeni satırbaşı yapar.) (nesnesel - DOM)
// console.log() 	=	Tarayıcı konsoluna değer ataması yapar veya kayıt atar.
// innerHTML	=	HTML dökümanı içerisinde bulunan HTML elemanına / elementine etki eder. Veri gönderir / veri değişimi yapar.
// trim() 	:	Değişken içeriğinin varsa başındaki ve sonundaki tüm boşlukları temizleyerek değeri geriye döndürür.

document.getElementById("Ucuncu").innerHTML = "A'dan Z'ye";
<div id="Ucuncu"></div>
document.write("Levent<br />");
      debugger;

// eval() 		:	Kensidine parametre olarak verilen değerleri Javascript kodlamasına çevirerek komut gibi çalıştırır ve oluşan değeri geriye döndürür.

var degerbir	=	10;
var degeriki	=	40;

var sonucbir	=	eval("degerbir + degeriki");
document.write(sonucbir);  // Sonuc : 50

function deneme(){
	document.write("Merhaba");
}

var komut	=	eval("deneme()");

// slice() 		:	Kendisine verilecek olan parametreler ile tanımlanmış değişken içeriği aralığında bulunan değerleri kopyalayarak yeni bir içerik oluşturur ve oluşturduğu değeri geriye döndürür.
// 1. Parametre	:	Başlangıç
// 2. Parametre	:	Bitiş

// substring() 		:	Kendisine verilecek olan parametreler ile tanımlanmış değişken içeriği aralığında bulunan değerleri kopyalayarak yeni bir içerik oluşturur ve oluşturduğu değeri geriye döndürür.
// 1. Parametre		:	Başlangıç
// 2. Parametre		:	Bitiş

// substr() 	:	Kendisine verilecek olan parametreler ile tanımlanmış değişken içeriği aralığında bulunan değerleri kopyalayarak yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndürür.
// 1. Parametre	:	Başlangıç karakteri sıra numarası
// 2. Parametre	:	kaç karakter alınacağı (karakter sayısı)

var metin		=	"Volkan Alakent Javascript Eğitim Seti";  
document.write(metin + "<br />");

var sonuc		=	icerik.slice(15, 25);  
document.write(sonuc + "<br />");  

var sonuc1	=	metin.substring(15, 25);
document.write(sonuc1 + "<br />");
 
var sonuc2	=	metin.substr(11, 5);
document.write(sonuc2);

var sonuc3	=	metin.substr(-15,6);
document.write(sonuc);

// concat() 	:	Üzerinde çalışılan değişkene parametrik olarak verilen değişken veya değişkenleri dahil ederek yeni bir içerik oluşturur. Oluşturduğu değeri geriye döndürür.

var bir		=	"Volkan ";
var iki		=	"Alakent";

var sonuc	=	bir.concat(iki);
document.write(sonuc + "<br />");

// repeat() 	:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğini tekrar edip kopyalayarak, yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndürür.

var metin	=	"Javascript <br />";

var islem	=	metin.repeat(200);
document.write(islem);

// toString() 		:	Değişken içeriğini String (metin) veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.
var deger	=	5;  // number
var sonuc	=	deger.toString();
document.write(sonuc + "<br />");
document.write(typeof(sonuc) + "<br />");
// Number() 	:	Değişken içeriğini mutlak olarak Number (sayı) veri türüne dönüştürerek oluşturduğu değeri geriye döndürür.
// valueOf() 	:	Üzerinde çalışılan değişken değerinin tam anlamıyla aktarımını sağlayarak yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndürür.
// indexOf() 	:	Değişken içerisinde parametrik olarak verilen değeri arar ve ilk eşleşmeyi sağlayan değişken içeriğinin indis / index değerini geriye döndürür.
// lastIndexOf()	:	Değişken içerisinde parametrik olarak verilen değeri arar ve son eşleşmeyi sağlayan değişken içeriğinin indis / index değerini geriye döndürür.

// search() 	:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğini arayarak ilk eşleşmeyi sağlayan değişken içeriğinin indis / index değerini geriye döndürür. (Düzenli ifade alabilir.)
// i 			:	İçeriğin büyük harf / küçük olmasına bakmaz (Düzenli ifade)

var islem	=	metin.search(/scRipT/i);

// includes() 	:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğini kontrol ederek Boolean (mantıksal) veri türünde sonucu geriye döndürür.
var islem	=	metin.includes("seti");

// startsWith() 	:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğinin başlangıç değerini kontrol ederek Boolean (mantıksal) veri türünde sonucu geriye döndürür.
var sonuc	=	metin.startsWith("javascript");  
document.write(sonuc);

// endsWith() 		:	Kendisine verilen parametre doğrultusunda değişken içeriğinin bitiş değerini kontrol ederek Boolean (mantıksal) veri türünde sonucu geriye döndürür.

var sonuc	=	metin.endsWith("seti");
document.write(sonuc);

// match() 		:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğini kontrol eder ve eşleşen değer varsa içeriğin eşleşen kısmından yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndürür. (Düzenli ifade alabilir.)

// g	:	İçeriğin tamamı üzerinde çalışmasını sağlar. (Düzenli ifade)
// i	:	İçeriğin büyük harf / küçük harf olmasına bakmaz. (Düzenli ifade)


var sonuc	=	metin.match(/JavaScript/gi);
document.write(sonuc);

// replace() 	:	Kendisine verilecek olan parametreler doğrultusunda değişken içeriğini kontrol eder ve eşleşen değerlerin değişimin sağlayarak yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndürür. (Düzenli ifade alabilir.)
// 1. Parametre	:	Değişecek içerik.
// 2. Parametre	:	Güncel içerik.

// g			:	içeriğin tamamı üzerinde çalışılmasını sağlar. (Düzenli ifade)
// i			:	içeriğin büyük harf / küçük olamasına bakmaz. (Düzenli ifade)

var metin	=	"Php PHP php Php PHP php Php PHP php";

var sonuc	=	metin.replace(/PHP/gi, "Javascript");
document.write(sonuc);

// split() 		:	Kendisine parametre olarak tanımlanmış değer doğrultusunda değişken içeriğini bölümleyerek yeni bir dizi oluşturur ve oluşturduğu değeri geriye döndürür.
var sonuc	=	metin.split(" ");
document.write(sonuc + "<br />");
document.write(sonuc[2]);

// localeCompare() 	:	Üzerinde çalışılan değişkene parametrik olarak verilen diğer bir değişken içeriğini tarayıcı diline göre karşılaştırarak sonucu geriye döndürür. (Unicode (everensel kod))
// Sonuç değerleri
// -1				:	Birinci değişken içeriği, ikinci değişken içeriğinde önce geliyorsa
// 0				:	Birinci değişken içeriği, ikinci değişken içeriğine eşitse
// 1				:	Birinci değişken içeriği, ikinci değişken içeriğinde sonra geliyorsa

var icerikbir	=	"abc";
var icerikiki	=	"abd";

var sonuc		=	icerikbir.localeCompare(icerikiki);
document.write(sonuc);

// charAt() 	:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğindeki karşılığı olan karakteri bularak geriye döndürür.
document.write(icerik.charAt(13));

// charCodeAt() 	:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğindeki karşılığı olan karakteri bularak, karakterin Unicode (evrensel kod) değerini geriye döndürür.
document.write(metin.charCodeAt(13));

// fromCharCode() 	:	Kendisine parametre olarak verilen Unicode (evrensel kod) değerini karakter olarak geriye döndürür. Çoklu değer alabilir.
document.write(String.fromCharCode(43, 45, 42, 47, 37, 34));

// encodeURI() 		:	Değişken içerisindeki metnin özel karakterlerini UTF-8 (Unicode dönüşüm formatı) kodlamasına dönüştürerek oluşturduğu değeri geriye döndürür.
// decodeURI() 		:	Değişken içerisindeki metnin özel karakterlerinin UTF-8 (Unicode dönüşüm formatı) kodlamasına dönüştürülmüş karakterlerini çözerek değeri geriye döndürür.
// encodeURIComponent() 	:	Değişken içerisindeki metnin özel karakterlerini UTF-8 (Unicode dönüşüm formatı) kodlamasına dönüştürerek oluşturduğu değeri geriye döndürür.
// escape() 	:	Değişken içerisindeki metnin özel karakterlerini Unicode (evrensel kod) kodlamasına dönüştürerek oluşturduğu değeri geriye döndürür.
// unescape() 	:	Değişken içerisindeki metnin özel karakterlerinin Unicode (evrensel kod) kodlamasına dönüştürülmüş karakterlerini çözerek değeri geriye döndürür.

/*
Kodlamaya dahil edilmeyen karakterler:
0 1 2 3 4 5 6 7 8 9
a b c d e f g h i j k l m n o p q r s t u v w x y z
A B C D E F G H I J K L M N O P Q R S T U V W X Y Z
; : / ? @ & = + $ , # - _ . ! ~ * ' ( )
*/
var deger	=	"http://www.extraegitim.com?eğitimsetiadı=Javascript&Eğitmen=Volkan Alakent";
document.write(deger + "<br />");

document.write(encodeURI(deger));
document.write(decodeURI(deger));
document.write(encodeURIComponent(deger));
document.write(escape("'\"^%&()=?") + "<br />");
document.write(unescape("%22%21%27%5E%25%26%28%29%3D%3F"));

// toUpperCase() 	:	Değişken içerisindeki metnin tamamını büyük harf yaparak değeri geriye döndürür.
// toLowerCase() 	:	Değişken içerisindeki metnin tamamını küçük harfe dönüştürerek değeri geriye döndürür.
// toLocaleUpperCase()	:	Değişken içerisindeki metnin tamamını tarayıcı lokasyonuna / diline göre büyük harfe dönüştürerek değeri geriye döndürür.
// toLocaleLowerCase() 		:	Değişken içerindeki metnin tamamını tarayıcı lokasyonuna / dili göre küçük harfe dönüştürerek değeri geriye döndürür.

var metin		=	"VolKAN alakENT";
document.write(metin.toUpperCase());
document.write(metin.toLowerCase());
document.write(metin.toLocaleUpperCase());
document.write(metin.toLocaleLowerCase());

// sub() 	:	Değişken içerisindeki metni alt simge metni yaparak değerini geriye döndürür.
// sup() 	:	Değişken içerindeki metni üst simge metni yaparak değerini geriye döndürür.
// big() 	:	Değişken içerisindeki metni büyük fontlu metin yaparak değerini geriye döndürür.
// small() 		:	Değişken içerisindeki metni küçük fontlu metin yaparak değerini geriye döndürür.
// bold() 	:	Değişken içerisindeki metni kalın fontlu metin yaparak değerini geriye döndürür.
// italics() 	:	Değişken içerisindeki metni italik (sağa yatık) fontlu metin yaparak değerini geriye döndürür.
// strike() 	:	Değişken içerisindeki metni üzeri çizili metin yaparak değeri geriye döndürür.
// fixed() 		:	Değişken içerisindeki metni teletype (daktilo) fontlu metin yaparak değeri geriye döndürür.
// fontcolor()		:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğini renklendirerek değeri geriye döndürür. Varsayılan Renk green (yeşil)
// fontsize() 	:	Kendisine parametre olarak belirtilen değer doğrultusunda değişken içerisindeki metnin font boyutunu değiştirerek değeri geriye döndürür.

var ikincideger		=	"2";
var ikincidegerislemi	=	ikincideger.sub();

document.write("H" + ikincidegerislemi + "O" + "<br />");
document.write(metin.big()+ "<br />");
document.write(metin.small()+ "<br />");
document.write(metin.bold()+ "<br />");
document.write(metin.italics()+ "<br />");
document.write(metin.strike()+ "<br />");
document.write(metin.fixed()+ "<br />");
document.write(metin.fontcolor("blue")+ "<br />");
document.write(metin.fontsize(7)+ "<br />");

// anchor() 	:	Değişkene çapa (<a>...</a>) tanımlaması yapar. Aynı zamanda çapaya name değeri atar.
// <a name="extraegitim">Extra Eğitim</a>
var ornek	=	"Extra Eğitim";
alert(ornek.anchor("extraegitim"));
// link() 	:	Değişkene çapa tanımlaması yapar. Aynı zamanda çapaya köprü değeri atar.
var ornek	=	"Extra Eğitim";
document.write(ornek.link("http://www.extraegitim.com"));


```

