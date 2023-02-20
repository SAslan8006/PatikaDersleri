# Javascript Notları 

## Diziler  

```JS

// Dizi:	Bir değişken içerisinde toplanmış, içerisinde her türden bilgi ve veriyi depolamak için kullanılan sıralı veri gruplarına verilen isimdir.
// indexler / indisler her zaman 0 ile başlar ve her elemanda 1 artarak devam eder.

var isimler		=	new Array("Volkan", "Hakan", "Onur", "Serkan", "Ümit");
document.write(isimler + "<br /><br /><br /><br />");
document.write(isimler[0] + "<br />");
document.write(isimler[1] + "<br />");
document.write(isimler[2] + "<br />");
document.write(isimler[3] + "<br />");
document.write(isimler[4]);

// Dizi içerisinde elemanlar oluşturulurken " (çift tırnak) ile başlanıyorsa " (çift tırnak) ile bitmelidir.
// Dizi içerisinde elemanlar oluşturulurken ' (tek tırnak) ile başlanıyorsa ' (tek tırnak) ile bitmelidir.
// Eleman içerisnde aynı tırnak işareti kullanılacak ise muhakkak \ (ters slash) karkateri ile kullanılmalıdır.
// Rakamsal bir değer (number) verilecek ise tırnak kullanılmamalıdır.
// var renkler		=	["Mavi", 'Sarı', 4, "Türkiye'nin başkenti Ankara'dır.", 'Türkiye\'nin başkenti Ankara\'dır.'];

var renkler		=	new Array("Mavi", 'Sarı', 4, "Türkiye'nin başkenti Ankara'dır.", 'Türkiye\'nin başkenti Ankara\'dır.');
var sonuc		=	renkler;
document.write(renkler + "<br /><br />");
document.write(renkler[0] + "<br />");
document.write(renkler[1] + "<br />");
document.write(renkler[2] + "<br />");
document.write(renkler[3] + "<br />");
document.write(sonuc[3] + "<br />");
document.write(renkler[4]);

// Dizi içerisin birden fazla dizi oluşturabilirsiniz
// Let ve var da öncede oluşturulan değişkenlerle dizi oluşturulabilir ama const a; a=["ali","yusuf"] bu şekilde sabit olduğu için dizi oluşturulamaz
// var renkler = ["Siyah", "Mavi", "Kırmızı"], isimler = ["Volkan", "Hakan", "Levent"];
var renkler = new Array("Siyah", "Mavi", "Kırmızı"), isimler = new Array("Volkan", "Hakan", "Levent");

// Değişkenler bu şekildede oluşturulup atama yapılabilir ama oluşturulması gereklidir içerisinde değer olmasada ramde sabiti (const için) olmalıdır.
// var gunler	=	new Array("Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar");
// var gunler	=	["Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"];
const gunler		=	[];
var gunler		=	new Array(7);
let gunler		=	new Array(7);
const gunler		=	new Array(7);
var gunler		=	[];
var gunler		=	["Pazartesi", "Salı"];
let gunler		=	[];

var isimler		=	new Array("Volkan", "Hakan", new Array("Aslı", "Hale", "Banu", new Array("Siyah", "Beyaz", "Mavi", "Kırmızı", "Yeşil"), "Hatice"), "Onur", "Levent");

document.write(isimler[1] + "<br />");
document.write(isimler[2][0] + "<br />");
document.write(isimler[2][1] + "<br />");
document.write(isimler[2][3][2] + "<br />");

//var sonuc	=	new Array(new Array(new Array("Sarı", "Beyaz", "Yeşil")), new Array(new Array("Volkan", "Hakan", "Levent", "Serkan")));
var sonuc	=	new Array(new Array(renkler), new Array(isimler));

// isArray()	=	Bir değişkenin içeriğinin dizi olup olup olmadığını kontrol eder. Boolean türünde sonuç döndürür. (true - false)
document.write("Sonuc değişkenin içeriği dizimi ? " + Array.isArray(sonuc) + "<br />");


var metin	=	"Javascript internet üzerinde kullanılan en yaygın script dilidir.";
document.write(metin + "<br /><br />");

var sonuc;
for(sonuc in metin){
	document.write(metin[sonuc] + " ");
}

// Dizilerde for in döngüsü
var renkler		=	["Siyah", "Beyaz", "Kırmızı", "Sarı", "Mavi"];
document.write(renkler + "<br />");

var sonuc;
for(sonuc in renkler){
	if(sonuc>=0 && sonuc<=3){
		document.write("*** " + renkler[sonuc] + "<br />");
	}else{
		document.write(renkler[sonuc] + "<br />");
	}
}

// İç içe dizilerde for in döngüsü
var tanimlar	=	new Array("Volkan", "Hakan", new Array("Aslı", "Banu", "Hatice", new Array("Siyah", "Beyaz", "Sarı", "Lacivert", "Kırmızı", "Yeşil"), "Derya", "Ayşe"), "Mesut", "Onur", "Ümit", "Serkan", "Levent", "Faik", "Hasan");
document.write(tanimlar + "<br /><br />");

var sonuc;
for(sonuc in tanimlar){
	if(Array.isArray(tanimlar[sonuc])){
		var ilkkontrol;
		for(ilkkontrol in tanimlar[sonuc]){
			if(Array.isArray(tanimlar[sonuc][ilkkontrol])){
				var sonkontrol;
				for(sonkontrol in tanimlar[sonuc][ilkkontrol]){
					document.write(tanimlar[sonuc][ilkkontrol][sonkontrol] + "<br />");
				}
			}else{
				document.write(tanimlar[sonuc][ilkkontrol] + "<br />");
			}
		}
	}else{
		document.write(tanimlar[sonuc] + "<br />");
	}
}

// length	: Dizi içeriğinin eleman sayısını veya dizi elemanının karakter sayısını geriye döndürür.

var renkler		=	new Array("Siyah", "Sarı", "Beyaz", new Array("Lacivert", "Mor", "Lila"), "Kırmızı", "Mavi");
document.write(renkler + "<br />");

var islemyap	=	renkler[3][0].length;
document.write("Alt dizi elemanının karakter sayısı: " + islemyap);

// delete	:	Dizi içerisindeki belirtilen indise / indexe ait elemanın silinmesini sağlar. İndis / index silinmez, sadece değeri boşaltılır yani tanımsız olur.

var esyalar		=	new Array("Masa", "Sandalye", "Dolap", "Vitrin");

delete esyalar[2];
document.write(esyalar[0] + "<br />");
document.write(esyalar[1] + "<br />");
document.write(esyalar[2] + "<br />");
document.write(esyalar[3]);

// pop()	:	Dizi içerisindeki en son elemanı siler ve sildiği elemanın değerini geriye döndürür.

var isimler		=	["Volkan", "Hakan", "Mesut", "Onur", "Levent"];
document.write("Dizinin orjinal hali: " + isimler + "<br /><br />");

var islemyap	=	isimler.pop();
document.write("Dizinin silinen elemanı: " + islemyap + "<br />");
document.write("Dizinin son hali: " + isimler + "<br /><br />");

// shift()		:	Dizi içerisindeki ilk elemanı siler ve sildiği elemanın değerini geriye döndürür.

var renkler		=	["Siyah", "Gri", "Beyaz", "Sarı", "Bej", "Mavi", "Kırmızı"];
document.write("Dizinin orjinal hali: " + renkler + "<br /><br />");

var islemyap	=	renkler.shift();
document.write("Dizinin silinen elemanı: " + islemyap + "<br />");
document.write("Dizinin son hali: " + renkler + "<br /><br />");

// push()	:	Dizinin sonuna eleman veya elemanlar eklenebilmesini sağlar. Eleman sayısını döndürür

var meyveler	=	new Array("Elma", "Armut", "Kiraz");
document.write(meyveler + "<br />");

var islemyap	=	meyveler.push("Kivi", "Karpuz", "Kavun", "Vişne");
document.write(meyveler + "<br />");
document.write(islemyap);

// unshift()	:	Dizinin başına eleman veya elemanlar eklenebilmesini sağlar. Eleman sayısını döndürür

var sebzeler	=	new Array("Ispanak", "Pırasa", "Lahana", "Enginar");
document.write(sebzeler + "<br />");

var islemyap	=	sebzeler.unshift("Kereviz", "Domates", "Havuç");
document.write(sebzeler + "<br />");
document.write(islemyap);

// splice()		:	Diziden eleman veya elemanlar silinebilmesini sağlar ve sildiği eleman veya elemanların değerini geri döndürür. Ayrıca diziye eleman veya elemanlar eklenebilmesini sağlar.

var renkler		=	new Array("Siyah", "Beyaz", "Mavi", "Sarı", "Kırmızı");
document.write("Dizinin orjinal hali: " + renkler + "<br />");

var islem		=	renkler.splice(2, 2, "Gri", "Turuncu", "Bordo");
document.write("Dizinin son hali: " + renkler);

// slice()		:	Kendisine verilecek olan parametreler ile tanımlanmış dizi aralığında bulunan değerleri kopyalayarak yeni bir dizi oluşturur ve oluşturduğu dizinin değerini geri döndürür.

var sayilar		=	new Array("Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz", "On");
document.write(sayilar + "<br />");

var yenisayilar	=	sayilar.slice(-8);
var yenisayilar	=	sayilar.slice(2, -3);
var yenisayilar	=	sayilar.slice(2, 5);
document.write(yenisayilar);

// copyWithin() 	: 	Kendisine verilecek olan parametreler ile tanımlanmış dizi aralığında bulunan değerleri kopyalayarak, parametreler doğrultusunda dizinin elemanlarını değiştirir ve dizinin değerini geriye döndürür.
// 1. Parametre		:	Hedef
// 2. Parametre		:	Başlangıç
// 3. Parametre		:	Bitiş

var isimler		=	new Array("Volkan", "Hakan", "Onur", "Ümit", "Levent", "Serkan", "Arif", "Cengiz", "Çağatay", "Ali", "Murat", "Kubilay", "Ahmet", "Halil", "Mustafa", "Muzaffer");
document.write(isimler + "<br />");

isimler.copyWithin(10, 3, 5);
document.write(isimler);

// fill() 		:	Kendisine verilecek olan parametreler ile tanımlanmış dizi aralığında bulunan değeri, parametre ile belirtilmiş olan değer doğrultusunda dizinin elemanlarını değiştirir ve dizinin değerini geriye döndürür.
// 1. Parametre : 	Değer
// 2. Parametre : 	Başlangıç indisi / indexi
// 3. Parametre : 	Bitiş indisi / indexi

var meyveler	=	new Array("Elma", "Armut", "Kiraz", "Kayısı", "Karpuz", "Kavun", "Muz", "Ananas");
document.write(meyveler + "<br />");

meyveler.fill("Nar", 2);
meyveler.fill("Nar", 2,-2);
document.write(meyveler);

// concat()		:	Üzerinde çalışılan diziye parametrik olarak verilen eleman veya elemanları yada dizi veye dizileri dahil ederek yeni bir dizi oluşturur ve oluşturmuş olduğu dizi değerini geriye döndürür.

var erkekisimleri		=	new Array("Volkan", "Hakan", "Onur", "Levent", "Serkan");
var bayanisimleri		=	new Array("Aslı", "Banu", "Hatice", new Array("Hale", "Ayşe", "Emine"), "Derya", "Gökçe");
var renkisimleri		=	new Array("Siyah", "Mavi", "Beyaz");

var isimler		=	erkekisimleri.concat(renkisimleri, bayanisimleri[3]);
var isimler		=	erkekisimleri.concat(renkisimleri, bayanisimleri[3][1]);
var isimler		=	erkekisimleri.concat(bayanisimleri[2], bayanisimleri[4]);

document.write(isimler);

// join()		:	Dizideki elemanların arasına kendisine parametre olarak verilen değeri ayraç olarak kullanarak string veri türünde düz bir metin oluşturur ve bu oluşturduğu değeri geriye döndürür.

var renkler		=	new Array("Siyah", "Beyaz", "Sarı", "Mavi");
var kontrolbir	=	Array.isArray(renkler);
document.write("(" + kontrolbir + ")" + renkler + "<br />");

var islem		=	renkler.join();
var kontroliki	=	Array.isArray(islem);
document.write("(" + kontroliki + ")" + islem);

//Örnek 2

var renkler		=	["Siyah", "Beyaz", ["Kırmızı", "Bordo"], "Sarı", "Mavi"];
document.write(renkler + "<br />");

var islem		=	renkler.join(" ve ");
document.write(islem);

```
