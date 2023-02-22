# Javascript Notları 

## Düzenli ifadeler  

```JS

// 1. Metod		:	Değişken	=	new RegExp("Desen");
// 1. Metot		:	Değişken	=	new RegExp("Desen", "Ayarlar");

// 2. Motot		:	Değişken	=	/Desen/;
// 2. Motot		:	Değişken	=	/Desen/Ayarlar;

// match() 		:	Kendisine parametre olarak verilen düzenli ifadeli değer doğrultusunda değişken içeriğini kontrol eder ve aranan değerlerin eşleşmesi durumunda eşleşmeyi sağlayan değişken içeriği değerlerinden yeni bir dizi oluşturarak, oluşturduğu dizi değerini geriye döndürür.

var metin		=	"Merhaba Volkan nasılsın?";
var ifade		=	new RegExp("Volkan");
var sonuc		=	metin.match(ifade);
document.write(sonuc);

// match() 		:	Kendisine parametre olarak verilen düzenli ifadeli değer doğrultusunda değişken içeriğini kontrol eder ve aranan değerlerin eşleşmesi durumunda eşleşmeyi sağlayan değişken içeriği değerlerinden yeni bir dizi oluşturarak, oluşturduğu dizi değerini geriye döndürür.

var metin		=	"Merhaba Volkan nasılsın?";
var ifade		=	/Volkan/;
var sonuc		=	metin.match(ifade);
document.write(sonuc);

// g	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriğinin tamamının kontrol edilmesini sağlar.

var icerik		=	"Merhaba Volkan nasılsın? Senin adın Volkan mıydı? Volkan";
var ifade		=	new RegExp("Volkan","g");
var ifade		=	/Volkan/g;

var sonuc		=	icerik.match(ifade);
document.write(sonuc);

// global 	:	Düzenli ifade içerisinde g ayarının kullanılıp kullanılmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

var metin	=	"Volkan Volkan";
var ifade	=	new RegExp("Volkan","g");
var ifade	=	/Volkan/g;
var ifade	=	/Volkan/;
var sonuc	=	metin.match(ifade);
var kontrol	=	ifade.global;

document.write(sonuc + "<br />");
document.write(kontrol);

// i 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriğinin büyük harf / küçük harf ayrımı olmaksızın kontrol edilmesini sağlar.

var deger		=	"Merhaba Volkan nasılsın? Senin ismin VOLKAN değilmiydi?";
var ifade		=	/volkan/gi;
var ifade		=	/volkan/;
var ifade		=	new RegExp("volkan","gi");
var sonuc		=	deger.match(ifade);

// ignoreCase 	:	Düzenli ifade içerisinde i ayarının kullanılıp kullanılmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

var metin	=	"Volkan volkan VOLKAN";
var ifade	=	/volkan/;
var ifade	=	/volkan/i;
var ifade	=	new RegExp("volkan", "i");
var kontrol	=	ifade.ignoreCase;

document.write(kontrol);

// m	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriğinin birden fazla satırı varsa tüm satırların kontrol edilmesini sağlar.

var metin	=	"\nVolkan\nvolkan\nVOLKAN";
var ifade	=	/^Volkan/;
var ifade	=	new RegExp("^Volkan","gim");
var sonuc	=	metin.match(ifade);
document.write(metin);
alert(metin);

// multiline 	:	Düzenli ifade içerisinde m ayarının kullanılıp kullanılmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

var ifade	=	/^volkan/m;
var ifade	=	/^volkan/;
var ifade	=	new RegExp("^volkan", "m");
var kontrol	=	ifade.multiline;

document.write(kontrol);

// test() 	:	Kendisine parametre olarak verilen değişken içeriğinde düzenli ifade ile aranan değer eşleşmesinin olup olmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

var metin	=	"Volkan Alakent";
var ifade	=	new RegExp("Volkan");
var ifade	=	new RegExp("Hakan");
var ifade	=	/Hakan/;

var kontrol	=	ifade.test(metin);
document.write(kontrol);

// input 	:	Değişken içeriğinde düzenli ifade ile aranan değerin eşleşmesi durumunda eşleşmeyi sağlayan değişken içeriğinin tüm değeri geriye dönürür.

var metin	=	"Volkan Alakent Javascript eğitim seti.";
var ifade	=	new RegExp("Javascript");
var ifade	=	/Javascript/;

ifade.test(metin);
var sonuc	=	RegExp.input;
document.write(sonuc);

if(kontrol==true){
	var sonuc	=	RegExp.input;
	document.write(sonuc);
}else{
	document.write("Herhangi bir eşleşme bulunamadı!");
}

// source 	:	Düzenli ifade içerisinde kullanılan desen değerini geriye döndürür.

var ifade				=	new RegExp("Volkan");
var ifade				=	/Volkan/;
var ifade				=	new RegExp("Volkan","gim");
var ifade				=	/Volkan/gim;

var kullanilanifade		=	ifade.source;
document.write(kullanilanifade);

// search() 	:	Kendisine parametre olarak verilen düzenli ifadeli değer doğrultusunda değişken içeriğini kontrol eder ve ilk eşleşmeyi sağlayan değişken içeriğinin indis / index değerini geriye döndürür.

var metin	=	"Volkan Alakent Javascript eğitim seti";
var ifade	=	/Javascript/g;
var sonuc	=	metin.search(ifade);
document.write(sonuc);

// lastIndex 	:	Değişken içeriğinde düzenli ifade ile aranan değerin eşleşmesi durumunda ilk eşleşmeyi sağlayan değişken içeriğinin bir sonraki indis / index değerini geriye döndürür.

var metin	=	"Dünyada ve Türkiye'de en yaygın olarak kullanılan Script dili Javascript'tir.";
var ifade	=	new RegExp("script","gi");
var ifade	=	/script/gi;

while(ifade.test(metin)==true){
	var sonuc	=	ifade.lastIndex;
	document.write(sonuc + "<br />");
}

// lastMatch 	:	Değişken içeriğinde düzenli ifade ile aranan değerin eşleşmesi durumunda son eşleşmeyi sağlayan değişken içeriğinin değerini geriye döndürür.

var metin	=	"Dünyada ve Türkiye'de en yaygın olarak kullanılan script dili Javascript'tir.";
var ifade	=	new RegExp("Script", "g");
var ifade	=	/Script/g;
var ifade	=	new RegExp("script", "g");
ifade.test(metin);
var sonuc	=	RegExp.lastMatch;
document.write(sonuc);

// lastMatch 	:	Değişken içeriğinde düzenli ifade ile aranan değerin eşleşmesi durumunda son eşleşmeyi sağlayan değişken içeriğinin değerini geriye döndürür.

var metin	=	"Dünyada ve Türkiye'de en yaygın olarak kullanılan script dili Javascript'tir.";
var ifade	=	new RegExp("script", "g");
ifade.test(metin);
var sonuc	=	RegExp.lastMatch;
document.write(sonuc);



```
