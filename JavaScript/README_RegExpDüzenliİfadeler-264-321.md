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

// rightContext 	:	Değişken içeriğinde düzenli ifade ile aranılan değerin eşleşmesi durumunda eşleşmeyi sağlayan değişken içeriği değerinin sağında kalan tüm değerleri geriye döndürür.

var metin	=	"Javascipt dünyada en yaygın olarak kullanılan bir script dilidir.";
var ifade	=	/bir/g;
ifade.test(metin);
var sonuc	=	RegExp.rightContext;
document.write(sonuc);

// replace() 	:	Kendisine verilecek olan düzenli ifadeli parametreler doğrultusunda değişken içeriğini kontrol eder ve aranan değerin eşleşmesi durumunda eşleşmeyi sağlayan değerlerin değişimin sağlayarak yeni bir içerik oluşturur ve oluşturduğu değeri geriye döndürür.

var metin	=	"Merhaba Volkan, merhaba Hakan, merhaba Onur";
document.write(metin + "<br />");
var ifade	=	new RegExp("Hakan");
var ifade	=	/Hakan/;
var ifade	=	new RegExp("(Hakan|Onur)", "g");
var ifade	=	/(Hakan|Onur)/g;
var sonuc	=	metin.replace(ifade, "Volkan");
document.write(sonuc);

// split() 		:	Kendisine parametre olarak verilen düzenli ifadeli değer doğrultusunda değişken içeriğini kontrol eder ve aranan değerin eşleşmesi durumunda eşleşmeyi sağlayan değişken içeriği değerlerini bölümleyerek yeni bir dizi oluşturur ve oluşturduğu dizi değerini geriye döndürür.

var metin	=	"Javascript Php Html Css Xml Python";
document.write(metin + "<br />");
var ifade	=	new RegExp(" ", "g");
var ifade	=	/ /g;
var ifade	=	new RegExp("\\W", "g");
var ifade	=	/\W/g;
var sonuc	=	metin.split(ifade);
var sonuc1 = metin.split(" "); 
document.write(sonuc + "<br />");
document.write(sonuc[0] + "<br />");
document.write(sonuc[1] + "<br />");
document.write(sonuc[2] + "<br />");
document.write(sonuc[3] + "<br />");
document.write(sonuc[4] + "<br />");
document.write(sonuc[5]);

// exec() 	:	Kendisine parametre olarak verilen değişken içeriğinde düzenli ifade ile aranan değerin eşleşmesi durumunda eşleşmeyi sağlayan değişken içeriği değerinden yeni bir dizi oluşturularak, oluşturduğu dizi değerini geriye döndürür.
// g ayarı kullanılacak olur ise exec() metodu her çağrıldığında lastIndex değeri otomatik olarak eşleşen değerden bir sonraki indis / index değerini alacaktır.

var metin		=	"volkan Volkan VOLKAN";
var ifade		=	new RegExp("volkan", "gi");
var ifade		=	new RegExp("volkan", "i");
var ifade		=	/volkan/i;
var ifade		=	/volkan/gi;
var sonucbir	=	ifade.exec(metin); // lastIndex değeri : 0
document.write(sonucbir + "<br />");
var sonuciki	=	ifade.exec(metin); // lastIndex değeri : 6
document.write(sonuciki + "<br />");
var sonucuc		=	ifade.exec(metin); // lastIndex değeri : 13
document.write(sonucuc + "<br />");

// toString() 	:	Düzenli ifade içeriğini string (metin) veri türünde düz bir metne dönüştürerek oluşturduğu değeri geriye döndürür.
// /Volkan/gim

var ifade	=	/Volkan/gim;
var ifade	=	new RegExp("Volkan","gim");
var sonuc	=	ifade.toString();
document.write(sonuc);

// compile() 	:	Önceden oluşturulmuş düzenli ifade içerisindeki desenin değiştirilmesini sağlar.

var metin		=	"Merhaba volkan merhaba hakan";
var ifade		=	new RegExp("Volkan", "i");
var ifade		=	/Volkan/i;
var sonucbir	=	metin.match(ifade);
document.write(sonucbir + "<br />");

ifade.compile("HAKAN", "i");
var sonuciki	=	metin.match(ifade);
document.write(sonuciki + "<br />");

// ^	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter diziliminin başlangıcı ile düzenli ifade arasında eşleşme aramak için kullanılır.

var metin	=	"Volkan Alakent Javascript eğitim seti";
var ifade	=	new RegExp("^Javascript");
var ifade	=	/^Javascript/;
var ifade	=	new RegExp("^Javascript");
var ifade	=	new RegExp("^javascript", "i");

var sonuc	=	ifade.test(metin);
document.write(sonuc);

// $	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter diziliminin sonu ile düzenli ifade arasında bir eşleşme aramak için kullanılır.

var metin	=	"Dersimizin konusu Javascript";
var ifade	=	/Javascript$/;
var ifade	=	new RegExp("javascript$", "i");
var ifade	=	new RegExp("Javascript$");
var sonuc	=	ifade.test(metin);
document.write(sonuc);

// \b 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriğinin düzenli ifadeye uygun olabilecek metin parçalarını, karakter dizilimi içerisindeki kelimelerin başında yada sonunda aramak için kullanılır.

var metin	=	"xvolkanx xvolkanx xvolkanx";
var ifade	=	new RegExp("volkan");
var ifade	=	new RegExp("\\bvolkan");
var ifade	=	new RegExp("volkan\\b");
var ifade	=	/volkan\b/;
var sonuc	=	metin.search(ifade);
document.write(sonuc);

// \B 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriğinin düzenli ifadeye uygun olabilecek metin parçalarını, karakter dizilimi içerisindeki kelimelerin içerisinde aramak için kullanılır.

var metin	=	"volkan volkan volkan";
var ifade	=	new RegExp("\\Bvolkan");
var ifade	=	/\Bvolkan/;
var sonuc	=	metin.search(ifade);
document.write(sonuc);

// ?=		:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter dizilimi içerisindeki belirtilen bir referans değerin önünde düzenli ifade ile eşleşebilecek değerleri aramak için kullanılır.

var metin	=	"Javascript dünya üzerinde ve Türkiye'de en yaygın olarak kullanılmakta olan script dilidir.";
var ifade	=	new RegExp("script(?= dünya)");
var ifade	=	/script(?= dünya)/;
var ifade	=	new RegExp("script(?= di)");
var ifade	=	/script(?= di)/;

var sonuc	=	metin.search(ifade);
document.write(sonuc);

// ?! 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter dizilimi içerisindeki belirtilen bir referans değer ile takip edilmeyen değerleri düzenli ifade ile eşleşebilecek değerleri aramak için kullanılır.

var metin	=	"Javascript Türkiye'de ve dünyada en yaygın olarak kullanılmakta olan bir script dilidir.";
var ifade	=	new RegExp("script(?! T)");
var ifade	=	/script(?! T)/;

var sonuc	=	metin.search(ifade);
document.write(sonuc);

// {x} 		:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter diziliminde bulunan değerin x defa tekrarlanmış olması gerektiğini belirtmek için kullanılır.

var metin	=	"Javascript eğitim seti";
var ifade	=	new RegExp("a{2}");
var ifade	=	new RegExp("a{2}", "i");
var ifade	=	/a{2}/i;
var ifade	=	/a{2}/;
var sonuc	=	ifade.test(metin);
document.write(sonuc);

// {x,} 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter diziliminde bulunan değerin x defa yada daha fazla tekrarlanmış olması gerektiğini belirtmek için kullanılır.

var metin		=	"Javascipt eğittttttttttttttttttttttttttttttttttttttttttttttttttttttim seti";
var ifadebir	=	new RegExp("t{3}", "g");
var ifadeiki	=	new RegExp("t{3,}", "g");
var ifadebir	=	/t{3}/g;
var ifadeiki	=	/t{3,}/g;
var ifade		=	new RegExp("t{3,}");
var ifade		=	/t{3,}/;
var sonucbir	=	metin.match(ifadebir);
var sonuciki	=	metin.match(ifadeiki);
document.write(sonucbir + "<br />");
document.write(sonuciki);

// {x,y} 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter diziliminde bulunan değerin en az x defa yada en fazla y defa tekrarlanmış olması gerektiğini belirtmek için kullanılır.

var metin	=	"Javaaaaaaaaaascipt";
var ifade	=	new RegExp("a{2,20}");
var ifade	=	/a{2,20}/;
var sonuc	=	metin.match(ifade);
document.write(sonuc);

// + 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter diziliminde bulunan değerin 1 defa yada daha fazla tekrarlanmış olması gerektiğini belirtmek için kullanılır.

var metin		=	"Javascript dilinin dosya uzantısı js jss jsss şeklinde tanımlanmaktadır.";
var ifade		=	new RegExp("js+", "g");
var ifade		=	/js+/g;
var sonuc		=	metin.match(ifade);
document.write(sonuc);

// ? 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter diziliminde bulunan değerin 0 defa yada 1 defa tekrarlanmış olması gerektiğini belirtmek için kullanılır.

var metin	=	"Javascript dilinin dosya uzantısı j js jss jsss şeklindedir.";
var ifade	=	new RegExp("js?", "gi");
var ifade	=	/js?/gi;
var sonuc	=	metin.match(ifade);
document.write(sonuc);

// () 	:	Düzenli ifadelerde grup tanımlamak için kullanılır.

var metin	=	"Volkan Alakent Html ve Javascript eğitim seti.";
var ifade	=	new RegExp("(Html|Javascript)", "g");
var ifade	=	/(Html|Javascript)/g;
var ifade	=	new RegExp("(J)(a)(v)(a)(s)(c)(r)(i)(p)(t)", "g");
var ifade	=	/(J)(a)(v)(a)(s)(c)(r)(i)(p)(t)/g;
var sonuc	=	metin.match(ifade);
document.write(sonuc);

// \ 	:	Düzenli ifadelerde ardından gelecek olan karakterin özel bir karakter olup olmadığını belirtmek için kullanılır.

var metin	=	"JavaScript eğitim seti";
var ifade	=	new RegExp("\\S","g");
var ifade	=	/\S/g;
var sonuc	=	metin.match(ifade);
document.write(sonuc);

// (?:x) 	:	Düzenli ifadelerde alt grup oluşturmak için kullanılır.

var metin	=	"Javascript";
var ifade	=	/(?:sc)/;
var ifade	=	new RegExp("(?:sc)");
var sonuc	=	metin.match(ifade);
document.write(sonuc);

// [abc] 	:	Düzenli ifade dahilinde kontrol edilecek olan değişken içeriği karakter diziliminde bulunan değerin, belirtilen karakterlerden herhangi birisi ile eşleşmesi gerektiğini belirtmek için kullanılır.

var metin	=	"Volkan Alakent Javascript eğitim seti.";
var ifade	=	new RegExp("[Javascript]", "g");
var ifade	=	/[Javascript]/g;
var ifade	=	new RegExp("[VAJğ]", "g");
var ifade	=	/[VAJğ]/g;
var sonuc	=	metin.match(ifade);
document.write(sonuc);

```
