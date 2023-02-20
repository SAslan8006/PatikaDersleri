# Javascript Notları 

## Fonksiyon kullanımı  

```JS
/*
function fonkisiyonismi(Parametre / Parameteler){
	Çalışacak Kodlar
}

Fonksiyon isimlendirme kuralları:
1. Fonksiyon isimleri her zaman anlamlı olarak kullanılmalıdır. [Örnek: index3.html]
2. Fonksiyon isimleri harfler ile başlayabilir. (Türkçe karakterler kullanılamaz.) [Örnek: index4.html]
3. Fonksiyon isimleri _ (alt çizgi) işareti ile başlayabilir. [Örnek: index5.html]
4. Fonksiyon isimleri $ (dolar) işareti ile başlayabilir. [Örnek: index6.html]
5. Fonksiyon isimleri hiçbir zaman rakam ile başlayamaz. (Fakat rakamlar ilk karakterden sonra kullanılabilir.) [Örnek: index7.html, index8.html]
6. Fonksiyon isimleri Javascript tarafından rezerve kelimeleri içeremez. [Örnek: index9.html]
7. Fonksiyon isimleri hiçbir zaman birden fazla kullanılamaz. [Örnek: index10.html]
8. Fonksiyon isimleri küçük harf / büyük harf duyarlıdır. [Örnek: index11.html]
*/


function demo(){
	var islem	=	8-4;
	document.write(islem);
}

function Demo(){
	var islem	=	8+4;
	document.write(islem);
}

Demo();

var ornek	=	function(){
	document.write("Merhaba");
}

ornek();

const bir	=	"Volkan ";
const iki	=	"Alakent";

const demo	=	function(){
	document.write(bir + iki);
}

demo();

var demo	=	function(){
	var isim		=	"Volkan";
	var soyisim		=	"Alakent";
	var coklu 		=	[isim, soyisim];
	return coklu;
}

var sonuc	=	demo();
document.write(sonuc);

//Koşula bağlı fonksiyon çalıştırma örneği

var deger = "Meyveler";

if(deger=="Renkler"){
	function text(){
		document.write("Siyah, Beyaz, Kırmızı, Sarı, Mavi");
	}
}else if(deger=="İsimler"){
	function text(){
		document.write("Volkan, Hakan, Onur, Ümit");
	}
}else if(deger=="Meyveler"){
	function text(){
		document.write("Elma, Armut, Ayva, Kiraz");
	}
}else{
	function text(){
		document.write("Ispanak, Pırasa, Kabak, Enginar");
	}
}

text();

// Otamatik çalışan fonksiyon
//Örnek 1
var text	=	function(){
	document.write("Merhaba");
}();
// Örnek 2
(function test(){
	document.write("Merhaba");
})();

// Fonksiyonlara parametre verme

var degerbir	=	"Volkan";
var degeriki	=	"Alakent";

var demo	=	function (parametrebir, parametreiki){
	document.write(parametrebir + "<br />");
	document.write(parametreiki);
};

demo(degerbir, degeriki);

// Fonksiyonlara parametreyle kdli tutar hesaplama

function test(tutar, kdv=18){
	var kdvtutari	=	(tutar / 100) * kdv;
	var nettutar	=	tutar + kdvtutari;
	document.write("Gelen Tutar: " + tutar + "<br />");
	document.write("Gelen Tutarın KDV'si: " + kdvtutari + "<br />");
	document.write("Toplam Tutar: " + nettutar);
}
test(1000, 8);

// Otamatik çalışan fonksiyonlara değer verme

var degiskenbir	=	"Selam";
var degiskeniki	=	"Naber";

var test	=	function(degerbir, degeriki="Volkan"){
	document.write(degerbir + " " + degeriki);
}(degiskenbir, degiskeniki);

// Fonksiyondan başka bir fonksiyon cağırma

var parabirimi	=	function (birim, tutar){
	if(birim=="Türk Lirası"){
		var kur	=	1;
	}else if(birim=="Amerikan Doları"){
		var kur	=	3;
	}else if(birim=="Euro"){
		var kur	=	4;
	}
	return tutarhesapla(kur, tutar);
}

var tutarhesapla	=	function (gelenkur, gelentutar){
	var hesapyap	=	gelenkur * gelentutar;
	document.write(hesapyap);
}

parabirimi("Amerikan Doları", 142);

// İç içe çok boyutlu fonksiyonlar

function deneme(parametrebir, parametreiki){
	function test(sonbir){
		var sonuc	=	sonbir * sonbir;
		document.write(sonuc + "<br />");
	}
	return test(parametrebir) + test(parametreiki);
}

deneme(3, 6);

function bir(a1, a2){
	function iki(b1, b2){
		function uc(c1, c2){
			return a1 + a2 + b1 + b2 + c1 + c2;
		}
		return uc;
	}
	return iki;
}

var degisken1	=	5;
var degisken2	=	10;
var degisken3	=	87;
var degisken4	=	54;
var degisken5	=	9;
var degisken6	=	18;

var sonuc	=	bir(degisken1, degisken2)(degisken3, degisken4)(degisken5, degisken6);
document.write(sonuc);

// İç içe çok boyutlu fonksiyonlarda alt fonsiyonları değiştirme ve çağırma

var deneme	=	function(){
	var sonuc	=	function(degerbir, degeriki){
		document.write(degerbir + " " + degeriki);
	}
	return sonuc;
}

deneme()("Volkan", "Hakan");

var demobir		=	function(degerbir, degeriki, degeruc){
	var testbir		=	function(){
		var testiki		=	function(){
			document.write(degerbir + " " + degeriki + " " + degeruc);
		}
		return testiki();
	}
	return testbir();
}

demobir("Volkan", "Alakent", "Javascript");

// Kendini tekrar çağıran fonksiyonlar
var ifadebir = 1;
var ifadeiki = 20;
var ifade = "Volkan Alakent<br />";
	function tekrarla(baslangicdeger, bitisdeger, ifade) {
	if (baslangicdeger <= bitisdeger) {
		document.write(baslangicdeger,". ",ifade);
		baslangicdeger += 1;
		tekrarla(baslangicdeger, bitisdeger,ifade);
	} else {
		return;
	}
	}

tekrarla(ifadebir, ifadeiki,ifade);

// length 	:	Fonksiyona tanımlanan parametre sayısı değerini geriye döndürür.

function ornek(isim, soyisim, yas, sehir, ulke){
	var islemyap	=	ornek.length;
	document.write(islemyap);
}

ornek("Volkan", "Alakent", 36, "İstanbul", "Türkiye");

// arguments 	:	Fonksiyona herhangi bir parametre tanımlanmadan bile gelebilecek tüm parametre değerlerinin alınmasını sağlar.

function ornek(isim, soyisim){
	for(var baslangic = 0; baslangic<arguments.length; baslangic++){
		document.write(arguments[baslangic] + "<br />");
	}
}

ornek("Volkan", "Alakent", 36, "İstanbul", "Türkiye");

// caller 	:	Fonksiyonu çağıran diğer bir fonksiyon referans olarak alınarak tüm bilgilerinin elde edilmesini sağlar.

function esas(){
	for(var baslangic = 0; baslangic<esas.caller.arguments.length; baslangic++){
		document.write(diger.arguments[baslangic] + "<br />");
	}
}

function diger(isim, soyisim){
	esas();
}

diger("Volkan", "Alakent");

//Fonksiyon cağırma ve return örneği
var kisi	=	function(){
	var isimsoyisim		=	"Volkan Alakent";
	return {
		isimgetir:function(){
			return isimsoyisim;
		},
		isimdegistir:function(yeniisim){
			isimsoyisim		=	yeniisim;
		}
	}
}();

kisi.isimdegistir("Hakan Alakent");
document.write(kisi.isimgetir(););



```
