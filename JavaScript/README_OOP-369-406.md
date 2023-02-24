# Javascript Notları 

## Nesne Tabanlı Programlama (OOP) işlemleri  

```JS
//Nesne Tanımlama ve Nesneyi çağıurma

var bilgiler	=	{isim:"Volkan", soyisim:"Alakent", dogumtarihi:1980};

var kisiadi		=	bilgiler.isim;
var kisisoyadi	=	bilgiler.soyisim;
var kisidtarihi	=	bilgiler.dogumtarihi;

document.write("Benim adım " + kisiadi + " " + kisisoyadi + ", doğum tarihim " + kisidtarihi);

//new kkulanımı tanımlama ve Nesneyi çağıurma

// var bilgiler		=	{isim:"Volkan", soyisim:"Alakent", dtarihi:1980};

var bilgiler		=	new Object();
bilgiler.isim 		=	"Volkan";
bilgiler.soyisim 	=	"Alakent";
bilgiler.dtarihi 	=	1980;
bilgiler["isim"]	=	"Volkan";
bilgiler["soyisim"]	=	"Alakent";
bilgiler["dtarihi"]	=	1980;
var isimyaz			=	bilgiler.isim;
var soyisimyaz		=	bilgiler.soyisim;
var tarihyaz		=	bilgiler.dtarihi;

document.write("İsim : " + isimyaz + "<br />");
document.write("Soyisim : " + soyisimyaz + "<br />");
document.write("Doğum tarihi : " + tarihyaz);

//Fonksiyon şeklinde Nesne Tanımlama ve Nesneyi çağıurma
/*
var bilgiler		=	{isim:"Volkan", soyisim:"Alakent"};
*/

/*
var bilgiler		=	new Object();
bilgiler.isim 		=	"Volkan";
bilgiler.soyisim 	=	"Alakent";
*/

function ornek(){
	this.isim 		=	"Volkan";
	this.soyisim 	=	"Alakent";
}

var ornek	=	function(){
	this.isim 		=	"Volkan";
	this.soyisim 	=	"Alakent";
}

var bilgiler		=	new ornek();

var isimyaz			=	bilgiler.isim;
var soyisimyaz		=	bilgiler.soyisim;

document.write(isimyaz + " " + soyisimyaz);

//Nesnelerde özellik ve değer atamalarda tırnak kullanımı

var bilgiler	=	{isim:"Volkan", soyisim:'Alakent', dtarihi:1980};
var bilgiler	=	{'isim':"Türkiye'de", "soyisim":'Türkiye\'de'};

document.write(bilgiler.isim + "<br />");
document.write(bilgiler.soyisim + "<br />");
document.write(bilgiler.dtarihi);

//Tek bir ifadeyle birden fazla değer atama

var bilgiler = {isim:"Volkan", soyisim:"Alakent"}, renkler = {birincirenk:"Sarı", ikincirenk:"Beyaz"};

var isimyaz			=	bilgiler.isim;
var soyisimyaz		=	bilgiler.soyisim;

var birincirenkyaz	=	renkler.birincirenk;
var ikincirenkyaz	=	renkler.ikincirenk;

document.write(isimyaz + "<br />");
document.write(soyisimyaz + "<br /><br />");

document.write(birincirenkyaz + "<br />");
document.write(ikincirenkyaz);

//Bir nesneyi başka bir değişkene aktarma

var bilgiler	=	{isim:"Volkan", soyisim:"Alakent"};

var isimyaz		=	bilgiler.isim;
var soyisimyaz	=	bilgiler.soyisim;
var ornek		=	bilgiler;

var isimyaz		=	ornek.isim;
var soyisimyaz	=	ornek.soyisim;

document.write(isimyaz + " " + soyisimyaz);

// Nesneyi önceden tanımlayarak özellik ve değerleri sonradan belirtmek
// var bilgiler		=	{isim:"Volkan", soyisim:"Alakent"};

var bilgiler		=	{};
bilgiler.isim 		=	"Volkan";
bilgiler.soyisim 	=	"Alakent";

var isimsoyisimyaz	=	bilgiler.isim + " " + bilgiler.soyisim;

document.write(isimsoyisimyaz);

//Nesneleri dizi gibi görerek nesneleri değerlerine ulaşmak

var bilgiler	=	{isim:"Volkan", soyisim:"Alakent"};
var isimnedir		=	bilgiler.isim;
var soyisimnedir	=	bilgiler.soyisim;

var isimnedir		=	bilgiler["isim"];
var soyisimnedir	=	bilgiler["soyisim"];

document.write(isimnedir + " " + soyisimnedir);

//Nesneler içerisinde bir özelliği değiştirmek

var bilgiler	=	{isim:"Volkan", soyisim:"Alakent", egitimseti:"Javascript"};

var isimdegeri				=	bilgiler.isim;
var soyisimdegeri			=	bilgiler.soyisim;
var egitimsetidegeri		=	bilgiler.egitimseti;

document.write(isimdegeri + " " + soyisimdegeri + " " + egitimsetidegeri + "<br />");

bilgiler.egitimseti 		=	"PHP";
var yeniegitimsetidegeri	=	bilgiler.egitimseti;

document.write(isimdegeri + " " + soyisimdegeri + " " + yeniegitimsetidegeri);

//Nesne içerisinde fonksiyon tanımlama ve çağırma

var bilgiler	=	{
	isim:"Volkan",
	soyisim:"Alakent",
	uyari:function(){
		alert("Ben nesne içi fonksiyon koduyum");
	}
    uyari:function(){
		document.write("Ben nesne içi fonksiyon koduyum");
	}
};

var isimdegeri		=	bilgiler.isim;
var soyisimdegeri	=	bilgiler.soyisim;

bilgiler.uyari();

//Nesne içerisinde fonksiyon nesnenin özellik değerlerine fonksiyon içerisinde ulaşma
var bilgiler	=	{
	isim:"Volkan",
	soyisim:"Alakent",
	detay:function(){
		var isimdegeri		=	bilgiler.isim;
		var soyisimdegeri	=	bilgiler.soyisim;
		document.write(isimdegeri + " " + soyisimdegeri);
	}
};

bilgiler.detay();

//Nesne içerisinde fonksiyon, fonksiyon içerisinde özellik ve değer tanımala ve çağırma
var bilgiler	=	{
	isim:"Volkan",
	soyisim:"Alakent",
	detaylar:function(){
		this.yas 	=	"36";
		this.meslek =	"Bilgisayar Yazılımcısı";
	}
};

var isimyaz			=	bilgiler.isim;
var soyisimyaz		=	bilgiler.soyisim;
bilgiler.detaylar();
var yasyaz			=	bilgiler.yas;
var meslekyaz		=	bilgiler.meslek;

document.write("İsim : " + isimyaz + "<br />");
document.write("Soyisim : " + soyisimyaz + "<br />");
document.write("Yaş : " + yasyaz + "<br />");
document.write("Meslek : " + meslekyaz + "<br />");

// Nesne içerisindeki fonsiyonda return ifadesi kullanımı


var bilgiler	=	{
	detay:function(){
		var isim	=	"Volkan";
		var soyisim	=	"Alakent";
		var islem	=	[isim, soyisim];
		var islem	=	isim + " " + soyisim;
		return islem;
	}
};

var isimdegeri	=	bilgiler.detay();
document.write(isimdegeri);

// Nesnlerin kapsama alanı
var bilgilerbir		=	{
	isim:"volkan",
	tarih:1980,
	detay:function(){
		var ifade	=	"merhaba";
		document.write(ifade + "<br /><br />");
	}
};

var bilgileriki		=	{
	isim:"hakan",
	tarih:1978,
	detay:function(){
		var ifade	=	"selam";
		document.write(ifade);
	}
};

var isimdegeribir	=	bilgilerbir.isim;
var tarihdegeribir	=	bilgilerbir.tarih;

var isimdegeriiki	=	bilgileriki.isim;
var tarihdegeriiki	=	bilgileriki.tarih;

document.write(isimdegeribir + " " + tarihdegeribir + "<br />");
bilgilerbir.detay();
document.write(isimdegeriiki + " " + tarihdegeriiki + "<br />");
bilgileriki.detay();

// Özellik ve değerleri tanımlanmış bir nesneye daha sonradan ek özellik ve değerler tanımlama
var bilgiler	=	{
	isim:"Volkan",
	soyisim:"Alakent",
	dogumtarihi:1980
};

var isimdegeri			=	bilgiler.isim;
var soyisimdegeri		=	bilgiler.soyisim;
var dogumtarihidegeri	=	bilgiler.dogumtarihi;

document.write(isimdegeri + "<br />");
document.write(soyisimdegeri + "<br />");
document.write(dogumtarihidegeri + "<br />");

bilgiler.ekdateylar 	=	function(){
	document.write("İşlem Tamamlandı");
};

bilgiler.ekdateylar();

// Nesne içerisindeki fonsiyona parametre tanımlama ve fonksiyonu cağırma

var bilgiler	=	{
	degerler:function(isim, soyisim, yas){
		var isimicerigi		=	isim;
		var soyisimicerigi	=	soyisim;
		var yasicerigi		=	yas;
		var metin	=	"Merhaba benim adım " + isimicerigi + " " + soyisimicerigi + " yaşım " + yasicerigi;
		return metin;
	}
};

var sonuc	=	bilgiler.degerler("Volkan", "Alakent", "36");
document.write(sonuc + "<br />");

var sonuc	=	bilgiler.degerler("Hakan", "Alakent", "38");
document.write(sonuc);

// Nesne içerisindeki fonksiyonda bulunan parametrelere varsayılan değer ataması yapma

var bilgiler	=	{
	deger:function(isim="Volkan",soyisim="Alakent",setadi="Javascript"){
		var isimdegeri		=	isim;
		var soyisimdegeri	=	soyisim;
		var setadidegeri	=	setadi;
		var metin	=	isimdegeri + " " + soyisimdegeri + " " + setadidegeri + " eğitim seti";
		return metin;
	}	
};

var sonuc	=	bilgiler.deger("Hakan", "Deneme");
document.write(sonuc);

// Fonsiyon şekilde nesne tanımlalarında fonsiyona parametre tanımala ve fonsyonu çağırma

function ornek(isimdegeri, soyisimdegeri){
	this.isim 		=	isimdegeri;
	this.soyisim 	=	soyisimdegeri;
}

var sonuc	=	new ornek("VOLKAN", "ALAKENT");
var sonuciki	=	new ornek("volkan", "alakent");

var gelenisim		=	sonuc.isim;
var gelensoyisim	=	sonuc.soyisim;
document.write(gelenisim + " " + gelensoyisim);
var gelenisimiki		=	sonuciki.isim;
var gelensoyisimiki		=	sonuciki.soyisim;
document.write(gelenisimiki + " " + gelensoyisimiki);

// Fonksiyon şeklinde nesne tanımlaarında parametlere vasayılan değer atamaı yapma

var ornek			=	function(isim="Volkan", soyisim="Alakent"){
	this.isimdegeri 	=	isim;
	this.soyisimdegeri 	=	soyisim;
}

var sonuc			=	new ornek();

var isimyaz			=	sonuc.isimdegeri;
var soyisimyaz		=	sonuc.soyisimdegeri;
var metin			=	isimyaz + " " + soyisimyaz;
document.write(metin);

// Fonsiyon şekilinde nesne tanımalarında gönderilen parametrenin sonradan değiştirilmesi



// Nesnleride fon in döngüsünün kullanımı

// İç içe çok boyutlu nesneler ile çalışma

// Nesnelerde delete metodu kullanımı

// Nesnelerde progtotype özelliğinin kullanımı 

// Nesnelerde __proto__ özelliğinin kullanımı

// Nesnelerde hasOwnProperty() özellğinin kullanımı



```
