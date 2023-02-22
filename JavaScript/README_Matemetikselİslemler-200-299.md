# Javascript Notları 

## Matematiksel İşlemler  

```JS
//üst alma

var degerbir		=	2;
var degeriki		=	10;

var sonuc	=	degerbir ** degeriki;

document.write(sonuc);

degerbir	**=	degeriki;
document.write(degerbir);

// MAX_VALUE 	:	Atanabilecek en büyük pozitif sayı değerini geriye döndür. (1.7976931348623157e+308)

var enbuyuksayi		=	Number.MAX_VALUE;
document.write(enbuyuksayi);

// MIN_VALUE 	:	Atanabilecek en küçük negatif sayı değerini geriye döndürür. (5e-324)

var enkucuksayi	=	Number.MIN_VALUE;
document.write(enkucuksayi);

// POSITIVE_INFINITY 	:	Atanabilecek en büyük pozitif sayı değerinden büyük sayılarda sonsuzluk değerini geriye döndürür.

var deger	=	Number.MAX_VALUE;

var islemyap	=	deger * 2;
document.write(islemyap);

// NEGATIVE_INFINITY 	:	Atanabilecek en küçük negatif sayı değerinden küçük sayılarda negatif sonsuzluk değerini geriye döndürür.

var deger	=	Number.NEGATIVE_INFINITY;
document.write(deger);

// NaN 		:	Değerin sayı olmaması durumunda geriye döner. Not a Number (Bir sayı değil)

var degerbir	=	"Volkan";
var degeriki	=	8;

var sonuc		=	degerbir * degeriki;
document.write(sonuc);

// E 	:	Euler sayısı değerini geriye döndürür. (2.718281828459045)

var deger	=	Math.E;
document.write(deger);

// LN2 		:	2 sayısının doğal logaritması değerini geriye döndürür. (0.6931471805599453)

var deger	=	Math.LN2;
document.write(deger);

// LN10 	:	10 sayısının doğal logaritması değerini geriye döndürür. (2.302585092994046)

var deger	=	Math.LN10;
document.write(deger);

// LOG2E 	:	Euler sayısının 2 tabanına göre logaritmik değerini geriye döndürür. (1.4426950408889634)

var deger	=	Math.LOG2E;
document.write(deger);

// LOG10E 	:	Euler sayısının 10 tabanına göre logaritmik değerini geriye döndürür. (0.4342944819032518)

var sonuc	=	Math.LOG10E;
document.write(sonuc);

// PI 	:	Pi sayısı değerini geriye döndürür. (3.141592653589793)

var sayi	=	Math.PI;
document.write(sayi);

// SQRT1_2	:	1/2 sayısının karekök değerini geriye döndürür. (0.7071067811865476)

var deger	=	Math.SQRT1_2;
document.write(deger);

// SQRT2	:	2 Sayısının karekök değerini geriye döndürür. (1.4142135623730951)

var sonuc	=	Math.SQRT2;
document.write(sonuc);

// isNaN() 		:	Kendisine parametrik olarak verilen değişken içeriğinin NaN (Not a Number) (sayı değil) değerinde olup olmadığını kontrol edereki boolean (mantıksal) veri türünde sonucu geriye döndürür.

var degerbir	=	"Volkan Alakent";
var degeriki	=	8;
var degeruc		=	5.55;
var degerdort	=	NaN;

var sonucbir	=	isNaN(degerbir); //Number.isNaN sadece nan olursa false döner. isNan ise içerisi sayı değilse true döner
var sonuciki	=	isNaN(degeriki);
var sonucuc		=	isNaN(degeruc);
var sonucdort	=	isNaN(degerdort);

document.write("Değer: " + degerbir + "<br />");
document.write("Sonuç: " + sonucbir + "<br /><br />");

document.write("Değer: " + degeriki + "<br />");
document.write("Sonuç: " + sonuciki + "<br /><br />");

document.write("Değer: " + degeruc + "<br />");
document.write("Sonuç: " + sonucuc + "<br /><br />");

document.write("Değer: " + degerdort + "<br />");
document.write("Sonuç: " + sonucdort);

// isFinite() 	:	Kendisine parametrik olarak verilen değişken içeriğinin en büyük pozitif sayı ile en küçük negatif sayı aralığında olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

var degerbir	=	100;
var degeriki	=	55.42;
var degeruc		=	13264274523745;
var degerdort	=	Number.MAX_VALUE * 2;
var degerbes	=	-Number.MAX_VALUE * 2;
var degeralti	=	"Volkan Alakent";

var sonucbir	=	Number.isFinite(degerbir);
var sonuciki	=	Number.isFinite(degeriki);
var sonucuc		=	Number.isFinite(degeruc);
var sonucdort	=	Number.isFinite(degerdort);
var sonucbes	=	Number.isFinite(degerbes);
var sonucalti	=	Number.isFinite(degeralti);

document.write("Değer: " + degerbir + "<br />");
document.write("Sonuç: " + sonucbir + "<br /><br />");

document.write("Değer: " + degeriki + "<br />");
document.write("Sonuç: " + sonuciki + "<br /><br />");

document.write("Değer: " + degeruc + "<br />");
document.write("Sonuç: " + sonucuc + "<br /><br />");

document.write("Değer: " + degerdort + "<br />");
document.write("Sonuç: " + sonucdort + "<br /><br />");

document.write("Değer: " + degerbes + "<br />");
document.write("Sonuç: " + sonucbes + "<br /><br />");

document.write("Değer: " + degeralti + "<br />");
document.write("Sonuç: " + sonucalti);

// isInteger() 		:	Kendisine parametrik olarak verilen değişken içeriğinin tam sayı olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

var degerbir	=	"Volkan Alakent";
var degeriki	=	8.55;
var degeruc		=	50;

var sonucbir	=	Number.isInteger(degerbir);
var sonuciki	=	Number.isInteger(degeriki);
var sonucuc		=	Number.isInteger(degeruc);

document.write("Değer: " + degerbir + "<br />");
document.write("Sonuç: " + sonucbir + "<br /><br />");

document.write("Değer: " + degeriki + "<br />");
document.write("Sonuç: " + sonuciki + "<br /><br />");

document.write("Değer: " + degeruc + "<br />");
document.write("Sonuç: " + sonucuc);

// isSafeInteger() 		:	Kendisine parametrik olarak verilen değişken içeriğinin güvenli bir tam sayı olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

var degerbir	=	5;
var degeriki	=	3.22;
var degeruc		=	1.1307794501951706e+23;

var sonucbir	=	Number.isSafeInteger(degerbir);
var sonuciki	=	Number.isSafeInteger(degeriki);
var sonucuc		=	Number.isSafeInteger(degeruc);

document.write(degerbir + "<br />");
document.write(sonucbir + "<br /><br />");

document.write(degeriki + "<br />");
document.write(sonuciki + "<br /><br />");

document.write(degeruc + "<br />");
document.write(sonucuc);

// toFixed() 	:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğindeki sayının ondalık hanesinde kaç basamak olacağını belirleyerek yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndürür.

var deger	=	4.327231213456;
document.write(deger + "<br />");

var sonuc	=	deger.toFixed(5);
document.write(sonuc);

// toPrecision()	:	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğindeki sayının kaç basamak olacağını belirleyerek yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndür. (Nokta hariç)

var degerbir	=	12.6645;
var degeriki	=	55;

var sonucbir	=	degerbir.toPrecision(4);
var sonuciki	=	degeriki.toPrecision(4);

document.write(degerbir + "<br />");
document.write(sonucbir + "<br /><br />");

document.write(degeriki + "<br />");
document.write(sonuciki);

// toExponential() 	:	Kendisine parametre olarak belirlenen değer doğrultusunda değişken içeriğindeki sayının ondalık hanesinde kaç basamak olacağını belirleyerek, kalan değeri üstel hale getirerek yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndürür.

var deger	=	5.5454556;
document.write(deger + "<br />");

var sonuc	=	deger.toExponential(2);
document.write(sonuc);

/ parseInt() 	:	Kendisine parametre olarak verilen değerler doğrultusunda değişken içeriğini tam sayı haline dönüştürerek, yeni bir içerik oluşturur ve oluşturduğu değeri geriye döndürür. (Rakam, artı değeri veya eksi değeri haricinde bir karakter gördüğünde işlem durur.)

var degerbir		=	"0x10"; // 16'lık (hexadecimal)
var degeriki		=	"10"; // 16'lık (hexadecimal)
var degeruc			=	"10"; // 8'lik (octal)

var veriturubir		=	typeof degerbir;
var verituruiki		=	typeof degeriki;
var verituruuc		=	typeof degeruc;

var sonucbir		=	parseInt(degerbir);
var sonuciki		=	parseInt(degeriki, 16);
var sonucuc			=	parseInt(degeruc, 8);

var sveriturubir	=	typeof sonucbir;
var sverituruiki	=	typeof sonuciki;
var sverituruuc		=	typeof sonucuc;

document.write("Değer: " + degerbir + " ( " + veriturubir + " ) <br />");
document.write("Sonuç: " + sonucbir + " ( " + sveriturubir + " ) <br /><br />");

document.write("Değer: " + degeriki + " ( " + verituruiki + " ) <br />");
document.write("Sonuç: " + sonuciki + " ( " + sverituruiki + " ) <br /><br />");

document.write("Değer: " + degeruc + " ( " + verituruuc + " ) <br />");
document.write("Sonuç: " + sonucuc + " ( " + sverituruuc + " )");

// parseFloat() 	Kendisine parametre olarak verilen değer doğrultusunda değişken içeriğini ondalıklı sayı haline dönüştürerek, yeni bir içerik oluşturur ve oluşturduğu içeriği geriye döndürür. (Rakam, eksi değeri, artı değeri veya nokta haricinde bir karakter gördüğünde işlem durur.)

var degerbir		=	"10";
var degeriki		=	"10.55";
var degeruc			=	"30 20 10";
var degerdort		=	" 45 ";
var degerbes		=	"10 numara";
var degeralti		=	"No 10";
var degeryedi		=	50;
var degersekiz		=	30.66;
var degerdokuz		=	-45;

var vtdegerbir		=	typeof(degerbir);
var vtdegeriki		=	typeof(degeriki);
var vtdegeruc		=	typeof(degeruc);
var vtdegerdort		=	typeof(degerdort);
var vtdegerbes		=	typeof(degerbes);
var vtdegeralti		=	typeof(degeralti);
var vtdegeryedi		=	typeof(degeryedi);
var vtdegersekiz	=	typeof(degersekiz);
var vtdegerdokuz	=	typeof(degerdokuz);

var sonucbir		=	parseFloat(degerbir);
var sonuciki		=	parseFloat(degeriki);
var sonucuc			=	parseFloat(degeruc);
var sonucdort		=	parseFloat(degerdort);
var sonucbes		=	parseFloat(degerbes);
var sonucalti		=	parseFloat(degeralti);
var sonucyedi		=	parseFloat(degeryedi);
var sonucsekiz		=	parseFloat(degersekiz);
var sonucdokuz		=	parseFloat(degerdokuz);

var vtsonucbir		=	typeof(sonucbir);
var vtsonuciki		=	typeof(sonuciki);
var vtsonucuc		=	typeof(sonucuc);
var vtsonucdort		=	typeof(sonucdort);
var vtsonucbes		=	typeof(sonucbes);
var vtsonucalti		=	typeof(sonucalti);
var vtsonucyedi		=	typeof(sonucyedi);
var vtsonucsekiz	=	typeof(sonucsekiz);
var vtsonucdokuz	=	typeof(sonucdokuz);

document.write("Değer: " + degerbir + " ( " + vtdegerbir + " ) <br />");
document.write("Sonuç: " + sonucbir + " ( " + vtsonucbir + " ) <br /><br />");

document.write("Değer: " + degeriki + " ( " + vtdegeriki + " ) <br />");
document.write("Sonuç: " + sonuciki + " ( " + vtsonuciki + " ) <br /><br />");

document.write("Değer: " + degeruc + " ( " + vtdegeruc + " ) <br />");
document.write("Sonuç: " + sonucuc + " ( " + vtsonucuc + " ) <br /><br />");

document.write("Değer: " + degerdort + " ( " + vtdegerdort + " ) <br />");
document.write("Sonuç: " + sonucdort + " ( " + vtsonucdort + " ) <br /><br />");

document.write("Değer: " + degerbes + " ( " + vtdegerbes + " ) <br />");
document.write("Sonuç: " + sonucbes + " ( " + vtsonucbes + " ) <br /><br />");

document.write("Değer: " + degeralti + " ( " + vtdegeralti + " ) <br />");
document.write("Sonuç: " + sonucalti + " ( " + vtsonucalti + " ) <br /><br />");

document.write("Değer: " + degeryedi + " ( " + vtdegeryedi + " ) <br />");
document.write("Sonuç: " + sonucyedi + " ( " + vtsonucyedi + " ) <br /><br />");

document.write("Değer: " + degersekiz + " ( " + vtdegersekiz + " ) <br />");
document.write("Sonuç: " + sonucsekiz + " ( " + vtsonucsekiz + " ) <br /><br />");

document.write("Değer: " + degerdokuz + " ( " + vtdegerdokuz + " ) <br />");
document.write("Sonuç: " + sonucdokuz + " ( " + vtsonucdokuz + " )");

// toString() 	:	Değişken içeriğini string (metin) veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.

var degerbir	=	5;
var degeriki	=	10.55;

var sonucbir	=	typeof degerbir;
var sonuciki	=	typeof degeriki;

document.write(degerbir + degeriki + "<br />");
document.write("( " + sonucbir + " ) " + degerbir + "<br />");
document.write("( " + sonuciki + " ) " + degeriki + "<br /><br />");

var islembir	=	degerbir.toString();
var islemiki	=	degeriki.toString();

var xsonucbir	=	typeof islembir;
var xsonuciki	=	typeof islemiki;

document.write(islembir + islemiki + "<br />");
document.write("( " + xsonucbir + " ) " + islembir + "<br />");
document.write("( " + xsonuciki + " ) " + islemiki + "<br /><br />");

// String() 	:	Değişken içeriğini mutlak olarak string veri türüne çevirerek oluşturduğu değeri geriye döndürür.

var bir		=	10;
var iki		=	10.55;
var uc		=	Boolean(0);
var dort	=	Boolean(1);
var bes		=	["Javascript", "Php"];
var alti	=	new Date();

var turbir	=	typeof bir;
var turiki	=	typeof iki;
var turuc	=	typeof uc;
var turdort	=	typeof dort;
var turbes	=	typeof bes;
var turalti	=	typeof alti;

document.write("Veri Türü: " + turbir + " Değer: " + bir + "<br />");
document.write("Veri Türü: " + turiki + " Değer: " + iki + "<br />");
document.write("Veri Türü: " + turuc + " Değer: " + uc + "<br />");
document.write("Veri Türü: " + turdort + " Değer: " + dort + "<br />");
document.write("Veri Türü: " + turbes + " Değer: " + bes + "<br />");
document.write("Veri Türü: " + turalti + " Değer: " + alti + "<br /><br />");

var xbir		=	String(bir);
var xiki		=	String(iki);
var xuc			=	String(uc);
var xdort		=	String(dort);
var xbes		=	String(bes);
var xalti		=	String(alti);

var xturbir		=	typeof xbir;
var xturiki		=	typeof xiki;
var xturuc		=	typeof xuc;
var xturdort	=	typeof xdort;
var xturbes		=	typeof xbes;
var xturalti	=	typeof xalti;


document.write("Veri Türü: " + xturbir + " Değer: " + xbir + "<br />");
document.write("Veri Türü: " + xturiki + " Değer: " + xiki + "<br />");
document.write("Veri Türü: " + xturuc + " Değer: " + xuc + "<br />");
document.write("Veri Türü: " + xturdort + " Değer: " + xdort + "<br />");
document.write("Veri Türü: " + xturbes + " Değer: " + xbes + "<br />");
document.write("Veri Türü: " + xturalti + " Değer: " + xalti);

// Number() 	:	Değişken içeriğini mutlak olarak number (sayı) veri türüne dönüştürerek oluşturduğu içeriği geriye döndürür.

var degerbir		=	true;
var degeriki		=	false;
var degeruc			=	new Date();
var degerdort		=	"10";
var degerbes		=	"5.55";

var turbir			=	typeof(degerbir);
var turiki			=	typeof degeriki;
var turuc			=	typeof(degeruc);
var turdort			=	typeof degerdort;
var turbes			=	typeof(degerbes);

document.write(degerbir + "<br />");
document.write(turbir + "<br /><br />");

document.write(degeriki + "<br />");
document.write(turiki + "<br /><br />");

document.write(degeruc + "<br />");
document.write(turuc + "<br /><br />");

document.write(degerdort + "<br />");
document.write(turdort + "<br /><br />");

document.write(degerbes + "<br />");
document.write(turbes + "<br /><br /><br /><br />");

var sonucbir		=	Number(degerbir);
var sonuciki		=	Number(degeriki);
var sonucuc			=	Number(degeruc);
var sonucdort		=	Number(degerdort);
var sonucbes		=	Number(degerbes);

var sonucturbir		=	typeof(sonucbir);
var sonucturiki		=	typeof sonuciki;
var sonucturuc		=	typeof(sonucuc);
var sonucturdort	=	typeof sonucdort;
var sonucturbes		=	typeof(sonucbes);

document.write(sonucbir + "<br />");
document.write(sonucturbir + "<br /><br />");

document.write(sonuciki + "<br />");
document.write(sonucturiki + "<br /><br />");

document.write(sonucuc + "<br />");
document.write(sonucturuc + "<br /><br />");

document.write(sonucdort + "<br />");
document.write(sonucturdort + "<br /><br />");

document.write(sonucbes + "<br />");
document.write(sonucturbes + "<br /><br />");

// valueOf() 	:	Üzerinde çalışılan değişken değerinin tam anlamıyla aktarımını sağlayarak yeni bir içerik oluşturur ve oluşturduğu değeri geriye döndürür.

var degerbir	=	10;
var degeriki	=	5.55;

var turdegerbir	=	typeof degerbir;
var turdegeriki	=	typeof degeriki;

document.write("Değer : " + degerbir + "<br />");
document.write("Türü : " + turdegerbir + "<br /><br />");

document.write("Değer : " + degeriki + "<br />");
document.write("Türü : " + turdegeriki + "<br /><br /><br />");

var islembir	=	degerbir.valueOf();
var islemiki	=	degeriki.valueOf();

var turislembir	=	typeof islembir;
var turislemiki	=	typeof islemiki;


document.write("Değer : " + islembir + "<br />");
document.write("Türü : " + turislembir + "<br /><br />");

document.write("Değer : " + islemiki + "<br />");
document.write("Türü : " + turislemiki);

// ceil()	:	Kendisine parametre olarak verilen değeri yukarı yuvarlayarak değeri geriye döndürür.

var degerbir	=	3.12;
var degeriki	=	56533.2344523432;
var degeruc		=	54.000000001;

var sonucbir	=	Math.ceil(degerbir);
var sonuciki	=	Math.ceil(degeriki);
var sonucuc		=	Math.ceil(degeruc);

document.write(degerbir + " = " + sonucbir + "<br />");
document.write(degeriki + " = " + sonuciki + "<br />");
document.write(degeruc + " = " + sonucuc);

// floor() 		:	Kendisine parametre olarak verilen ondalıklı sayı değerini aşağı yuvarlayarak sonucu geriye döndürür.

var bir		=	12.99;
var iki		=	65.0023487236;
var uc		=	77.000000;

var sonucbir 	=	Math.floor(bir);
var sonuciki 	=	Math.floor(iki);
var sonucuc		=	Math.floor(uc);

document.write(bir + " : " + sonucbir + "<br />");
document.write(iki + " : " + sonuciki + "<br />");
document.write(uc + " : " + sonucuc);

// round() 		:	Kendisine parametre olarak verilen herhangi bir ondalıklı sayı değerini kendisine en yakın tam sayıyı kontrol ederek aşağı veya yukarı yuvarlama yaparak sonucu geriye döndürür.
// 1,2,3 ve 4 değerlerini aşağı yuvarlar.
// 5,6,7,8 ve 9 değerlerini yukarı yuvarlar.

var degerbir	=	3.1243343432;
var degeriki	=	3.49;
var degeruc		=	3.5;
var degerdort	=	3.98;

var sonucbir	=	Math.round(degerbir);
var sonuciki	=	Math.round(degeriki);
var sonucuc		=	Math.round(degeruc);
var sonucdort	=	Math.round(degerdort);

document.write("Orjinal değer : " + degerbir + " Yuvarlama sonucu : " + sonucbir + "<br />");
document.write("Orjinal değer : " + degeriki + " Yuvarlama sonucu : " + sonuciki + "<br />");
document.write("Orjinal değer : " + degeruc + " Yuvarlama sonucu : " + sonucuc + "<br />");
document.write("Orjinal değer : " + degerdort + " Yuvarlama sonucu : " + sonucdort);

// trunc() 		:	Kendisine parametre olarak verilen herhangi bir ondalıklı sayı değerinin ondalık kısmını kaldırarak, tam sayı değerini geriye döndürür.

var degerbir	=	5.55;
var degeriki	=	88.32;
var degeruc		=	1.23423645283746;

var sonucbir	=	Math.trunc(degerbir);
var sonuciki	=	Math.trunc(degeriki);
var sonucuc		=	Math.trunc(degeruc);

document.write(degerbir + "<br />");
document.write(sonucbir + "<br /><br />");
document.write(degeriki + "<br />");
document.write(sonuciki + "<br /><br />");
document.write(degeruc + "<br />");
document.write(sonucuc);

// random() 	:	0 ile 1 arasında rastgele bir sayı üreterek, ürettiği değeri geriye döndürür.

var sonucbir	=	Math.random();
var sonuciki	=	Math.ceil(Math.random() * 1000);
var sonucuc		=	Math.floor(Math.random() * 10);
var sonucdort	=	Math.round(Math.random() * 10);
var sonucbes	=	Math.trunc(Math.random() * 10);

document.write(sonucbir + "<br />");
document.write(sonuciki + "<br />");
document.write(sonucuc + "<br />");
document.write(sonucdort + "<br />");
document.write(sonucbes);

// sign() 	:	Kendisine parametre olarak verilen herhangi bir sayı değerinin işaretini bularak sonucu geriye döndürür.

var degerbir	=	54;
var degeriki	=	-23;
var degeruc		=	0;
var degerdort	=	"Volkan";

var sonucbir	=	Math.sign(degerbir);
var sonuciki	=	Math.sign(degeriki);
var sonucuc		=	Math.sign(degeruc);
var sonucdort	=	Math.sign(degerdort);

document.write(degerbir + "<br />");
document.write(sonucbir + "<br /><br />");

document.write(degeriki + "<br />");
document.write(sonuciki + "<br /><br />");

document.write(degeruc + "<br />");
document.write(sonucuc + "<br /><br />");

document.write(degerdort + "<br />");
document.write(sonucdort);

// min() 	:	Kendisine parametre olarak verilen sayı değerlerinin en küçüğünü bularak, bulduğu değeri geriye döndür.

var sonuc		=	Math.min(5, 3, 45, 12, 6, 4);
document.write(sonuc);

// max() 	:	Kendisine parametre olarak verilen sayı değerlerinin en büyüğünü bularak, bulduğu degeri geriye döndürür.

var sonuc		=	Math.max(34, 245, 212, 153, 43);
document.write(sonuc);

// pow() 	:	Kendisine parametre olarak verilen iki sayının üssünü bularak, bulduğu değeri geriye döndürür.

var degerbir	=	2;
var degeriki	=	5;

var sonucbir	=	Math.pow(degerbir, degeriki); // 2 * 2 * 2 * 2 * 2	=	32
var sonuciki	=	Math.pow(2, 5); // 2 * 2 * 2 * 2 * 2	=	32
document.write(sonucbir + "<br />");
document.write(sonuciki);

// abs() 	:	Kendisine parametre olarak verilen herhangi bir sayı değerinin mutlak değerini bularak sonucu geriye döndürür.

var degerbir	=	144;
var degeriki	=	-144;
var sonucbir	=	Math.abs(degerbir);
var sonuciki	=	Math.abs(degeriki);

document.write(degerbir + "<br />");
document.write(sonucbir + "<br /><br />");

document.write(degeriki + "<br />");
document.write(sonuciki);

// sqrt() 		:	Kendisine parametre olarak verilen herhangi bir sayı değerinin karekökünü bularak, bulduğu değeri geriye döndürür.

var deger	=	9;
var sonuc	=	Math.sqrt(deger);
document.write(sonuc);

// cbrt() 	:	Kendisine parametre olarak verilen herhangi bir sayının küp kökünü bularak, bulduğu değeri geriye döndürür.

var deger	=	55;
var sonuc	=	Math.cbrt(deger);
document.write(sonuc);

// sin() 	:	Kendisine parametre olarak verilen herhangi bir sayı değerinin sinüsünü bularak, bulduğu değeri geriye döndürür.
// sinh() 		:	Kendisine parametre olarak verilen herhangi bir sayı değerinin hiperbolik sinüsünü bularak, bulduğu değeri geriye döndürür.
// asin() 		:	Kendisine parametre olarak verilen -1 ile 1 arasındaki sayı değerinin ark sinüsünü radyan cinsinden bularak, bulduğu değeri geriye döndürür.
// asinh() 		:	Kendisine parametre olarak verilen herhangi bir sayının değerinin hiperbolik ark sinüsünü bularak, bulduğu değeri geriye döndürür.

var deger	=	2;
var sonuc	=	Math.sin(deger);
var sonuc1	=	Math.sinh(deger);
var sonuc2	=	Math.asin(deger);
var sonuc	=	Math.asinh(deger);

document.write(sonuc);



```
