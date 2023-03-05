# Javascript Notları 

## BOM işlemleri  

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="PencereAc()">Pencere Aç</button>

<script type="text/javascript" language="javascript">
// open() 		:	Yeni browser (tarayıcı) penceresi açmak için kullanılır.
/*
1. Parametre	:	URL (Pencerenin adresi)
2. Parametre	:	Pencerenin adı
3. Parametre	:	Pencerinin özellikleri
4. Parametre	:	Pencerenin geçmiş bilgisi
*/
/*
width			:	Açılacak olan pencerenin genişliğini ayarlamak için kullanılır.
height			:	Açılacak olan pencerenin yüksekliğini ayarlamak için kullanılır.
left			:	Açılacak olan pencerenin yatay konumunu ayarlamak için kullanılır.
top				:	Açılacak olan pencerenin dikey konumunu ayarlamak için kullanılır.

BU ARAYLAR TARAYICILAR FARKLI ÇALIŞABİLİR
fullscreen		:	Açılacak olan pencerenin tam ekran modunda gösterilip gösterilmeyeceğini ayarlamak için kullanılır. (yes & no)
location		:	Açılacak olan pencerede adres çubuğunun gösterilip gösterilmeyeceğini / değiştirilebilir olup olmadığını ayarlamak için kullanılır. (yes & no)
menubar			:	Açılacak olan pencerede menü çubuğunun gösterilip gösterilmeyeceğini ayarlamak için kullanılır. (yes & no)
scrollbars		:	Açılacak olan pencerede kaydırma çubuğunun gösterilip gösterilmeyeceğini ayarlamak için kullanılır. (yes & no)
status			:	Açılacak olan pencerede durum çubuğunun gösterilip gösterilmeyeceğini ayarlamak için kullanılır. (yes & no)
toolbar			:	Açılacak olan pencerede navigasyon araç çubuğunun gösterilip gösterilmeyeceğini ayarlamak için kullanılır. (yes & no)
titlebar		:	Açılacak olan pencerede başlık çubuğunun / başlık çubuğu alanının gösterilip gösterilmeyeceğini ayarlamak için kullanılır. (yes & no)
resizable		:	Açılacak olan pencerenin boyutlanabilir olup olmadığını ayarlamak için kullanılır. (yes & no)
*/

function PencereAc(){
	var pencere		=	window.open("", "Yeni Pencere", "width=500,height=300");
	var pencere		=	window.open("", "Yeni Pencere", "width=500,height=300,left=250,top=250");
	var pencere		=	window.open("", "Yeni Pencere", "fullscreen=yes");
	var pencere		=	window.open("", "Yeni Pencere", "fullscreen=no");
	var pencere		=	window.open("", "Yeni Pencere", "location=yes");
	var pencere		=	window.open("", "Yeni Pencere", "location=no");
	var pencere		=	window.open("", "Yeni Pencere", "menubar=yes");
	var pencere		=	window.open("", "Yeni Pencere", "menubar=no");
	var pencere		=	window.open("", "Yeni Pencere", "scrollbars=no");
	var pencere		=	window.open("", "Yeni Pencere", "status=yes");
	var pencere		=	window.open("", "Yeni Pencere", "status=no");
	var pencere		=	window.open("", "Yeni Pencere", "toolbar=yes");
	var pencere		=	window.open("", "Yeni Pencere", "toolbar=no");
	var pencere		=	window.open("", "Yeni Pencere", "titlebar=yes");
	var pencere		=	window.open("", "Yeni Pencere", "titlebar=no");
	var pencere		=	window.open("", "Yeni Pencere", "resizable=yes");
	var pencere		=	window.open("", "Yeni Pencere", "resizable=no");
	var pencere		=	window.open("", "Yeni Pencere", "width=500,height=300", true);
	var pencere		=	window.open("https://www.google.com.tr", "Yeni Pencere", "width=1000,height=650", true);
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
<button onclick="ornek()">Pencere Aç</button>
<br /><br /><br />
Javascript Eğitim Seti

<script type="text/javascript" language="javascript">
// opener	:	Yeni pencereyi oluşturan pencereye belirtilecek olan referans değerini döndürür.

function ornek(){
	var pencere		=	window.open("https://www.google.com.tr", "Google", "width=1000,height=750,left=500", true);
	pencere.opener.document.write("Google Sayfası Penceresi Başarıyla Açıldı");
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
<button onclick="PencereAc()">Aç</button>
<button onclick="PencereKapat()">Kapat</button>

<script type="text/javascript" language="javascript">
// close()		:	Geçerli pencereyi kapatmak için kullanılır.

var Islem;

function PencereAc(){
	Islem	=	window.open("https://www.google.com.tr", "Google", "width=1000,height=750,left=400", true);
}

function PencereKapat(){
	Islem.close();
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
<button onclick="pencerac()">Pencere Aç</button>

<script type="text/javascript" language="javascript">
// name		:	Pencere adının referansını elde etmek etmek veya ayarlamak için kullanılır.

function pencerac(){
	var pencere		=	window.open("","","width=500,height=200",true);
	pencere.name 	=	"Yeni Pencere Adım";
	pencere.document.write("<div>Pencerenizin Adı : " + pencere.name + "</div>");
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
<div>Pencere içerisindeki çerçeve sayısı : <span id="sonuc"></span></div>
<iframe src="Sayfa1.html"></iframe>
<iframe src="Sayfa2.html"></iframe>
<iframe src="Sayfa3.html"></iframe>

<script type="text/javascript" language="javascript">
// length 		:	Pencere içerisindeki tüm çerçeveleri sayısını elde etmek için kullanılır.

var sayi	=	window.length;
document.getElementById("sonuc").innerHTML = sayi;

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
<button onclick="bir()">3. Sayfayı Ata</button>
<button onclick="iki()">4. Sayfayı Ata</button>
<br /><br />
<iframe src="Sayfa1.html"></iframe>
<iframe src="Sayfa2.html"></iframe>

<script type="text/javascript" language="javascript">
// frames 		:	Pencere içerisindeki tüm çerçevelerin nesne referansını elde etmek veya ayarlamak için kullanılır.

function bir(){
	window.frames[0].location = "Sayfa3.html";
}

function iki(){
window.frames[1].location = "Sayfa4.html";
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
<button onclick="ornek()">Tıklayınız</button>

<script type="text/javascript" language="javascript">
// parent 		:	Geçerli çerçevenin üst penceresini elde etmek veya ayarlamak için kullanılır.

function ornek(){
	parent.document.getElementById("sonuc").innerHTML = "Çerçeve içerisinden üst pencereye etki ettik";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<script type="text/javascript" language="javascript">
// stop() 		:	Pencerenin yüklenmesini durdurmak için kallanılır.
window.stop();
</script>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
Javascript Eğitim Seti
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
<button onclick="ornek()">Yazdır</button>
Volkan Alakent Javascript Eğitim Seti

<script type="text/javascript" language="javascript">
// print() 		:	Pencere içeriğini yazdırmak için kullanılır.

function ornek(){
	window.print();
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
<div>Burası Beşinci Sayfamız</div><br /><br />
<a href="BirinciSayfa.html">Birinci Sayfaya Git</a> - 
<a href="IkinciSayfa.html">İkinci Sayfaya Git</a> - 
<a href="UcuncuSayfa.html">Üçüncü Sayfaya Git</a> - 
<a href="DorduncuSayfa.html">Dördüncü Sayfaya Git</a> - 
<a href="BesinciSayfa.html">Beşinci Sayfaya Git</a><br /><br />
<button onclick="gerigit()">Geri Git</button>
<button onclick="ilerigit()">İleri Git</button>
<button onclick="ikigerigit()">2 Sayfa Geri Git</button>
<button onclick="ikiilerigit()">2 Sayfa İleri Git</button><br /><br />
<div>Geçmiş Kaydı Uzunluğu : <span id="uzunluk"></span></div>

<script type="text/javascript" language="javascript">
// history		:	Pencerenin geçmiş nesnesine erişim için kullanılır. Özellikleri sayesinde geçmiş işlemleri yapılabilir.
// length 		:	Sayfa geçmişinde sayısını bulur
// back() 		:	Sayfa geçmişinde 1 geri gider
// forward() 	:	Sayfa geçmişinde 1 ileri gider
// go() 		:	Sayfa geçmişinde belirtilen değer kadar ileri veya geri gider

var gecmissayisi	=	history.length;
document.getElementById("uzunluk").innerHTML = gecmissayisi;

function gerigit(){
	window.history.back();
}

function ilerigit(){
	window.history.forward();
}

function ikigerigit(){
	window.history.go(-2);
}

function ikiilerigit(){
	window.history.go(2);
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
<button onclick="ornek()">Renk Değiştir</button><br /><br />
<div id="metin">Javascript Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// confirm() 		:	Kullınıcı işlemlerinde onay penceresi oluşturmak için kullanılır.

function ornek(){
	var onay	=	confirm("Renk Değişimin Kabul ediyormusunuz?");
	if(onay==true){
		document.getElementById("metin").style.backgroundColor = "black";
		document.getElementById("metin").style.color = "white";
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
<button onclick="ornek()">Renk Değiştir</button><br /><br />

<script type="text/javascript" language="javascript">
// prompt() 	:	Kullanıcıdan bilgi talep etmek için girdi penceresi oluşturmak için kullanılır.

function ornek(){
	var veri	=	prompt("Merhaba sayfa arkaplan rengi (siyah, kırmızı, sarı, mavi) ne olsun?");
	if(veri=="siyah"){
		document.body.style.backgroundColor = "black";
	}else if(veri=="kırmızı"){
		document.body.style.backgroundColor = "red";
	}else if(veri=="sarı"){
		document.body.style.backgroundColor = "yellow";
	}else if(veri=="mavi"){
		document.body.style.backgroundColor = "blue";
	}else{
		ornek();
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
<button onclick="ornek()">Dönüştür</button>
<div id="metin">Volkan Alakent - Javascript Eğitim Seti</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// btoa() 		:	Pencere içerisindeki bir metnin tüm karakterlerini base64 kodlamasına dönüştürerek oluşturduğu değeri geriye döndürür.

function ornek(){
	var gercekdeger			=	document.getElementById("metin").innerHTML;
	var donusturmeislemi	=	window.btoa(encodeURIComponent(gercekdeger));
	document.getElementById("sonuc").innerHTML = donusturmeislemi;
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
<button onclick="kodla()">Dönüştür</button>
<button onclick="coz()">Çöz</button>
<br /><br />
<div id="metin">Volkan Alakent - Javascript Eğitim Seti</div>
<div id="sonuckodlanmis"></div>
<div id="sonuccozulmus"></div>

<script type="text/javascript" language="javascript">
// atob() 	:	Pencere içerisindeki herhangi bir metnin base64 kodlamasına dönüştürülmüş karakterlerini çözerek değeri geriye döndürür.

function kodla(){
	var degerbir	=	document.getElementById("metin").innerHTML;
	var sifrele		=	window.btoa(encodeURIComponent(degerbir));
	document.getElementById("sonuckodlanmis").innerHTML = sifrele;
}

function coz(){
	var degeriki	=	document.getElementById("sonuckodlanmis").innerHTML;
	var cozumle		=	decodeURIComponent(window.atob(degeriki));
	document.getElementById("sonuccozulmus").innerHTML = cozumle;
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
<button onclick="ornek()">Pencere Aç</button>

<script type="text/javascript" language="javascript">
// screenX 		:	Pencerenin bilgisayar ekranına göre yatay konum koordinatının değerini geriye döndürür.
// screenY 		:	Pencerenin bilgisayar ekranına göre dikey konum koordinatının değerini geriye döndürür.

function ornek(){
	var pencere		=	open("", "Extra Eğitim", "width=500, height=250, left=250, top=400");
	var yataykoordinatbul	=	pencere.screenX;
	var dikeykoordinatbul	=	pencere.screenY;
	pencere.document.write("Yatay Koordinat : " + yataykoordinatbul + "<br />");
	pencere.document.write("Dikey Koordinat : " + dikeykoordinatbul);
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
<button onclick="ornek()">Pencere Aç</button>

<script type="text/javascript" language="javascript">
// screenLeft	:	Pencerenin bilgisayar ekranına göre yatay konum koordinatının değerini geriye döndürür.
// screenTop	:	Pencerenin bilgisayar ekranına göre dikey konum koordinatının değerini geriye döndürür.

function ornek(){
	var penceremiz	=	open("", "Extra Eğitim", "width=300, height=100, left=50, top=75");
	var yatay	=	penceremiz.screenLeft;
	var dikey	=	penceremiz.screenTop;
	penceremiz.document.write("Yatay Koordinat : " + yatay + "<br />");
	penceremiz.document.write("Dikey Koordinat : " + dikey);
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
<div id="sonucbir"></div>
<div id="sonuciki"></div>

<script type="text/javascript" language="javascript">
// innerWidth	:	Pencere içerik alanının genişlik değerini elde etmek için kullanılır.
// innerHeight	:	Pencere içerik alanının yükseklik değerini elde etmek için kullanılır.

var genislik	=	window.innerWidth;
var yukseklik	=	window.innerHeight;

document.getElementById("sonucbir").innerHTML = "Genişlik Değeri : " + genislik;
document.getElementById("sonuciki").innerHTML = "Yükseklik Değeri : " + yukseklik;

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
<div id="bir"></div>
<div id="iki"></div>

<script type="text/javascript" language="javascript">
// outerWidth 		:	Pencerenin tüm alanının genişlik değerini elde etmek için kullanılır.
// outerHeight 		:	Pencerenin tüm alanının yükseklik değerini elde etmek için kullanılır.

var genislik	=	window.outerWidth;
var yukseklik	=	window.outerHeight;

document.getElementById("bir").innerHTML = "Pencere Genişliği : " + genislik;
document.getElementById("iki").innerHTML = "Pencere Yüksekliği : " + yukseklik;

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
<button onclick="ornek()" style="position:fixed;">Hesapla</button>
<br /><br />
<div style="background-color:#F1F1F1; width:3000px; height:3000px;"></div>

<script type="text/javascript" language="javascript">
// pageXOffset 		:	Belge içeriğinin yatay kaydırma değerini elde etmek için kullanılır.
// pageYOffset 		:	Belge içeriğinin dikey kaydırma değerini elde etmek için kullanılır.

function ornek(){
	var yataydeger	=	window.pageXOffset;
	var dikeydeger	=	window.pageYOffset;
	var sonuc		=	"Yatay Kaydırma Konumu : " + yataydeger + " , Dikey Kaydırma Konumu : " + dikeydeger;
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
<button onclick="ornek()" style="position:fixed;">Tıkla</button>
<br /><br />
<div style="background-color:#F1F1F1; width:3000px; height:3000px;"></div>

<script type="text/javascript" language="javascript">
// scrollX 		:	Belge içeriğinin yatay kaydırma değerini elde etmek için kullanılır.
// scrollY 		:	Belge içeriğinin dikey kaydırma değerini elde etmek için kullanılır.

function ornek(){
	var yataykonum	=	window.scrollX;
	var dikeykonum	=	window.scrollY;
	var sonuc	=	"Belge İçeriğinin Yatay Konum Değeri : " + yataykonum + " , Belge İçeriğinin Dikey Konum Değeri : " + dikeykonum;
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
<button onclick="pencereac()">Aç</button>
<button onclick="boyutlandir()">Yeniden Boyutlandır</button>

<script type="text/javascript" language="javascript">
// resizeBy() 	:	Pencerenin mevcut genişlik ve yükseklik değerini belirtilen pixel'lere göre yeniden boyutlandırmak için kullanılır.

var pencere;

function pencereac(){
	pencere		=	open("","Extra Eğitim", "width=1000, height=800");
}

function boyutlandir(){
	pencere.resizeBy(-100, -100);
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
<button onclick="bir()">Pencere Aç</button>
<button onclick="iki()">Boyutlandır</button>

<script type="text/javascript" language="javascript">
// resizeTo() 		:	Pencerenin mevcut genişlik ve yükseklik değerini belirtilen pixel'lere göre yeniden boyutlandırmak için kullanılır.

var pencere;

function bir(){
	pencere		=	window.open("", "Extra Eğitim", "width=500, height=500");
}

function iki(){
	pencere.resizeTo(200, 200);
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
<button onclick="bir()">Pencere Aç</button>
<button onclick="iki()">Taşı</button>

<script type="text/javascript" language="javascript">
// moveBy() 	:	Pencerenin sol üst köşe koordinatı baz alınarak bilgisayar ekranına göre belirtilen konuma taşımak için kullanılır.

var pencere;

function bir(){
	pencere 	=	window.open("", "Extra Eğitim", "width=250, height=250, top=800");
}

function iki(){
	pencere.moveBy(100, -100);
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
<button onclick="bir()">Pencere Aç</button>
<button onclick="iki()">Taşı</button>

<script type="text/javascript" language="javascript">
// moveTo() 	:	Pencerenin sol üst köşe koordinatı baz alınarak bilgisayar ekranına göre belirtilen konuma taşımak için kullanılır.

var pencere;

function bir(){
	pencere		=	window.open("", "Extra Eğitim", "width=300, height=300, left=500, top=500");
}

function iki(){
	pencere.moveTo(200, 200);
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

<body style="margin:0;">
<button onclick="kaydir()" style="position:fixed;">Kaydır</button>

<div style="width:5000px; height:5000px; background-color:red; text-align:center; color:white;">Javascript Eğitim Seti</div>


<script type="text/javascript" language="javascript">
// scrollBy() 		:	Belge içeriğini belirtilen değere göre kaydırmak için kullanılır.

function kaydir(){
	window.scrollBy(100, 100);
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
<div>Javascript Eğitim Seti</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// top 		& 		self		:	İçerisinde bulunulan pencerenin en üst seviye pencere olup olmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

if(window.top == window.self){
	document.getElementById("sonuc").innerHTML	=	"En üst seviye pencere";
}else{
	document.getElementById("sonuc").innerHTML	=	"İç pencere";
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

<body style="margin:0;">
<button onclick="ornek()" style="position:fixed;">Kaydır</button>
<div style="width:5000px; height:5000px; background-color:yellow; text-align:center;">Volkan Alakent Javascript Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// scrollTo() 		:	Belge içeriğini belirtilen değerlere göre kaydırmak için kullanılır.

function ornek(){
	window.scrollTo(1500, 0);
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
<div id="ekrangenisligialani"></div>
<div id="ekranyuksekligialani"></div>

<script type="text/javascript" language="javascript">
// width	:	Kullanıcının toplam ekran genişliği değerini elde etmek için kullanılır.
// height	:	Kullanıcının toplam ekran yüksekliği değerini elde etmek için kullanılır.

var genislikal	=	screen.width;
var yukseklikal	=	screen.height;

document.getElementById("ekrangenisligialani").innerHTML = "Ekran Genişliğiniz : " + genislikal;
document.getElementById("ekranyuksekligialani").innerHTML = "Ekran Yüksekliğiniz : " + yukseklikal;

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
// availWidth	:	Kullanıcının windows görev çubuğu hariç ekranının genişlik değerini elde etmek için kullanılır.
// availHeight	:	Kullanıcının windows görev çubuğu hariç ekranının yükseklik değerini elde etmek için kullanılır.

var genislikdegeri 		=	screen.availWidth;
var yukseklikdegeri 	=	screen.availHeight;
document.write("Görev Çubuğu Hariç Ekranın Genişliği : " + genislikdegeri + "px Görev Çubuğu Hariç Ekranın Yüksekliği : " + yukseklikdegeri + "px");

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
// colorDepth 	:	Kullanıcının ekranı için tanımlanmış olan renk derinliği / renk kalitesi değerini elde etmek için kullanılır.

var renkderinligi 	=	screen.colorDepth;
document.write("Ekran renk derinliği değeri : " + renkderinligi);

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
// pixelDepth 	:	Kullanıcının ekran çözünürlüğü için tanımlanmış olan her pixel başına düşen bit değerini elde etmek için kullanılır.

var deger	=	screen.pixelDepth;
document.write("Pixel başına düşen bit değeriniz : " + deger);

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
// appCodeName		:	Browser'ın (tarayıcının) kod adı referansını elde etmek için kullanılır.

var deger	=	navigator.appCodeName;
document.write(deger);

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
// appName		:	Browser (tarayıcı) adının referansını elde etmek için kullanılır.

var deger	=	navigator.appName;
document.write(deger);

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

