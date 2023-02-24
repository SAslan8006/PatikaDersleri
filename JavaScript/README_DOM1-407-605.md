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
