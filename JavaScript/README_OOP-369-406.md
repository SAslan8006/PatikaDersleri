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



```
