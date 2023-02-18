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

```

