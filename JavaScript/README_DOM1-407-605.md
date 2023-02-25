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

```

```Html

```

```Html

```

```Html

```
```Html

```

```Html

```

```Html

```

```Html

```

```Html

```

```Html

```

```Html

```

```Html

```
```Html

```

```Html

```

```Html

```

```Html

```

```Html

```
```Html

```

```Html

```

```Html

```

```Html

```

```Html

```

```Html

```

```Html

```

```Html

```
```Html

```

```Html

```

```Html

```

```Html

```

```Html

```
```Html

```

```Html

```

```Html

```

```Html

```

```Html

```