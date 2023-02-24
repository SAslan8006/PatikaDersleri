# Javascript Notları 

## Tarih ve Saat işlemleri  

```JS
// Date() 	:	Kullanıldığı değişken içerisinde tarih ve saat bilgilerini depolayarak, depoladığı değeri geriye döndürür. (Tarihe etki edilebilir.)

var zaman	=	new Date();
var zaman	=	new Date(2015, 8, 14);
var zaman	=	new Date(2015, 8, 14, 20, 15, 44);
var zaman	=	new Date("July 08, 2004");
var zaman	=	new Date("July 08, 2004 14:40:32");
document.write(zaman);


var zaman		=	new Date();
document.write(zaman + "<br />");
var donustur	=	String(zaman);
document.write(donustur + "<br />");
var parcala		=	donustur.split(" ");
document.write(parcala + "<br />");
var kisagun		=	parcala[0];
document.write("Kısa Gün : " + kisagun + "<br />");
var kisaay		=	parcala[1];
document.write("Kısa Ay : " + kisaay + "<br />");
var gun			=	parcala[2];
document.write("Gün : " + gun + "<br />");
var yil			=	parcala[3];
document.write("Yıl : " + yil + "<br />");
var tamsaat		=	parcala[4];
var parcalasaat	=	tamsaat.split(":");
var saat		=	parcalasaat[0];
document.write("Saat : " + saat + "<br />");
var dakika		=	parcalasaat[1];
document.write("Dakika : " + dakika + "<br />");
var saniye		=	parcalasaat[2];
document.write("Saniye : " + saniye + "<br />");
var dilim		=	parcala[5];
document.write("Zaman Dilimi : " + dilim + "<br />");

// getFullYear() 	: 	Kullanıldığı değişken içeriğine yıl bilgisini 1000 ila 9999 arasında olmak üzeri rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.

var zaman	=	new Date();
var yil		=	zaman.getFullYear();
document.write(yil);

// getMonth() 	:	Kullanıldığı değişken içeriğine yılın ay bilgisini 0 ila 11 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür. (İlk ay Ocak ayıdır ve değeri 0'dır.)

var zaman	=	new Date();
var ay		=	zaman.getMonth();
	if(ay=="0"){
		var ayiyaz	=	"Ocak";
	}else if(ay=="1"){
		var ayiyaz	=	"Şubat";
	}else if(ay=="2"){
		var ayiyaz	=	"Mart";
	}else if(ay=="3"){
		var ayiyaz	=	"Nisan";
	}else if(ay=="4"){
		var ayiyaz	=	"Mayıs";
	}else if(ay=="5"){
		var ayiyaz	=	"Haziran";
	}else if(ay=="6"){
		var ayiyaz	=	"Temmuz";
	}else if(ay=="7"){
		var ayiyaz	=	"Ağustos";
	}else if(ay=="8"){
		var ayiyaz	=	"Eylül";
	}else if(ay=="9"){
		var ayiyaz	=	"Ekim";
	}else if(ay=="10"){
		var ayiyaz	=	"Kasım";
	}else if(ay=="11"){
		var ayiyaz	=	"Aralık";
	}else{
		var ayiyaz	=	"Hata";
	}

document.write(ayiyaz);

// getDate() 	:	Kullanıldığı değişken içeriğine ayın gün bilgisini 1 ila 31 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.

var zaman	=	new Date();
var gun		=	zaman.getDate();

document.write(gun);

// getDay() 	:	Kullanıldığı değişken içeriğine haftanın gün bilgisini 0 ila 6 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür. (Haftanın ilk günü Pazar olarak değerlendirilir ve değeri 0'dır.)

var zaman	=	new Date();
var gunumuz	=	zaman.getDay();

document.write(gunumuz);

// getHours() 	:	Kullanıldığı değişken içeriğine günün saat bilgisini 0 ila 23 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.

var zaman	=	new Date();
var saat	=	zaman.getHours();

document.write(saat);

// getMinutes() 	:	Kullanıldığı değişken içeriğine saatin dakika bilgisini 0 ila 59 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.

var zaman 	=	new Date();
var dakika	=	zaman.getMinutes();

document.write(dakika);

// getSeconds() 	:	Kullanıldığı değişken içeriğine dakikanın saniyesini 0 ila 59 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.

var zaman	=	new Date();
var saniye	=	zaman.getSeconds();

document.write(saniye);

// getMilliseconds() 	:	Kullanıldığı değişken içeriğine saniyenin milisaniye bilgisini 0 ila 999 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.

var zaman		=	new Date();
var milisaniye	=	zaman.getMilliseconds();

document.write(milisaniye);

// getUTCFullYear() 	:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait yıl bilgisini 1000 ila 9999 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.
// UTC					:	Coordinated universal time 		:		Eş güdümlü evrensel zaman

var zaman		=	new Date();
var yilimiz		=	zaman.getUTCFullYear();

document.write(yilimiz);

// getUTCMonth() 	:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait yılın ay bilgisini 0 ila 11 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür. (İlk ay Ocak ayıdır ve değeri 0'dir.)

var zaman	=	new Date();
var ayimiz	=	zaman.getUTCMonth();

document.write(ayimiz);

// getUTCDate() 	:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait ayın gün bilgisini 1 ila 31 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.

var zaman		=	new Date();
var gun			=	zaman.getUTCDate();

document.write(gun);

// getUTCDay() 		:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait haftanın gün bilgisini 0 ila 6 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür. (Haftanın ilk günü Pazar'dır ve değeri 0'dır.)
// UTC 				:	Coordinated universal time 		:	Eş güdümlü evrensel zaman

var zaman		=	new Date();
var hgunu		=	zaman.getUTCDay();

document.write(hgunu);

// getUTCHours() 	:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait günün saat bilgisini 0 ila 23 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.
// UTC 				:	Coordinated universal time 		:	Eş güdümlü evrensel zaman

var zaman		=	new Date();
var saat		=	zaman.getUTCHours();

document.write(saat);

// getUTCMinutes() 		:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait saatin dakika bilgisini 0 ila 59 arasında olmak üzere rakamsal olmak üzere depolayarak, depoladığı değeri geriye döndürür.
// UTC 					:	Coordinated universel time 		:	Eş güdümlü evrensel zaman

var zaman		=	new Date();
var dakika		=	zaman.getUTCMinutes();

document.write(dakika);

// getUTCSeconds() 		:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait dakikanın saniye bilgisini 0 ila 59 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.
// UTC 					:	Coordinated universal time 		:		Eş güdümlü evrensel zaman

var zaman		=	new Date();
var saniye		=	zaman.getUTCSeconds();

document.write(saniye);

// getUTCMilliseconds() 	:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait saniyenin milisaniye bilgisini 0 ila 999 arasında olmak üzere rakamsal olarak depolayarak, depoladığı değeri geriye döndürür.
// UTC 						:	Coordinated universel time 		: 		Eş güdümlü evrensel zaman

var zaman		=	new Date();
var milisaniye	=	zaman.getUTCMilliseconds();

document.write(milisaniye);

// setFullYear() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine yıl bilgisini 1000 ila 9999 arasında olmak üzere rakamsal olarak ayarlayarak depolayarak ve depoladığı değeri geriye döndürür. Çoklu ayarlama işlemi yapılabilir.

var zaman	=	new Date();
zaman.setFullYear(2050);
zaman.setFullYear(2050, 10);
zaman.setFullYear(2050, 10, 9);

document.write(zaman);

// setMonth() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda değişken içeriğine yılın ay bilgisini 0 ila 11 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür. (İlk ay Ocak'tır ve değeri 0'dır.) Çoklu ayarlama işlemi yapabilir. (Sıralama: Ay, Gün)

var zaman		=	new Date();
zaman.setMonth(5);
zaman.setMonth(5, 20);

document.write(zaman);

// setDate() 	: 	Kendisine parametre olarak belirtilmiş değer doğrultusunda değişken içeriğine ayın gün bilgisini 1 ila 31 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür.

var zaman		=	new Date();
zaman.setDate(12);

document.write(zaman);

// setHours() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine günün saat bilgisini 0 ila 23 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür. Çoklu ayarlama işlemi yapabilir. (Sıralama: Saat, Dakika, Saniye, Milisaniye)

var zaman		=	new Date();
zaman.setHours(18);
zaman.setHours(18, 55);
zaman.setHours(18, 55, 5);
zaman.setHours(18, 55, 5, 800);
document.write(zaman);

// setMinutes() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda değişken içeriğine saatin dakika bilgisini 0 ila 59 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür. Çoklu ayarlama işlemi yapabilir. (Sıramala: Dakika, Saniye, Milisaniye)

var zaman 	=	new Date();
zaman.setMinutes(40);
zaman.setMinutes(40, 1);
zaman.setMinutes(40, 1, 700);

document.write(zaman);

// setSeconds() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda değişken içeriğine dakikanın saniye bilgisini 0 ila 59 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür. Çoklu ayarlama işlemi yapabilir. (Sıralama: Saniye, Milisaniye)

var zaman 	=	new Date();
zaman.setSeconds(30);
zaman.setSeconds(30, 300);

document.write(zaman);

// setMilliseconds() 		:	Kendisine parametre olarak belirtilmiş değer doğrultusunda saniyenin milisaniye bilgisini 0 ila 999 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür.

var zaman		=	new Date();
zaman.setMilliseconds(600);

document.write(zaman);

// setUTCFullYear() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine evrensel zaman dilimine ait yıl bilgisini 1000 ila 9999 arasında olmak üzere rakamsal olarak ayarlayarak depoler ve depoladığı değeri geriye döndürür. Çoklu ayarlama işlemleri yapabilir. (Sıralama : Yıl, Ay, Gün)
// UTC 					:	Coordinated universal time 		:		Eş güdümlü evrensel zaman

var zaman	=	new Date();
zaman.setUTCFullYear(3050);
zaman.setUTCFullYear(3050, 6);
zaman.setUTCFullYear(3050, 6, 24);

document.write(zaman);

// setUTCMonth() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine evrensel zaman dilimine ait yılın ay bilgisini 0 ila 11 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür. (İlk ay Ocak ayıdır ve değeri 0'dır.) Çoklu ayarlama işlemi yapabilir. (Sıralama: Ay, Gün)

var zaman	=	new Date();
zaman.setUTCMonth(9);
zaman.setUTCMonth(9, 29);

document.write(zaman);

// setUTCDate() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine evrensel zaman dilimine ait ayın gün bilgisini 1 ila 31 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür.

var zaman	=	new Date();
zaman.setUTCDate(8);

document.write(zaman);

// setUTCHours() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine evrensel zaman dilimine ait günün saat bilgisini 0 ila 23 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür. Çoklu ayarlama işlemi yapabilir. (Sıralama : Saat, Dakika, Saniye, Milisaniye)
// UTC 				:	Coordinated universal time 		:		Eş güdümlü evrensel zaman

var zaman		=	new Date();
zaman.setUTCHours(15);
zaman.setUTCHours(15, 20);
zaman.setUTCHours(15, 20, 10);
zaman.setUTCHours(15, 20, 10, 500);

document.write(zaman);

// setUTCMinutes() 		:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine evrensel zaman dilimine ait saatin dakikasını 0 ila 59 arasında olmak üzere rakamsal olarak ayarlayarak depolayarlayarak depolar ve depoladığı değeri geriye döndürür. Çoklu ayarlama işlemi yapabilir. (Sıralama: Dakika, Saniye, Milisaniye)
// UTC 					:	Coordinated universal time 		:		Eş güdümlü evrensel zaman

var zaman	=	new Date();
zaman.setUTCMinutes(30, 59);
zaman.setUTCMinutes(30);
zaman.setUTCMinutes(30, 59, 350);

document.write(zaman);

// setUTCSeconds() 		:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine evrensel zaman dilimine ait dakikanın saniye bilgisini 0 ila 59 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndür. Çoklu ayarlama işlemi yapabilir. (Sıralama: Saniye, Milisaniye)
// UTC 					:	Coordinated universal time 		:		Eş güdümlü evrensel zaman

var zaman 		=	new Date();
zaman.setUTCSeconds(55);
zaman.setUTCSeconds(55, 750);

document.write(zaman);

// setUTCMilliseconds() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda değişken içeriğine evrensel zaman dilimine ait saniyenin milisaniye bilgisini 0 ila 999 arasında olmak üzere rakamsal olarak ayarlayarak depolar ve depoladığı değeri geriye döndürür.
// UTC 						:	Coordinated universal time 		:		Eş güdümlü evrensel zaman

var zaman		=	new Date();
zaman.setUTCMilliseconds(500);

document.write(zaman);

// getTime() 	:	Kullanıldığı değişken içeriğine tarihin zaman damgası bilgisini depolayarak, depoladığı değeri geriye döndürür. Zaman damgası başlangıç tarihi : 1 Ocak 1970

var zaman 		=	new Date();
document.write(zaman + "<br />");

var damga		=	zaman.getTime();
document.write(damga);

// setTime() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine zaman damgasına ait tarihin bilgisini depolayarak, depoladığı değeri geriye döndürür. (Zaman damgası başlangıç tarihi : 1 Ocak 1970)

var zaman 			=	new Date();
document.write(zaman + "<br />");

zaman.setTime(1480926330147);
zaman.setTime(-2480926330147);
var zamandamgasi	=	zaman.getTime();
document.write(zamandamgasi);

// now() 	:	Kullanıldığı değişken içeriğine evrensel zaman dilimine ait tarihin zaman damgası bilgisini depolayarak, depoladığı değeri geriye döndürür. Zaman damgası başlangıç tarihi 1 Ocak 1970'dir.
// UTC 		:	Coordinated universal time 		:	Eş güdümlü evrensel zaman

var zaman 	=	Date.now();
document.write(zaman);


var xzaman 	=	Date.now();
document.write(xzaman + "<br /><br />");

var zaman 			=	new Date();
var zamandamgasi	=	zaman.getTime();
document.write(zamandamgasi);

// UTC() 	:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine evrensel zaman dilimine ait tarihin zaman damgası bilgisini depolayarak, depoladığı değeri geriye döndürür. Zaman damgası başlangıç tarihi 1 Ocak 1970'dir.
// UTC		:	Coordinated universal time 		:	Eş güdümlü evrensel zaman
// Parametre Sıralaması	:	Yıl, Ay, Gün, Opsiyonel : Saat, Dakika, Saniye, Milisaniye

var zamandamgasi	=	Date.UTC(2010, 10, 24);
var zamandamgasi	=	Date.UTC(2010, 10, 24, 14, 22, 45, 350);
document.write(zamandamgasi);

// parse() 		:	Kendisine parametre olarak belirtilmiş değer doğrultusunda kullanıldığı değişken içeriğine tarihin zaman damgası başlangıcı ile arasındaki zaman farkı bilgisini depolayarak, depoladığı değeri geriye döndürür. Zaman damgası başlangıç tarihi 1 Ocak 1970'dir.
// Parametre sıralaması : Ay (İngilizce) Gün, Yıl

var fark	=	Date.parse("July 5, 1975");
document.write(fark);

// getTimezoneOffset() 		:	Kullanıldığı değişken içeriğine yerel zaman ile 0 zaman dilimi arasındaki zaman farkı bilgisini dakika olarak depolayarak, depoladığı değeri geriye döndürür.
// GMT : Greenwich mean time : Greenwich ortalama zamanı

var zaman 	=	new Date();
var fark	=	zaman.getTimezoneOffset();

document.write(fark);

// toString() 	:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerini alarak string (metin) veri türünde düz bir metne dönüştürerek, dönüştürdüğü değeri geriye döndürür.

var zaman			=	new Date();
var zamanturu		=	typeof zaman;
document.write(zamanturu + " " + zaman + "<br />");

var donustur		=	zaman.toString();
var donusturturu	=	typeof donustur;
document.write(donusturturu + " " + donustur);

// toLocaleString() 	:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerini tarayıcı lokasyonuna / diline göre alarak string (metin) veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür. 23.02.2023 20:28:41

var zaman			=	new Date();
var zamanturu		=	typeof zaman;
document.write(zamanturu + "<br />");
document.write(zaman + "<br /><br />");

var yenizaman		=	zaman.toLocaleString();
var yenizamanturu	=	typeof yenizaman;
document.write(yenizamanturu + "<br />");
document.write(yenizaman);

// toUTCString() 	:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerini evrensel zaman diliminde alarak string veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.
// UTC 				:	Coordinated universal time 		:		Eş güdümlü evrensel zaman

var zaman			=	new Date();
var zamantur		=	typeof(zaman);
document.write(zamantur + "<br />");
document.write(zaman + "<br />");

var islemyap		=	zaman.toUTCString();
var islemyaptur		=	typeof(islemyap);
document.write(islemyaptur + "<br />");
document.write(islemyap);

// toISOString() 	:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerini ISO standartını kullanarak string (metin) veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.
// ISO				: 	International standarts organization 		:	Uluslararası standartlar organizasyonu

var zaman			=	new Date();
var zamanyapisi		=	typeof zaman;
document.write(zamanyapisi + "<br />");
document.write(zaman + "<br /><br />");

var islemyap		=	zaman.toISOString();
var islemyapyapisi	=	typeof islemyap;
document.write(islemyapyapisi + "<br />");
document.write(islemyap);

// toJSON() 	:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerini JSON formatını kullanarak string veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.
// JSON			:	Javascript object notation		:	Javascript nesne gösterimi

var zaman 		=	new Date();
var zamanturu	=	typeof zaman;
document.write(zamanturu + "<br />");
document.write(zaman + "<br />");

var islem		=	zaman.toJSON();
var islemturu	=	typeof islem;
document.write(islemturu + "<br />");
document.write(islem);

// toDateString() 		:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerinin sadece tarih kısmını alarak string (metin) veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.

var zaman		=	new Date();
var zamanturu	=	typeof zaman;
document.write(zamanturu + "<br />");
document.write(zaman + "<br />");

var tarih		=	zaman.toDateString();
var tarihturu	=	typeof tarih;
document.write(tarihturu + "<br />");
document.write(tarih);

// toLocaleDateString() 	:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerinin tarayıcı lokasyonuna / diline göre sadece tarih kısmını alarak string veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.

var zaman		=	new Date();
var zamantur	=	typeof zaman;
document.write(zamantur + " " + zaman + "<br />");

var xzaman		=	zaman.toLocaleDateString();
var xzamantur	=	typeof xzaman;
document.write(xzamantur + " " + xzaman);

string

// toTimeString() 		:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerinin sadece saat kısmını alarak string veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.

var zaman			=	new Date();
var zamanvtur		=	typeof zaman;
document.write(zamanvtur + "<br />");
document.write(zaman + "<br /><br />");

var sonuc			=	zaman.toTimeString();
var sonucvtur		=	typeof sonuc;
document.write(sonucvtur + "<br />");
document.write(sonuc);

// toLocaleTimeString() 	:	Kullanıldığı değişken içeriğine atanmış olan tarih ve saat bilgilerinin tarayıcı lokasyonuna / diline göre sadece saat kısmını alarak string (metin) veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.

var zaman 			=	new Date();
var zamanvtur		=	typeof zaman;
document.write(zamanvtur + "<br />");
document.write(zaman + "<br /><br />");

var xzaman 			=	zaman.toLocaleTimeString();
var xzamanvtur		=	typeof xzaman;
document.write(xzamanvtur + "<br />");
document.write(xzaman);

// valueOf() 	:	Üzerinde çalışılan değişken değerinin tam anlamıyla aktarımını sağlayarak yeni bir içerik oluşturur ve oluşturduğu değeri geriye döndürür.

var zaman		=	new Date();
var zamantur	=	typeof zaman;
document.write(zamantur + "<br />");
document.write(zaman + "<br /><br />");

var sonuc		=	zaman.valueOf();
var sonuctur	=	typeof sonuc;
document.write(sonuctur + "<br />");
document.write(sonuc);

```
