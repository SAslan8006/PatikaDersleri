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