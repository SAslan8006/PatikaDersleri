# Javascript Notları

## DOM işlemleri

```JS

// getElementById() 	:	Kendisine parametre olarak verilen değer doğrultusunda, belge içerisindeki belirtilen id özelliğine / niteliğine sahip elemanın referansını elde etmek için kullanılır.

<body>

<div id="ornek">Volkan Alakent</div>
<br />
<button onclick="deneme()">Buraya Tıklayınız</button>

<script type="text/javascript" language="javascript">

function deneme(){
	var sonuc	=	document.getElementById("ornek").innerHTML;
	alert(sonuc);
}

</script>
</body>

// getElementsByName() 		:	Kendisine parametre olarak verilen değer doğrultusunda, belge içerisinde belirtilen name özelliğine / niteliğine sahip tüm elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.

<body>
İlgi Alanlarınız :<br />
Alışveriş <input name="ilgialanlari" type="checkbox" value="Alışveriş" />
Eğlence <input name="ilgialanlari" type="checkbox" value="Eğlence" />
Sinema <input name="ilgialanlari" type="checkbox" value="Sinema" />
Tiyatro <input name="ilgialanlari" type="checkbox" value="Tiyatro" />
Gezi <input name="ilgialanlari" type="checkbox" value="Gezi" />
İnternet <input name="ilgialanlari" type="checkbox" value="İnternet" />
Yüzmek <input name="ilgialanlari" type="checkbox" value="Yüzmek" />
<button onclick="secmeislemi()">Hepsini Seç</button>
<button onclick="kaldirmaislemi()">Hepsini Kaldır</button>

<script type="text/javascript" language="javascript">


function secmeislemi(){
	var deger	=	document.getElementsByName("ilgialanlari");
	for(var baslangic = 0; baslangic<deger.length; baslangic++){
		deger[baslangic].checked 	=	true;
	}
}

function kaldirmaislemi(){
	var deger	=	document.getElementsByName("ilgialanlari");
	for(var baslangic = 0; baslangic<deger.length; baslangic++){
		deger[baslangic].checked 	=	false;
	}
}

</script>
</body>

// getElementsByTagName() 		:	Kendisine parametre olarak verilen değer doğrultusunda, belge içerisindeki belirtilen tag (etiket) adına sahip tüm elemanların referansını elde etmek için kullanılır. Elemanların referansı birden fazla ise her bir eleman döngü ile elde edilebilir.

<body>
<div>Volkan Alakent</div>
<p>Javascript Eğitim Seti</p>
<ul>
	<li>Html</li>
	<li>Javascript</li>
	<li>Css</li>
	<li>Php</li>
	<li>Xml</li>
</ul>
<br /><br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">

var islem	=	document.getElementsByTagName("*");
document.getElementById("sonuc").innerHTML = islem[8].innerHTML;

</script>
</body>

// getElementsByTagName() 		:	Kendisine parametre olarak verilen değer doğrultusunda, belge içerisindeki belirtilen tag (etiket) adına sahip tüm elemanların referansını elde etmek için kullanılır. Elemanların referansı birden fazla ise her bir eleman döngü ile elde edilebilir.

<body>
<div>Volkan Alakent</div>
<p>Javascript Eğitim Seti</p>
<ul>
	<li>Html</li>
	<li>Javascript</li>
	<li>Css</li>
	<li>Php</li>
	<li>Xml</li>
</ul>
<br /><br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">

var deger	=	document.getElementsByTagName("LI");
var say		=	document.getElementsByTagName("LI").length;
for(var baslangic = 0; baslangic<say; baslangic++){
	document.getElementById("sonuc").innerHTML += deger[baslangic].innerHTML + "<br />";
}
var islem	=	document.getElementsByTagName("*");
document.getElementById("sonuc").innerHTML = islem[0].innerHTML;
</script>
</body>
```
```Html
// getElementsByClassName() 	:	Kendisine parametre olarak verilen değer doğrultusunda, belge içerisindeki belirtilen class (sınıf) adına sahip tüm elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.

<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
div{ border:1px solid black; margin:5px; padding:5px; }
</style>
</head>

<body>
<div class="bicimlendirme">Javascript eğitim seti</div>
<div class="bicimlendirme">Html eğitim seti</div>
<div class="bicimlendirme">Css eğitim seti</div>
<div class="bicimlendirme">Php eğitim seti</div>
<div class="bicimlendirme">Python eğitim seti</div>
<div class="bicimlendirme">Xml eğitim seti</div>
<div class="bicimlendirme">JQuery eğitim seti</div>
<p id="islemsonucu"></p>

<script type="text/javascript" language="javascript">

var sonuc	=	document.getElementsByClassName("bicimlendirme").length;
document.getElementById("islemsonucu").innerHTML = sonuc;

var sonuc	=	document.getElementsByClassName("bicimlendirme2");
for(var baslangic = 0; baslangic<sonuc.length; baslangic++){
	sonuc[baslangic].style.backgroundColor = "#FF0000";
}
</script>
</body>
</html>

```

```Html
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<script type="text/javascript" language="javascript">
// doctype 		:	Belge döküman türü referansını elde etmek için kullanılır.

var islem	=	document.doctype.name;
document.write(islem);

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<script type="text/javascript" language="javascript">
// documentElement 		:	HTML tag'ının (etiketinin) referansını element nesnesi halinde elde etmek için kullanılır.

var islem	=	document.documentElement.nodeName;
document.write(islem);

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// implementation 	:	Belge ile ilgili DOMimplementation arayüzünden türetilmiş bir DOMimplementation nesnesi referansını boolean (mantıksal) veri türünde elde etmek için kullanılır.
// implementation	:	Uygulama
// Feature 			:	Özellik

var islem	=	document.implementation;
document.getElementById("sonucalani").innerHTML = islem.hasFeature("HTML", "1.0");

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="islemsari()">Sarı</button>
<button onclick="islemsiyah()">Siyah</button>
<button onclick="islemmavi()">Mavi</button>
<button onclick="islemkirmizi()">Kırmızı</button>
<button onclick="islemyesil()">Yeşil</button>
<button onclick="islembeyaz()">Beyaz</button>

<script type="text/javascript" language="javascript">
// body 	:	Belge içerisindeki body tag'ının (etiketinin) referansını elde etmek için kullanılır.

function islemsari(){
	document.body.style.backgroundColor = "yellow";
}

function islemsiyah(){
	document.body.style.backgroundColor = "black";
}

function islemmavi(){
	document.body.style.backgroundColor = "blue";
}

function islemkirmizi(){
	document.body.style.backgroundColor = "red";
}

function islemyesil(){
	document.body.style.backgroundColor = "green";
}

function islembeyaz(){
	document.body.style.backgroundColor = "white";
}
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head id="OrnekID">
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<script type="text/javascript" language="javascript">
// head 	:	Belge içerisindeki head tag'ının (etiketinin) referansını elde etmek için kullanılır.

var sonuc	=	document.head.id;
document.write(sonuc);

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=windows-1254">
<meta http-equiv="content-type" content="text/html; charset=iso-8859-9">
<title>Extra E�itim</title>
</head>

<body>
<script type="text/javascript" language="javascript">
// characterSet 	:	Belgenin karakter kodlamas�n�n referans�n� elde etmek i�in kullan�l�r.
// inputEncoding 	:	Belgenin karakter kodlamasının referansını elde etmek için kullanır.
// title 	:	Belge içerisindeki title tag'ının (etiketinin) referansını elde etmek için kullanılır.

// compatMode 	=	Belgenin browser (tarayıcı) tarafından hangi modda çalıştırıldığının referansını elde etmek için kullanılır.
// Backcompat 	=	Tuhaf / Rastlantı modu
// CSS1compat	=	Standart / normal mod

// documentMode 	:	Belgeyi oluşturmak için browser (tarayıcı) tarafından kullanılan modun referansını elde etmek için kullanılır. (IE)
// defaultView 		:	Belgenin window (pencere) referansını elde etmek için kullanılır.
// documentURI 		:	Belge sayfasının URI (Uniform Resource Indentifier) (nizami kaynak belirtici) adresi referansını elde etmek için kullanılır.

var islem	=	document.documentURI;
var sonuc	=	document.defaultView;
var sonuc	=	document.documentMode;
var sonuc	=	document.compatMode;
var sonuc	=	document.title;
var sonuc	=	document.inputEncoding;
var sonuc	=	document.characterSet;
document.write(sonuc);

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Yukarı Git</button>
<script type="text/javascript" language="javascript">
// location 	:	Belge URL (Uniform resource locator) (nizami kaynak bulucu) adresi referansını elde etmek ve ayarlamak için kullanılır.

var islem	=	document.location.href = "mailto:info@extraegitim.com";
document.write(islem);
// location 	:	Belge URL (Uniform resource locator) (nizami kaynak bulucu) adresi referansını elde etmek ve ayarlamak için kullanılır.

function ornek(){
	document.location.href = "#top";
}
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>

<script type="text/javascript" language="javascript">
// baseURI 		:	Belgenin mutlak URL (Uniform resource locator) (Nizami kaynak bulucu) adresi referansını elde etmek için kullanılır.
// URL 		:	Belgenin tam URL (Uniform resource locator) (Nizami kaynak bulucu) adresi referansını elde etmek için kullanılır.
// domain 		:	Belgenin domain (alan adı) referansını elde etmek için kullanılır.
// site adresi 	:	http://www.extraegitim.com/javascript-egitim-seti
// lastModified 	:	Belgenin en son güncelleme tarihinin ve saatinin referansını elde etmek için kullanılır. 12/13/2016 19:30:04
 // designMode 	:	Belgenin çalışma anında düzenlenebilir olup olmadığı referansını elde etmek için kullanılır.

var sonuc	=	document.designMode;
var sonuc	=	document.lastModified;
var sonuc	=	document.domain;
var sonuc	=	document.URL;
var sonuc	=	document.baseURI;
document.write(sonuc);

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">TIKLA</button>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// readyState 	:	Belge içeriğinin browser (tarayıcı) tarafından yüklenme durumu değeri referansını elde etmek için kullanılır.

function ornek(){
	var sonuc	=	document.readyState;
	document.getElementById("sonucalani").innerHTML = sonuc;
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
Javascript eğitim seti<br />
<script type="text/javascript" language="javascript">
// hasFocus() 	:	Belge odağının olup olmadığı referansını boolean (mantıksal) veri türünde elde etmek için kullanılır.

setInterval("ornek()", 1000);

function ornek(){
	var islem	=	document.hasFocus();
	if(document.hasFocus()){
		document.write("Sayfa odaklanıldı.<br />");
	}else{
		document.write("Sayfa odağından çıkıldı.<br />");
	}
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body onclick="aktifelemanibul()">
İsim Soyisim :
<input type="text">
<button>Kaydet</button>

<script type="text/javascript" language="javascript">
// activeElement	:	Belge içerisindeki seçili veya odaklanılmış elemanın referansını elde etmek için kullanılır.

function aktifelemanibul(){
	var sonuc	=	document.activeElement.tagName;
	alert(sonuc);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<a id="bir" name="javascript">Javascript Eğitim Seti</a><br />
<a id="iki" name="html">Html Eğitim Seti</a><br />
<a id="uc" name="css">Css Eğitim Seti</a><br />
<a id="dort" name="php">Php Eğitim Seti</a><br />
<a id="bes" name="jquery">JQuery Eğitim Seti</a><br /><br />
Çapa içerikleri : <span id="capaiceriklerialani"></span>

<script type="text/javascript" language="javascript">
// anchors 	:	Belge içerisindeki çapa tag'ına (etiketine) sahip tüm elemanların referansını elde etmek için kullanılır. Elemanların referansları birden fazla ise her bir eleman döngü ile elde edilebilir.

var sonuc		=	document.anchors;
var degerler	=	[];
for(var baslangic = 0; baslangic<sonuc.length; baslangic++){
	var islemsonucu			=	sonuc[baslangic].innerHTML;
	degerler[baslangic] 	=	islemsonucu;
}

document.getElementById("capaiceriklerialani").innerHTML = degerler;
</script>
</body>
</html>

```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<a id="birinci" href="http://www.extraegitim.com/javascript-egitim-seti">Javascript eğitim seti</a><br />
<a id="ikinci" href="http://www.extraegitim.com/css-egitim-seti">Css eğitim seti</a><br />
<a id="ucuncu" href="http://www.extraegitim.com/php-egitim-seti">Php eğitim seti</a><br />
<a id="dorduncu" href="http://www.extraegitim.com/html-egitim-seti">Html eğitim seti</a><br />
Link değeri : <span id="sonucalani"></span>

<script type="text/javascript" language="javascript">
// links	:	Belge içerisindeki tüm linklerin referansını elde etmek için kullanılır. Referanslar birden fazla ise her bir link referansı döngü ile elde edilebilir.

var islem	=	document.links.item(1).href;
var islem	=	document.links.namedItem("birinci").href;
document.getElementById("sonucalani").innerHTML = islem;

var islem		=	document.getElementsByTagName("a");
var sonuc		=	[];
var baslangic	=	0;
var uzunluk		=	islem.length;
while(baslangic<uzunluk){
	var bilgi	=	document.links[baslangic].href;
	sonuc[baslangic] 	=	bilgi;
	baslangic++;
}
document.getElementById("sonucalani").innerHTML = sonuc[2];

</script>
</body>
</html>

```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<script id="birinci" type="text/javascript" language="javascript">
document.write("Javascript");
</script>
 <br />
 Kodlama içeriği : 
<script id="ikinci" type="text/javascript" language="javascript">
// scripts		:	Belge içerisindeki script tag'ına (etiketine) sahip tüm elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.


var sonuc	=	document.scripts[0].text;
var sonuc	=	document.scripts[1].text;
var sonuc	=	document.scripts.item(0).text;
var sonuc	=	document.scripts.namedItem("ikinci").text;
var sonuc	=	document.scripts.length;
document.write(sonuc);

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<script id="birinci" type="text/javascript" language="javascript">
document.write("Javascript");
</script>
 <br />
Script İçerikleri :
<br />
<script id="ikinci" type="text/javascript" language="javascript">
// scripts		:	Belge içerisindeki script tag'ına (etiketine) sahip tüm elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.

var sonuc	=	document.scripts;
var uzunluk	=	document.scripts.length;

for(var baslangic = 0; baslangic<uzunluk; baslangic++){
	var islemsonucu		=	sonuc[baslangic].text;
	document.write(islemsonucu + "<br />");
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>

<embed id="birinci" name="birincianimasyon" src="Dosya.swf">
<embed id="ikinci" name="ikincianimasyon" src="Dosya.swf">
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// embeds 	:	Belge içerisindeki embed veya object tag'ına (etiket) sahip tüm elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.
document.embeds[0].width = 500;
document.embeds[0].height = 500;

var sonuc	=	document.embeds.length;
document.getElementById("sonucalani").innerHTML = "İçerik sayısı : " + sonuc;

var sonuc	=	document.embeds[0].src;
document.getElementById("sonucalani").innerHTML = "Src değeri : " + sonuc;

var sonuc	=	document.embeds.item(0).src;
document.getElementById("sonucalani").innerHTML = "Src değeri : " + sonuc;

var sonuc	=	document.embeds.namedItem("birinci").src;
document.getElementById("sonucalani").innerHTML = "Src değeri : " + sonuc;


</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>

<embed id="birinci" name="birincianimasyon" src="Dosya.swf">
<embed id="ikinci" name="ikincianimasyon" src="IkinciDosya.swf">
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// embeds 	:	Belge içerisindeki embed veya object tag'ına (etiket) sahip tüm elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.

var sonuc	=	document.embeds;
var uzunluk	=	document.embeds.length;
var dizi	=	[];
for(var baslangic = 0; baslangic<uzunluk; baslangic++){
	var deger	=	document.embeds[baslangic].src;
	dizi[baslangic] 	=	deger;
}

document.getElementById("sonucalani").innerHTML = "Src değerleri : " + dizi;
var sonuc	=	document.embeds;
var uzunluk	=	document.embeds.length;
for(var baslangic = 0; baslangic<uzunluk; baslangic++){
	document.embeds[baslangic].width	=	500;
	document.embeds[baslangic].height	=	500;
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<form>
Adı Soyadı : <input type="text" id="birincimetinkutusu" name="metinkutusubir" value="Volkan Alakent">
Şehir : <input type="text" id="birincisehirkutusu" name="sehirkutusubir" value="İstanbul">
<button>Kaydet</button>
</form>
<form id="birinciform" name="formbir" action="http://www.extraegitim.com?sonuc.php" target="_blank" method="post" accept-charset="utf-8" autocomplete="on" enctype="multipart/form-data" novalidate>
Adı Soyadı : <input type="text" id="birincimetinkutusu" name="metinkutusubir" value="Volkan Alakent">
Şehir : <input type="text" id="birincisehirkutusu" name="sehirkutusubir" value="İstanbul">
<input type="submit" value="Gönder">
</form>
<br /><br /><br />
<form>
Web Sitesi : <input type="text" id="birinciwebsitesikutusu" name="websitesikutusubir" value="http://www.extraegitim.com">
E-Mail Adresi : <input type="text" id="birinciemailkutusu" name="emailkutusubir" value="info@extraegitim.com">
<button>Kaydet</button>
</form>
<br /><br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// forms 	:	Belge içerisindeki form tag'ına (etiketine) sahip elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.

var sonuc 	=	document.forms.length;
document.getElementById("sonucalani").innerHTML = "Form sayısı : " + sonuc;
var sonuc 	=	document.forms[1].id;
document.getElementById("sonucalani").innerHTML = "Form idsi : " + sonuc;
var sonuc 	=	document.forms.item(0).id;
document.getElementById("sonucalani").innerHTML = "Form idsi : " + sonuc;
var sonuc 	=	document.forms.namedItem("birinciform").innerHTML;
document.getElementById("sonucalani").innerHTML = "Kopya Form :<br />" + sonuc;
var sonuc 	=	document.forms[0].id;
document.getElementById("sonucalani").innerHTML = "Form ID'si : " + sonuc;
var sonuc 	=	document.forms[0].target;
document.getElementById("sonucalani").innerHTML = "Form hedef penceresi : " + sonuc;
var sonuc 	=	document.forms[0].name;
document.getElementById("sonucalani").innerHTML = "Form Name'i : " + sonuc;
var sonuc 	=	document.forms[0].method;
document.getElementById("sonucalani").innerHTML = "Form metodu : " + sonuc;
var sonuc 	=	document.forms[0].autocomplete;
document.getElementById("sonucalani").innerHTML = "Form otomatik doldurma : " + sonuc;
var sonuc 	=	document.forms[0].enctype;
document.getElementById("sonucalani").innerHTML = "Form enctype değeri : " + sonuc;
var sonuc 	=	document.forms[0].noValidate;
document.getElementById("sonucalani").innerHTML = "Form Validate değeri : " + sonuc;

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<form id="birinciform">
Adı Soyadı : <input type="text" id="birincimetinkutusu" name="metinkutusubir" value="Volkan Alakent">
Şehir : <input type="text" id="birincisehirkutusu" name="sehirkutusubir" value="İstanbul">
<button>Kaydet</button>
</form>
<br /><br /><br />
<form id="ikinciform">
Web Sitesi : <input type="text" id="birinciwebsitesikutusu" name="websitesikutusubir" value="http://www.extraegitim.com">
E-Mail Adresi : <input type="text" id="birinciemailkutusu" name="emailkutusubir" value="info@extraegitim.com">
<button>Kaydet</button>
</form>
<br /><br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// forms 	:	Belge içerisindeki form tag'ına (etiketine) sahip elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.

var formumuz 	=	document.forms[0];
var adet 		=	document.forms[0].length;
var dizi		=	[];
for(var baslangic = 0; baslangic<adet; baslangic++){
	var deger	=	formumuz.elements[baslangic].value;
	if(deger!=""){
		dizi[baslangic] 	=	deger;
	}
}

document.getElementById("sonucalani").innerHTML = "Form Elemanları İçerikleri : " + dizi;

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<img src="Javascript_Resmi.jpg">
<img src="HTML_Resmi.jpg">
<img src="CSS_Resmi.jpg">
<div id="sonuc"></div>
<script type="text/javascript" language="javascript">
// images 	:	Belge içerisindeki img tag'ına (etiketine) sahip tüm elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.
var islem	=	document.images[0].src;
var islem	=	document.images.item(1).src;
var islem	=	document.images.namedItem("uc").src;
var islem	=	document.images.length;
document.images[0].width	=	167;
document.images[0].height	=	187;
document.getElementById("sonuc").innerHTML = "Resim sayısı : " + islem;

var adet	=	document.images.length;
var metin	=	"";
for(var baslangic = 0; baslangic<adet; baslangic++){
	var degerimiz	=	document.images[baslangic].src;
	metin	+=	degerimiz + " & ";
}


document.images[0].style.border 	=	"1px solid black";
document.images[1].style.border 	=	"1px dotted black";
document.images[2].style.border 	=	"1px solid black";

document.getElementById("sonuc").innerHTML = "Dosyalar : " + metin;
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<script type="text/javascript" language="javascript">
// plugins 		:	Browser'daki (tarayıcıdaki) tüm eklentilerin referansını elde etmek için kullanılır. Eklenti referansları birden fazla ise her bir eklenti döngü ile elde edilebilir.

var deger	=	navigator.plugins;
document.write(deger);
var deger	=	navigator.plugins.length;
document.write("Toplam Plugin sayısı : " + deger);

var deger	=	navigator.plugins.length;
for(var baslangic = 0; baslangic<deger; baslangic++){
	var sonuc	=	navigator.plugins[baslangic].name;
	document.write("Plugin adı : " + sonuc + "<br />");
}

var deger	=	navigator.plugins.length;
for(var baslangic = 0; baslangic<deger; baslangic++){
	var sonuc	=	navigator.plugins[baslangic];
	document.write("Plugin Adı : " + sonuc.name + "<br />");
	document.write("Dosya : " + sonuc.filename + "<br />");
	document.write("Açıklama : " + sonuc.description + "<br />");
	
	var plugindegeriuzunlugu	=	sonuc.length;
	for(var say = 0; say<plugindegeriuzunlugu; say++){
		var ikincideger		=	sonuc[say];
		document.write("Mime Type : " + ikincideger.type + "<br />");
		document.write("Açıklama : " + ikincideger.description + "<br />");
		document.write("Uzantı : " + ikincideger.suffixes + "<br /><br /><br />");
	}
}

var deger	=	navigator.plugins.length;
for(var baslangic = 0; baslangic<deger; baslangic++){
	var sonuc	=	navigator.plugins[baslangic];
	if(sonuc.name){
		document.write("Plugin Adı : " + sonuc.name + "<br />");
	}
	if(sonuc.filename){
		document.write("Dosya : " + sonuc.filename + "<br />");
	}
	if(sonuc.description){
		document.write("Açıklama : " + sonuc.description + "<br />");
	}
	
	var plugindegeriuzunlugu	=	sonuc.length;
	for(var say = 0; say<plugindegeriuzunlugu; say++){
		var ikincideger		=	sonuc[say];
		if(ikincideger.type){
			document.write("Mime Type : " + ikincideger.type + "<br />");
		}
		if(ikincideger.description){
			document.write("Açıklama : " + ikincideger.description + "<br />");
		}
		if(ikincideger.suffixes){
			document.write("Uzantı : " + ikincideger.suffixes + "<br />");
		}
	}
}
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.demo{ color:red; }
</style>
</head>

<body>
<h2>Javascript Eğitim Seti</h2>
Anlatan Volkan Alakent<br /><br />
<button onclick="ornek()">Uygula</button>

<script type="text/javascript" language="javascript">
// createAttribute() 	:	Belge içerisindeki istenilen bir elemana yeni bir özellik / nitelik node'u (düğümü) oluşturur ve oluşturduğu bu node'u (düğümü) bir node object (düğüm nesnesi) olarak geriye döndürür.
// setAttributeNode() 	:	createAttribute() metodu ile oluşturulan özellik node'unu (düğümünü), node object'ine (düğüm nesnesine) uygular. 

function ornek(){
	var deger		=	document.getElementsByTagName("h2")[0];
	var ozellik		=	document.createAttribute("class");
	ozellik.value 	=	"demo";
	deger.setAttributeNode(ozellik);
}
function ornek(){
	var deger		=	document.getElementById("alan");
	var ozellik		=	document.createAttribute("href");
	ozellik.value 	=	"http://www.volkanalakent.com";
	deger.setAttributeNode(ozellik);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="islem()">Ekle</button>
<div id="alan">...</div>

<script type="text/javascript" language="javascript">
// createElement() 		:	Belge içerisinde yeni bir HTML eleman node'u (düğümü) oluşturur ve oluşturduğu bu node'u (düğümü) bir node object (düğüm nesnesi) olarak geriye döndürür.
// createTextNode() 	:	createElement() metodu ile oluşturulan HTML elemanına metin node'u (düğümü) oluşturur ve oluşturduğu bu node'u (düğümü) bir node object (düğüm nesnesi) olarak geriye döndürür.
// appendChild() 		:	Bir node'u (düğümü) belirtilecek olan herhangi bir elemanın içerisine en sonda olmak üzere eklemek için kullanılır.
var sonuc	=	document.createElement("BUTTON");
var sonuc	=	document.createElement("INPUT");
document.body.appendChild(sonuc);

var sonuc	=	document.createElement("BUTTON");
var metin	=	document.createTextNode("Tıklayınız");
sonuc.appendChild(metin);
document.body.appendChild(sonuc);


function islem(){
	var sonuc	=	document.createElement("DIV");
	var metin	=	document.createTextNode("Javascript eğitim seti.");
	sonuc.appendChild(metin);
	document.getElementById("alan").appendChild(sonuc);
}
</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button id="bir" onclick="ornekbir()">Birinci Açıklama Metnini Ekle</button><button id="iki" onclick="ornekiki()">İkinci Açıklama Metnini Ekle</button>
<script type="text/javascript" language="javascript">
// createComment() 	:	Belge içerisine yeni bir açıklama node'u (düğümü) oluşturur ve oluşturduğu bu node'u (düğümü) bir node object (düğüm nesnesi) olarak geriye döndürür.
// appendChild() 	:	Bir node'u (düğümü) belirtilecek olan herhangi bir elemanın içerisine en sonda olmak üzere eklemek için kullanılır.

function ornekbir(){
	var hedef	=	document.createComment("Burası birinci açıklama metnidir.");
	document.body.appendChild(hedef);
}

function ornekiki(){
	var hedef	=	document.createComment("Burası ikinci açıklama metnidir.");
	document.body.appendChild(hedef);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// addEventListener() 	: Belgeye event (olay) işaretleyicisi / dinleyicisi eklemek için kullanılır. İşaretlenen / dinlenen event (olay) belgede gerçekleştirilecek olur ise belirtilecek olan fonksiyon veya fonksiyonlar çalışır.

document.addEventListener("mouseover", ornekbir);
document.addEventListener("click", ornekiki);
document.addEventListener("mouseout", ornekuc);
document.addEventListener("click", ornek);

function ornek(){
	document.getElementById("sonucalani").innerHTML = Math.random();
}
function ornekbir(){
	document.getElementById("sonucalani").innerHTML +=	"Mouse Over Oldu.<br />";
}

function ornekiki(){
	document.getElementById("sonucalani").innerHTML +=	"Tıklama Oldu.<br />";
}

function ornekuc(){
	document.getElementById("sonucalani").innerHTML +=	"Mouse Out Oldu.<br />";
}

document.addEventListener("mouseover", function (){
	document.getElementById("sonucalani").innerHTML = Math.random();
});
document.addEventListener("mouseout", function (){
	document.getElementById("sonucalani").innerHTML = Math.random();
});
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="sonlandir()">Olay Dinleyicisini Kaldır</button><br />
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// removeEventListener() 	:	Belgeye addEventListener() metodu ile eklenmiş olan event (olay) işaretleyicisini / dinleyicisini silmek için kullanılır.

document.addEventListener("mousemove", ornek);

function ornek(){
	document.getElementById("sonucalani").innerHTML = Math.random();
}

function sonlandir(){
	document.removeEventListener("mousemove", ornek);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="metinalani" dir="rtl">Javascript eğitim seti</div>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// dir 		:	Belge içerisindeki metinlerin yazılış yönü referansını elde etmek için kullanılır. Ayrıca belge içerisindeki metinlerin yazılış yönünün atamasını ayarlamak içinde kullanılır.
// ltr		:	left to right (soldan sağa)
// rtl		:	right to left (sağdan sola)

var islem	=	document.getElementById("metinalani").dir;
document.getElementById("sonucalani").innerHTML = islem;
document.getElementById("metinalani").dir = "ltr";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">HTML Akışı Aç</button>
<script type="text/javascript" language="javascript">
// open() 	:	Belge içerisinden yeni bir HTML çıktı akışı açmak için kullanılır.
// close() 	:	open() metodu ile açılan HTML çıktı akışını kapatmak / sonlandırmak için kullanılır.
// Parametreler :
// 1. Parametre : MimeType
// 2. Parametre : Geçmiş aktarımı

function ornek(){
	document.open();
	document.write("Burası Yeni HTML Akışı Sayfası");
	document.close();
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
body{ color:red; font-size:25px; }
p{ color:blue; }
div{ color:yellow; }
</style>
<style>
body{ font-weight:bold; }
</style>
</head>

<body>
Volkan Alakent Javascript Eğitim Seti<br />
<script type="text/javascript" language="javascript">
// styleSheets 		:	Belge üzerinde etkisi olan tüm stil sayfalarının nesne referansını elde etmek için kullanılır. Stil sayfası referansları birden fazla ise her stil sayfası referansı döngü ile elde edilebilir.

var deger	=	document.styleSheets[0].cssRules;
var sayi	=	document.styleSheets[0].cssRules.length;
var dizi	=	[];
for(var baslangic = 0; baslangic<sayi; baslangic++){
	var sonuc	=	document.styleSheets[0].cssRules[baslangic].cssText;
	dizi[baslangic] 	=	sonuc;
}

document.write(dizi);

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
body{ color:red; font-size:25px; }
p{ color:blue; }
div{ color:yellow; }
</style>
<style>
body{ font-weight:bold; }
</style>
</head>

<body>
Volkan Alakent Javascript Eğitim Seti<br />
<script type="text/javascript" language="javascript">
// styleSheets 		:	Belge üzerinde etkisi olan tüm stil sayfalarının nesne referansını elde etmek için kullanılır. Stil sayfası referansları birden fazla ise her stil sayfası referansı döngü ile elde edilebilir.

document.styleSheets[0].cssRules[0].style.backgroundColor = "yellow";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div class="birinci">Volkan Alakent</div>
<div class="ikinci">Javascript</div>
<div class="ucuncu">Php</div>
<div class="dorduncu">Css</div>
<div class="besinci">Html</div>
<br /><br />
<button onclick="ornek()">İşlemi Gerçekleştir</button>
<script type="text/javascript" language="javascript">
// querySelector() 		:	CSS (Cascading Style Sheets) (Basamaklı Stil Şablonları) seçicileri ile belgedeki bir elemanın referansını elde etmek için kullanılır.

function ornek(){
	document.querySelector("div.ikinci").style.fontSize = "35px";
	document.querySelector("#sonucalani").innerHTML = "JQuery";
	document.querySelector("div#sonucalani").innerHTML = "JQuery";
	document.querySelector("div#bir>span").style.fontSize = "35px";
	document.querySelector("div#bir>span#biriki").style.fontSize = "35px";
	document.querySelector("div#bir>a.deneme").style.fontSize = "35px";
	document.querySelector("div#bir>#biriki").style.fontSize = "35px";
	document.querySelector("div#birinci+div").style.fontSize = "35px";
	document.querySelector("div#birinci+p").style.fontSize = "35px";
	var sonuc	=	document.querySelector("div#bir>span#biriki").innerHTML;
	var sonuc	=	document.querySelector(".bir").innerHTML;
	alert(sonuc);
	document.querySelector(".ikinci").style.fontSize = "35px";
}

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div class="bir">Volkan Alakent Javascript Eğitim Seti</div>
<div class="iki">Volkan Alakent Php Eğitim Seti</div>
<div class="uc">Volkan Alakent Html Eğitim Seti</div>
<div class="dort">Volkan Alakent Css Eğitim Seti</div>
<p class="bes">Volkan Alakent JQuery Eğitim Seti</p>
<p class="alti">Volkan Alakent MySql Eğitim Seti</p>
<br />
<span id="sonucalani"></span>
<br /><br />
<button onclick="ornek()">Buton</button>

<script type="text/javascript" language="javascript">
// querySelectorAll() 	:	CSS seçicileri ile belgedeki eleman veya elemanların referansını elde etmek için kullanılır. Eleman referansları birden fazla ise her bir eleman döngü ile elde edilebilir.

function ornek(){
	var islem	=	document.querySelectorAll("div").length;
	document.getElementById("sonucalani").innerHTML = "Talep edilen Tag adedi : " + islem;
}
function ornek(){
	var islem	=	document.querySelectorAll("p").length;
	document.getElementById("sonucalani").innerHTML = "Talep edilen Tag adedi : " + islem;
}
function ornek(){
	document.querySelectorAll("div")[1].style.backgroundColor = "yellow";
}
function ornek(){
	var sonuc	=	document.querySelectorAll("div")[0].innerHTML;
	document.getElementById("sonucalani").innerHTML = sonuc;
}
function ornek(){
	var sonuc	=	document.querySelectorAll("p")[0].innerHTML;
	document.getElementById("sonucalani").innerHTML = sonuc;
}
function ornek(){
	document.querySelectorAll("p.alti")[1].style.fontSize = "25px";
}
function ornek(){
	var islem 	=	document.querySelectorAll(".deneme")[1].innerHTML;
	document.getElementById("sonucalani").innerHTML = islem;
}
function ornek(){
	var sayi	=	document.querySelectorAll(".deneme").length;
	for(var baslangic = 0; baslangic<sayi; baslangic++){
		document.querySelectorAll(".deneme")[baslangic].style.backgroundColor = "yellow";;
	}
}
function ornek(){
	var sayi	=	document.querySelectorAll(".deneme").length;
	for(var baslangic = 0; baslangic<sayi; baslangic++){
		document.querySelectorAll(".deneme")[baslangic].style.backgroundColor = "yellow";;
	}
}
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<iframe src="cerceve.html" style="width:500px; height:500px;"></iframe>
<iframe src="cerceve.html" style="width:500px; height:500px;"></iframe>
<br /><br />
<button onclick="ornek()">Test</button>
<br /><br />
<script type="text/javascript" language="javascript">
// adoptNode() 		:	Belge içerisine başka bir belgeden node (düğüm) eklemek için kullanılır. Eklenecek olan node'un (düğümün) varsa tüm alt node'larıda (düğümleride) işleme dahil edilerek ilgili tüm node'lar (düğümler) diğer belgeden kaldırılır.

function ornek(){
	var cerceve		=	document.getElementsByTagName("IFRAME")[0];
	var alan		=	cerceve.contentWindow.document.getElementsByTagName("DIV")[1];
	var sonuc		=	document.adoptNode(alan);
	document.body.appendChild(sonuc);
}

function ornek(){
	var cerceve		=	document.getElementsByTagName("IFRAME")[0];
	var alan		=	cerceve.contentWindow.document.getElementsByTagName("DIV")[0];
	var sonuc		=	document.adoptNode(alan);
	document.body.appendChild(sonuc);
}
function ornek(){
	var cerceve		=	document.getElementsByTagName("IFRAME")[0];
	var alan		=	cerceve.contentWindow.document.getElementsByTagName("DIV")[0];
	var sonuc		=	document.adoptNode(alan);
	document.body.appendChild(sonuc);
}
function ornek(){
	var cerceve		=	document.getElementsByTagName("IFRAME")[1];
	var alan		=	cerceve.contentWindow.document.getElementsByTagName("DIV")[1];
	var sonuc		=	document.adoptNode(alan);
	document.body.appendChild(sonuc);
}
</script>
</body>
</html>

<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="bir"><span id="adalani" style="color:blue;">Volkan</span> <span id="soyadalani" style="color:red;">Alakent</span></div>
<div id="iki">Javascript Eğitim Seti</div>
</body>
</html>
```

```Html

```
