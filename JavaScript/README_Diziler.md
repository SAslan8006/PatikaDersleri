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

// toString() 		:	Dizideki tüm elemanları içeren string veri türünde düz bir metin oluşturur ve oluşturduğu değeri geriye döndürür.

var isimler		=	new Array("Volkan", "Hakan", "Onur", new Array("Aslı", "Gökçe", new Array("Hatice", "Derya"), "Banu"), "Ümit", "Serkan");
document.write(isimler + "<br />");
var isimlerkontrol	=	typeof isimler;
document.write(isimlerkontrol + "<br /><br />");

var islem		=	isimler.toString();
document.write(islem + "<br />");
var islemkontrol	=	typeof islem;
document.write(islemkontrol + "<br /><br />");

// valueOf() 	:	Üzerinde çalışılan dizi değerinin tam anlamıyla aktarımını sağlayarak yeni bir dizi oluşturur ve oluşturduğu dizi değerini geriye döndürür.

var isimler			=	new Array("Hakan", "Serkan", "Onur", "Levent", "Arif");
document.write(isimler + "<br />");

var yeniisimler		=	isimler.valueOf();
document.write(yeniisimler + "<br />");

isimler.fill("Volkan");
document.write(isimler + "<br />");
document.write(yeniisimler);

// indexOf()	:	Dizi içerisinde parametrik olarak verilen değeri arar ve ilk eşleşmeyi sağlayan elemanın indis / index değerini geriye döndürür.

var isimler		=	new Array("Volkan", "Hakan", "Onur", "Ümit", "Onur");
document.write(isimler + "<br />");

var islemyap	=	isimler.indexOf("Onur");
document.write(islemyap);

// lastIndexOf()		:	Dizi içerisinde parametrik olarak verilen değeri arar ve son eşleşmeyi sağlayan dizi elemanın indis / index değerini geriye döndürür.

var renkler		=	new Array("Siyah", "Beyaz", "Gri", "Mavi", "Sarı", "Kırmızı", "Gri", "Mor", "Yeşil", "Gri", "Turuncu");
document.write(renkler + "<br />");

var sonuc		=	renkler.lastIndexOf("Gri");
document.write(sonuc);

// find() 		:	Kendisine parametre olarak verilen fonksiyonu dizideki her eleman üzerine tek tek olmak üzere çalıştırır ve dizi içerisinde parametrik olarak verilen değeri arar. İlk eşleşmeyi sağlayan dizi elemanının değerini geriye döndürür.
// 1. Parametre	:	Her işlemde elde edilen dizi elemanı.
// 2. Parametre	:	Her işlemde elde edilen dizi elemanının indis / index değeri.
// 3. Parametre	:	Her tekrar işleminde diziyi tutan değişkenin referansı.

function deneme(eleman, sira, referans){
	return sira == 3;
}

var sayilar		=	new Array("Siyah", "Beyaz", "Sarı", "Mavi", "Kırmızı");
document.write(sayilar + "<br />");

var sonuc		=	sayilar.find(deneme);
document.write(sonuc);

// findIndex() 	:	Kendisine parametre olarak verilen fonksiyonu dizideki her eleman üzerine tek tek olmak üzere çalıştırır ve dizi içerisinde parametrik olarak verilen değeri arar. İlk eşleşmeyi sağlayan dizi elemanının indis / index değerini geriye döndürür.
// 1. Parametre	:	Her işlemde elde edilen dizi elemanı.
// 2. Parametre	:	Her işlemde elde edilen dizi elemanının indis / index değeri.
// 3. Parametre	:	Her tekrarda diziyi tutan değişkenin referansı.

function deneme(eleman, sira, referans){
	return eleman == 50;
}

var rakamlar		=	new Array(10, 20, 30, 40, 50, 60, 70, 80, 90, 100);
document.write(rakamlar + "<br />");

var sonuc		=	rakamlar.findIndex(deneme);
document.write(sonuc);

// reduce() 	:	Kendisine parametre olarak verilen fonksiyonu dizideki her eleman üzerinde soldan sağa tek tek olmak üzere çalıştırır ve tek bir değer oluşturarak, oluşturduğu değeri geriye döndürür.
// 1. Parametre	:	Dizi içerisinde mevcut değer öncesindeki değerlerin toplamı / birleşimi.
// 2. Parametre	:	Her işlemde elde edilen dizi elemanı.
// 3. Parametre	:	Her işlemde elde edilen dizi elemanının indis / index değeri.
// 4. Parametre	:	Her tekrarda diziyi tutan değişkenin referansı.

function deneme(deger, eleman, sira, degisken){
	return deger+eleman;
}

var harfler		=	new Array("A", "B", "C", "D", "E");
document.write(harfler + "<br />");

var islem		=	harfler.reduce(deneme);
document.write(islem);

// reduceRight() 	:	Kendisine parametre olarak verilen fonksiyonu dizideki her eleman üzerinde sağdan sola tek tek olmak üzere çalıştırır ve tek bir değer oluşturarak, oluşturduğu değeri geriye döndürür.
// 1. Parametre		:	Dizi içerisinde mevcut değer öncesindeki değerlerin toplamı / birleşimi.
// 2. Parametre		:	Her işlemde elde edilen dizi elemanı.
// 3. Parametre		:	Her işlemde elde edilen dizi elemanının indis / index değeri.
// 4. Parametre		:	Her tekrarda diziyi tutan değişkenin referansı.

function deneme(deger, eleman, sira, degisken){
	return deger+eleman;
}

var icerik		=	new Array("Volkan ", "Hakan ", "Onur ", "Ümit ", "Serkan ");
document.write(icerik + "<br />");

var sonuc		=	icerik.reduceRight(deneme);
document.write(sonuc);


// reverse()		:	Dizi içerisindeki sıralamayı tersine çevirerek yeni bir dizi oluşturur ve oluşturduğu değeri geriye döndürür.

var meyveler		=	new Array("Elma", "Armut", "Karpuz", "Kavun", "Muz", ["Çiçek", "Vişne"], "Ananas");
document.write(meyveler + "<br />");

var yenimeyveler	=	meyveler.reverse();
document.write(yenimeyveler);

// sort() 	:	Dizi içeriğinin sıralanmasını sağlar. Metot Unicode (evrensel kod) olarak çalışır.

var isimler		=	["Volkan", "Ümit", "Onur", "Serkan", "Hakan"];
document.write(isimler + "<br /><br />");
isimler.sort();
document.write(isimler);

// sort() 	:	Dizi içeriğinin sıralanmasını sağlar. Metot Unicode (evrensel kod) olarak çalışır.
function sirala(a, b){
	return a-b;
}

function sirala(a, b){
	return b-a;
}

var sayilar		=	new Array(2, 12, 100, 144, 53, 8.55, 75, 10.12);

document.write(sayilar + "<br /><br />");
sayilar.sort(sirala);
document.write(sayilar);

// sort() 	:	Dizi içeriğinin sıralanmasını sağlar. Metot Unicode (evrensel kod) olarak çalışır.
function sirala(a, b){
	var alfabe	=	"AaBbCcÇçDdEeFfGgĞğHhIıİiJjKkLlMmNnOoÖöPpQqRrSsŞşTtUuÜüVvWwXxYyZz";
	
	if(a.length === 0 || b.length === 0){
		return b.length-a.length;
		//return a.length-b.length;
	}else{
		var bir		=	alfabe.indexOf(a[0]);
		var iki		=	alfabe.indexOf(b[0]);
			if(bir !== iki){
				return iki-bir;
				//return bir-iki
			}else{
				return sirala(a.slice(1), b.slice(1));
			}
	}
}

var isimler		=	new Array("Volkan", "Ümit", "Onur", "Serkan", "Hakan", "Çağatay", "Şinasi");
document.write(isimler + "<br /><br />");
isimler.sort(sirala);
document.write(isimler);

// forEach() 	:	Kendisine parametre olarak verilen fonksiyonu dizideki her eleman üzerine tek tek çalıştırır ve geriye herhangi bir değer döndürmez. Fakat istenirse ilgili değerlere erişilebilir.
// 1. parametre	:	Her işlemde elde edilen dizi elemanı.
// 2. parametre	:	Her işlemde elde edilen dizi elemanın indis / index değeri.
// 3. parametre	:	Tekrarlama işlemi için dizinin atandığı değişkenin referansı.

function islem(eleman, sira, degisken){
	sonuc	=	sonuc + " Çalıştı " + eleman + "<br />";
}

var sonuc		=	"";
var sayilar		=	["Volkan", "Hakan", "Onur", "Levent"];
document.write(sayilar + "<br />");

sayilar.forEach(islem);
document.write(sonuc);

//Örnek 2
function islem(eleman, sira, degisken){
	sonuc	+=	eleman;
}

var sonuc		=	0;
var sayilar		=	new Array(2, 4, 6, 8, 10, 12, 14, 16, 18, 20);
document.write(sayilar + "<br />");

sayilar.forEach(islem);
document.write(sonuc);

// some() 		:	Kendisine parametre olarak belirtilen fonksiyon true (doğru / geçerli / olumlu / başarılı) değeri döndürene kadar dizi elemanları üzerinde sıra ile gezinilmesini sağlar.
// 1. parametre	:	Her işlemde elde edilen dizi elemanı.
// 2. parametre	:	Her işlemde elde edilen dizi elemanının indis / index değeri.
// 3. parametre	:	Her tekrarlama işleminde diziyi tutan değişkenin referansı.

function islem(elaman, sira, degisken){
	sonuc	=	sira;
	return elaman == "Masa";
}

var sonuc		=	"";
var esyalar		=	new Array("Masa", "Sandalye", "Vitrin", "Konsol", "Sehpa", "Masa", "Koltuk");
document.write(esyalar + "<br />");

esyalar.some(islem);
document.write(sonuc);

// every() 		:	Kendisine parametre olarak verilen fonksiyon false (yanlış / olumsuz / geçersiz / başarısız) değeri döndürene kadar dizi elemanları üzerinde gezinilmesini sağlar.
// 1. Parametre	:	Her işlemde elde edilen dizi elemanı.
// 2. Parametre	:	Her işlemde elde edilen dizi elemanının indis / index değeri.
// 3. Parametre	:	Her tekrarlamada işlemin yapıldığı diziyi tutan değişkenin referansı.

function demo(eleman, sira, referans){
	islemsonuc	=	eleman;
	return eleman.length <= 5;
}

var islemsonuc	=	"";
var renkler	=	new Array("Siyah", "Beyaz", "Kırmızı", "Yeşil", "Gri", "Sarı", "Turuncu");
document.write(renkler + "<br />");

renkler.every(demo);
document.write(islemsonuc);

// filter() 	:	Kendisine parametre olarak verilen fonksiyonu dizideki her eleman üzerine çalıştırır. Fonksiyonun geriye true (doğru / olumlu / geçerli / başarı) değerini döndüren tüm elemanlarını kopyalarak yeni bir dizi oluşturur. Oluşturduğu dizinin değerini geriye döndürür.
// 1. Parametre :	Her işlem çalıştığında dizinin elemanı.
// 2. Parametre :	Her işlem çalıştığında dizinin elemanının indis / index değeri.
// 3. Parametre : 	Tekrarlama işlemindeki diziyi tutan değişkenin referansı.

function bul(eleman, sira, degisken){
	return eleman.length < 8;
}

var icerikler	=	new Array("Türkiye", "Almanya", "İngiltere", "Amerika", "Tunus", "Yunanistan", "Bulgaristan", "Kenya", "Kamerun");
document.write(icerikler + "<br />");

var sonuc	=	icerikler.filter(bul);
document.write(sonuc);

// map() 	:	Kendisine parametre olarak verilen fonksiyonu dizideki her eleman üzerinde çalıştırır. Fonksiyonun her eleman için geriye döndürdüğü değerlerden yeni bir dizi oluşur ve yeni dizi değerini geriye döndürür.
// 1. Parametre : 	Her işlemde elde edilen dizi elemanı.
// 2. Parametre : 	Her işlemde elde edilen dizi elemanının indis / index değeri.
// 3. Parametre : 	Her tekrarda diziyi tutan değişkenin referansı.

function ornek(eleman, sira, degisken){
	var islem	=	"Merhaba " + eleman;
	return islem;
}

var icerik		=	new Array("Volkan", "Hakan", "Onur", "Serkan");
document.write(icerik + "<br />");

var yeni		=	icerik.map(ornek);
document.write(yeni);

// avarage() 	:	Number (sayı) veri türü içerikli dizinin her elemanı üzerinde tek tek olmak üzere çalışır ve tüm elemanların ortalamasını bularak, bulduğu değeri geriye döndürür.


Array.prototype.avarage 	=	function(){
	var islem	=	0;
	
	for(var baslangic = 0; baslangic<this.length; baslangic++){
		islem	+=	this[baslangic];
	}
	var sonuc	=	islem / this.length;
	return sonuc;
}

Array.prototype.toplama 	=	function(){
	var islem	=	0;
	
	for(var baslangic = 0; baslangic<this.length; baslangic++){
		islem	+=	this[baslangic];
	}
	var sonuc	=	islem;
	return sonuc;
}

var sayilar		=	new Array(10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150);
document.write(sayilar + "<br />");

var ortalama	=	sayilar.toplama();
var ortalama1	=	sayilar.avarage();

document.write("Toplam:"+ortalama+"<br />");
document.write("Ortalama:"+ortalama1);

// shuffle() 	:	Dizinin her elemanı üzerinde tek tek çalışarak tüm elemanları karıştırır ve yeni bir dizi oluşturarak oluşturduğu değeri geriye döndürür.

Array.prototype.shuffle = function(){
	var elemansayisi	=	this.length;
	while(--elemansayisi > 0){
		var rastgelesayi	=	Math.floor(Math.random() * (elemansayisi + 1));
		var gecicideger		=	this[rastgelesayi];
		this[rastgelesayi] 	=	this[elemansayisi];
		this[elemansayisi] 	=	gecicideger;
	}
	return this;
}

var icerikler	=	new Array(1, "A", 3, "B", 5,7, "A", 8, "B", 9,10, "A", 11, "B", 12);
document.write(icerikler + "<br />");

var karistir	=	icerikler.shuffle();
document.write(karistir);


```
