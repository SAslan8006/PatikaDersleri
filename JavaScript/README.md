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

var icerik		=	"Volkan Alakent Javascript Eğitim Seti";  
document.write(icerik + "<br />");

var sonuc		=	icerik.slice(15, 25);  
document.write(sonuc);  
 

```

