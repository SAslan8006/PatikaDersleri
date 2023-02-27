# Javascript Notları 

## DOM işlemleri  


```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body onLoad="dugumsayisi()">
<button onclick="dugumekle()">(Düğüm) Ekle</button><button onclick="dugumsayisi()">Normalize Çalıştır</button><br /><br />
<div id="sayialani"> <span>Yeni Düğüm </span> <span>Yeni Düğüm </span> <span>Yeni Düğüm </span> <span>Yeni Düğüm </span> <span>Yeni Düğüm </span> </div>
<script type="text/javascript" language="javascript">
// normalize() 	:	Belge içerisindeki boş text node'larını (metin düğümlerini) kaldırarak bitişik node'a (düğüme) katılmasını sağlar.

function dugumekle(){
	var islembir		=	document.createTextNode("Yeni Düğüm ");
	var sonucbir		=	document.body;
	sonucbir.appendChild(islembir);
	var islembir		=	document.getElementById("sayialani");
	islembir.innerHTML 	=	sonucbir.childNodes.length;
}

function dugumsayisi(){
	document.normalize();
	var islem	=	document.body;
	var sonuc	=	document.getElementById("sayialani");
	sonuc.innerHTML 	=	islem.childNodes.length;
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
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
/*
Cookie'lerin (çerezlerin) yapısı :
1. Cookie (çerez) adı
2. Cookie (çerez) değeri
3. Cookie'nin (çerezin) yaşam süresi
4. Path (yol)

Cookie (çerez) adı = Cookie (çerez) değeri ; Cookie'nin (çerezin) yaşam süresi ; Path (yol)
*/
var zaman				=	new Date();
zaman.setMonth(zaman.getMonth() + 1);

var cerezbiradi			=	"isimsoyisim";
var cerezbirdegeri		=	"Volkan Alakent";

var cerezikiadi			=	"egitimseti";
var cerezikidegeri		=	"Javascript Eğitim Seti";

document.cookie 		=	cerezbiradi + "=" + escape(cerezbirdegeri) + ";expires=" + zaman.toGMTString();
document.cookie 		=	cerezikiadi + "=" + escape(cerezikidegeri) + ";expires=" + zaman.toGMTString();
document.cookie 		=	cerezadi + "=" + ";expires=" + zaman.toGMTString();
document.cookie 		=	cerezadi + "=" + cerezdegeri + ";expires=" + zaman.toGMTString() + ";path=/";

var cerezler			=	document.cookie;
document.getElementById("sonuc").innerHTML = unescape(cerezler);

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
<button id="birincitag" name="birinciisim" class="" onclick="ornek()">Buton</button>
<br /><br />
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// length 	:	Belge içerisindeki HTML elemanına eklenmiş olan özelliklerini sayısını elde etmek için kullanılır.

function ornek(){
	var islem	=	document.getElementsByTagName("BUTTON")[0].attributes;
	var islem	=	document.getElementById("birincitag").attributes.length;
	document.getElementById("sonucalani").innerHTML = islem;
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
.deneme{ font-size:25px; color:#FFFFFF; }
</style>
</head>

<body>
<div id="birincikimlik" name="birinciisim" style="background-color:#FF0004" class="deneme" dir="ltr">Volkan Alakent</div><br />
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// name 	:	Belge içerisindeki HTML elemanına eklenmiş olan özellik adı referansını elde etmek için kullanılır. HTML elemanının içerisindeki özellik sayısı birden fazla ise her bir özellik adı referansı döngü ile elde edilebilir.
var sonucbir	=	document.getElementById("birincikimlik").attributes[0].name;
var sonuciki	=	document.getElementById("birincikimlik").attributes[1].name;
var sonucuc		=	document.getElementById("birincikimlik").attributes[2].name;
var sonucdort	=	document.getElementById("birincikimlik").attributes[3].name;

document.getElementById("sonucalanibir").innerHTML = "Birinci özelliğin adı : " + sonucbir;
document.getElementById("sonucalaniiki").innerHTML = "İkinci özelliğin adı : " + sonuciki;
document.getElementById("sonucalaniuc").innerHTML = "Üçüncü özelliğin adı : " + sonucuc;
document.getElementById("sonucalanidort").innerHTML = "Dördüncü özelliğin adı : " + sonucdort;

var islem	=	document.getElementById("birincikimlik").attributes;
var adet	=	islem.length;
var dizi	=	[];
for(var baslangic = 0; baslangic<adet; baslangic++){
	var sonuc	=	document.getElementById("birincikimlik").attributes[baslangic].name;
	dizi[baslangic] 	=	sonuc;
}

document.getElementById("sonucalani").innerHTML = dizi;

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
.deneme{ background-color:#FFFD00; }
</style>
</head>

<body>
<div id="birincikimlik" name="birinciisim" style="border:1px solid red; margin:5px; padding:5px;" class="deneme">Volkan Alakent Javascript Eğitim Seti</div> 
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// value 	:	Belge içerisindeki HTML elemanına eklenmiş olan özellik değerinin referansını elde etmek için kullanılır. HTML elemanı içerisindeki özellik sayısı birden fazla ise her bir özellik değeri referansı döngü ile elde edilebilir.

var sonucbir	=	document.getElementById("birincikimlik").attributes[0].value;
document.getElementById("sonucalanibir").innerHTML = sonucbir;

var sonuciki	=	document.getElementById("birincikimlik").attributes[1].value;
document.getElementById("sonucalaniiki").innerHTML = sonuciki;

var sonucuc		=	document.getElementById("birincikimlik").attributes[2].value;
document.getElementById("sonucalaniuc").innerHTML = sonucuc;

var deger		=	document.getElementById("birincikimlik").attributes;
var adet		=	deger.length;
var metin		=	"";
var baslangic	=	0;
while(baslangic<adet){
	var sonuc	=	deger[baslangic].value;
	metin		+=	sonuc + "<br />";
	baslangic++;
}

document.getElementById("sonucalani").innerHTML = metin;

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
<div id="deneme" name="">Volkan Alakent Javascript Eğitim Seti</div>
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// specified 	:	Belge içerisindeki HTML elemanına herhangi bir özelliğin eklenip eklenmediği referansını boolean (mantıksal) veri türünde elde etmek için kullanılır.

var islem	=	document.getElementsByTagName("DIV")[0];
var sonuc	=	islem.getAttributeNode("name").specified;
document.getElementById("sonucalani").innerHTML = sonuc;

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
<div id="ornek" name="test" style="border:1px dotted red;">Volkan Alakent Javascript Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// getNamedItem() 	:	Belge içerisindeki HTML elemanına eklenmiş olan özellik node'u (düğümü) referansını elde etmek için kullanılır.

var islem	=	document.getElementsByTagName("DIV")[0];
var sonuc	=	islem.attributes.getNamedItem("style").value;
alert(sonuc);

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
<div>Volkan Alakent</div>

<script type="text/javascript" language="javascript">
// setNamedItem() 	:	Belge içerisindeki HTML elemanına özellik node'u (düğüme) ve değeri eklemek için kullanılır.

var islem	=	document.getElementsByTagName("DIV")[0];
var ekle	=	document.createAttribute("dir");
ekle.value 	=	"rtl";
islem.attributes.setNamedItem(ekle);

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
<div style="background-color:yellow">Javascript</div>

<script type="text/javascript" language="javascript">
// removeNamedItem() 	:	Belge içerisindeki HTML elemanına eklenmiş olan özellik node'unu (düğümünü) kaldırmak için kullanılır.

var islem	=	document.getElementsByTagName("DIV")[0];
islem.attributes.removeNamedItem("style");

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
.ornek{ color:red; border:1px solid red; background-color:yellow; }
.demo{ color:white; border:1px solid blue; background-color:green; }
</style>
</head>

<body>
<p id="kimlik" name="isim" class="ornek">Volkan Alakent Javascript Eğitim Seti</p>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// item() 	:	Belge içerisindeki HTML elemanına eklenmiş olan özellik node'u (düğümü) referansını elde etmek veya ayarlamak için kullanılır. HTML elemanı içerisindeki özellik sayısı birden fazla ise her bir özellik node' (düğümü) referansı döngü ile elde edilebilir.

var islem	=	document.getElementById("kimlik");
var adet	=	document.getElementById("kimlik").attributes.length;
var metin	=	"";
for(var baslangic = 0; baslangic<adet; baslangic++){
	var sonucadi	=	islem.attributes.item(baslangic).name;
	var sonucdegeri	=	islem.attributes.item(baslangic).value;
	var sonucmetni	=	sonucadi + " : " + sonucdegeri + ", ";
	metin	+=	sonucmetni;
}

document.getElementById("sonucalani").innerHTML = metin;

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
<div id="kimlikbir" name="isimbir">Javascript Eğitim Seti</div>
<div id="kimlikiki" name="isimiki" style="background-color:red; color:white; border:5px double blue; padding:5px; margin:5px;">Css Eğitim Seti</div>
<div id="kimlikuc" name="isimuc">Php Eğitim Seti</div>
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// style 	:	Belge içerisindeki HTML elemanına veya elemanlarına CSS (Cascading Style Sheets) (Basamaklı stil şablonları) özellikleri ve değerleri eklemek veya referansını elde etmek için kullanılır.

var referansbir		=	document.getElementById("kimlikiki").style.backgroundColor;
var referansiki		=	document.getElementById("kimlikiki").style.color;
var referansuc		=	document.getElementById("kimlikiki").style.border;
var referansdort	=	document.getElementById("kimlikiki").style.padding;
var referansbes		=	document.getElementById("kimlikiki").style.margin;

var sonuc	=	" backgroundcolor : " + referansbir + ", color : " + referansiki + ", border :  " + referansuc + ", padding : " + referansdort + ", margin : " + referansbes;
document.getElementById("sonucalani").innerHTML = sonuc;

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
<a id="baglantibir" href="https://www.google.com.tr" target="_blank">Google'a Git</a> <span id="bir"></span><br />
<a id="baglantiiki" href="https://www.yandex.com.tr" target="_blank">Yandex'e Git</a> <span id="iki"></span>

<script type="text/javascript" language="javascript">
// accessKey	:	Belge içerisindeki herhangi bir HTML elemanına atanmış olan accessKey değerini elde etmek veya ayarlamak için kullanılır.

var degerbir	=	document.getElementById("baglantibir").accessKey = "g";
var degeriki	=	document.getElementById("baglantiiki").accessKey = "y";

document.getElementById("bir").innerHTML = "Kısayol Tuşu : " + degerbir;
document.getElementById("iki").innerHTML = "Kısayol Tuşu : " + degeriki;

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
<button onclick="ornek()">Odaklan</button><br /><br />
<div id="baglanti" contenteditable="true">Javascript Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// focus() 		:	Belge içerisindeki herhangi bir HTML elemanına odaklanmak için kullanılır.

function ornek(){
	document.getElementById("baglanti").focus();
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
<button onclick="bir()">Odaklan</button>
<button onclick="iki()">Odaktan Çık</button><br /><br />
<div id="baglanti" contenteditable="true">Volkan Alakent Javascript Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// blur() 	:	Belge içerisinde odaklanılmış herhangi bir HTML elemanının odağından çıkmak için kullanılır.

function bir(){
	document.getElementById("baglanti").focus();
}

function iki(){
	document.getElementById("baglanti").blur();
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
.bir{
	color:red;
}
.iki{
	background-color:yellow;
}
.uc{
	width:300px;
	height:25px;
	padding-top:5px;
	text-align:center;
	border:1px dotted black;
}
</style>
</head>

<body>
<button onclick="ornek()">İşlem Yap</button>
<br /><br />
<div id="alan" class="bir iki uc">Javascript Eğitim Seti</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// classList 	:	Belge içerisindeki herhangi bir HTML elemanına atanmış olan class listesi isimlerini elde etmek veya ayarlamak için kullanılır.
/*
item 			:	Sınıf seçicisinin adını döndürür.
length			:	Sınıf seçicisinin sayısını döndürür.
add				:	Sınıf seçicisi ekler.
remove			:	Sınıf seçicisi kaldırır / siler.
toggle			:	Sınıf seçicisi ekler veya kaldırır.
contains		:	Sınıf seçicisi arar.
*/

function ornek(){
	var degerbir		=	document.getElementById("alan").classList.item(0);
	document.getElementById("sonuc").innerHTML = "İlgili elemanın 1. class adı : " + degerbir + "<br />";
	var degeriki		=	document.getElementById("alan").classList.item(1);
	document.getElementById("sonuc").innerHTML += "İlgili elemanın 2. class adı : " + degeriki + "<br />";
	var degeruc			=	document.getElementById("alan").classList.item(2);
	document.getElementById("sonuc").innerHTML += "İlgili elemanın 3. class adı : " + degeruc;
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
.bir{
	color:red;
}
.iki{
	background-color:yellow;
}
.uc{
	width:300px;
	height:25px;
	padding-top:5px;
	text-align:center;
	border:1px dotted black;
}
</style>
</head>

<body>
<button onclick="ornek()">İşlem Yap</button>
<br /><br />
<div id="alan" class="bir iki uc">Javascript Eğitim Seti</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// classList 	:	Belge içerisindeki herhangi bir HTML elemanına atanmış olan class listesi isimlerini elde etmek veya ayarlamak için kullanılır.
/*
item 			:	Sınıf seçicisinin adını döndürür.
length			:	Sınıf seçicisinin sayısını döndürür.
add				:	Sınıf seçicisi ekler.
remove			:	Sınıf seçicisi kaldırır / siler.
toggle			:	Sınıf seçicisi ekler veya kaldırır.
contains		:	Sınıf seçicisi arar.
*/

function ornek(){
	var deger		=	document.getElementById("alan").classList.length;
	document.getElementById("sonuc").innerHTML = "İlgili elemanın " + deger + " adet class ataması vardır.";

	document.getElementById("alan").classList.add("bir");

	document.getElementById("alan").classList.add("bir", "iki", "uc");
	document.getElementById("alan").classList.remove("bir");
	document.getElementById("alan").classList.remove("bir", "iki", "uc");
	document.getElementById("alan").classList.toggle("bir");
	document.getElementById("alan").classList.toggle("bir");

	var deger		=	document.getElementById("alan").classList.contains("iki");
	document.getElementById("sonuc").innerHTML = deger;

	var deger		=	document.getElementById("alan").classList.contains("dort");
	document.getElementById("sonuc").innerHTML = deger;
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
<div id="ornek">Javascript Eğitim Seti</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// tagName		:	Belge içerisindeki herhangi bir HTML elemanının tag (etiket) adını elde etmek için kullanılır.

var sonuc	=	document.getElementById("ornek").tagName;
document.getElementById("sonuc").innerHTML = sonuc;

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
<div id="bir">Javascript Eğitim Seti</div>
<div id="sonuca"></div>
<div id="sonucb"></div>

<script type="text/javascript" language="javascript">
// id	:	Belge içerisindeki herhangi bir HTML elemanının id değerini elde etmek veya ayarlamak için kullanılır.

var islemyap	=	document.getElementsByTagName("DIV")[0].id;
document.getElementById("sonuca").innerHTML = "İlk ID Değeri : " + islemyap;
var degistir	=	document.getElementsByTagName("DIV")[0].id = "iki";
document.getElementById("sonucb").innerHTML = "Son ID Değeri : " + degistir;

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
<div id="ornek" title="Hakan Alakent">Javascript Eğitim Seti</div>
<div id="degerbir"></div>
<div id="degeriki"></div>

<script type="text/javascript" language="javascript">
// title 	:	Belge içerisindeki herhangi bir HTML elemanının title değerini elde etmek veya ayarlamak için kullanılır.

var islembir	=	document.getElementById("ornek").title;
document.getElementById("degerbir").innerHTML = "HTML elemanının title değeri : " + islembir;

var islemiki	=	document.getElementById("ornek").title = "Volkan Alakent";
document.getElementById("degeriki").innerHTML = "HTML elemanının title değeri : " + islemiki;

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
<div id="aaa" lang="de">Javascript Eğitim Seti</div>
<div id="sonucbir"></div>
<div id="sonuciki"></div>

<script type="text/javascript" language="javascript">
// lang		:	Belge içerisindeki herhangi bir HTML elemanının lang değerini elde etmek veya ayarlamak için kullanılır.

var islembir	=	document.getElementById("aaa").lang;
document.getElementById("sonucbir").innerHTML = "HTML elemanının ilk lang değeri : " + islembir;

var islemiki	=	document.getElementById("aaa").lang = "tr";
document.getElementById("sonuciki").innerHTML = "HTML elemanının son (güncel) lang değeri : " + islemiki;

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
<div id="bir"><span id="sonucbir"></span> Javascript</div>
<div id="iki"><span id="sonuciki"></span> HTML</div>

<script type="text/javascript" language="javascript">
// tabIndex 	:	Belge içerisindeki herhangi bir HTML elemanının tabindex değerini elde etmek veya ayarlamak için kullanılır.

var degerbir	=	document.getElementById("bir").tabIndex = 1;
document.getElementById("sonucbir").innerHTML = "(" + degerbir + ")";

var degeriki	=	document.getElementById("iki").tabIndex = 2;
document.getElementById("sonuciki").innerHTML = "(" + degeriki + ")";

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
<div id="bir" contenteditable="true">Javascript Eğitim Seti</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// contentEditable 		:	Belge içerisindeki herhangi bir HTML elemanının contenteditable değerini elde etmek veya ayarlamak için kullanılır.

var deger	=	document.getElementById("bir").contentEditable = "false";
document.getElementById("sonuc").innerHTML = deger;

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
<div id="kimlik">Javascript Eğitim Seti</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// isContentEditable 	:	Belge içerisindeki herhangi bir HTML elemanının düzenlenebilir olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

var sonuc	=	document.getElementById("kimlik").isContentEditable;
if(sonuc==true){
	document.getElementById("sonuc").innerHTML	=	"İlgili HTML elemanının düzenlenebilirlik özelliği vardır.";
}else{
	document.getElementById("sonuc").innerHTML	=	"İlgili HTML elemanının düzenlenebilirlik özelliği yoktur.";
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
.bir{
	background-color:yellow;
	border:4px double black;
	width:300px;
	height:23px;
	color:blue;
	text-align:center;
	font-weight:bold;
	padding-top:3px;
}
</style>
</head>

<body>
<button onclick="ornek()">Tıklayınız</button><br /><br />
<div id="alan">Javascript Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// className 	:	Belge içerisindeki herhangi bir HTML elemanının class adını elde etmek veya ayarlamak için kullanılır.

function ornek(){
	document.getElementById("alan").className = "bir";
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
<div id="OrnekBir">Javascript Eğitim Seti</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// nodeType 		:	Belge içerisindeki herhangi bir node'un (düğümün) türünü elde etmek için kullanılır.
/*
1		ELEMENT_NODE (Eleman Düğümü)
2		ATTRIBUTE_NODE (Özellik Düğümü)
3		TEXT_NODE (Metin Düğümü)
4		CDATA_SECTION_NODE (CDATA Kesit Düğümü)
5		ENTITY_REFERANCE_NODE (Varlık Referansı Düğümü)
6		ENTITY_NODE (Varlık Düğümü)
7		PROCESSING_INSRUCTION_NODE (İşlem Yönergesi Düğümü)
8		COMMENT_NODE (Açıklama Düğümü)
9		DOCUMENT_NODE (Döküman / Belge Düğümü)
10		DOCUMENT_TYPE_NODE (Döküman / Belge Türü Düğümü)
11		DOCUMENT_FARGMENT_NODE (Döküman / Belge Parçası / Bölümü Düğümü)
12		NOTATION_NODE (Gösterim Düğümü)
*/

var dugumbul	=	document.getElementById("OrnekBir").nodeType;
if(dugumbul==1){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : ELEMENT_NODE (Eleman Düğümü)";
}else if(dugumbul==2){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : ATTRIBUTE_NODE (Özellik Düğümü)";
}else if(dugumbul==3){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : TEXT_NODE (Metin Düğümü)";
}else if(dugumbul==4){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : CDATA_SECTION_NODE (CDATA Kesit Düğümü)";
}else if(dugumbul==5){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : ENTITY_REFERANCE_NODE (Varlık Referansı Düğümü)";
}else if(dugumbul==6){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : ENTITY_NODE (Varlık Düğümü)";
}else if(dugumbul==7){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : PROCESSING_INSRUCTION_NODE (İşlem Yönergesi Düğümü)";
}else if(dugumbul==8){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : COMMENT_NODE (Açıklama Düğümü)";
}else if(dugumbul==9){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : DOCUMENT_NODE (Döküman / Belge Düğümü)";
}else if(dugumbul==10){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : DOCUMENT_TYPE_NODE (Döküman / Belge Türü Düğümü)";
}else if(dugumbul==11){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : DOCUMENT_FARGMENT_NODE (Döküman / Belge Parçası / Bölümü Düğümü)";
}else if(dugumbul==12){
	document.getElementById("sonuc").innerHTML = "Düğümün Numara Değeri : " + dugumbul + " , " + "Düğümün Açıklaması : NOTATION_NODE (Gösterim Düğümü)";
}else{
	document.getElementById("sonuc").innerHTML = "Tanımlanmayan Düğüm";
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
.ornek{
	font-weight:bold;	
}
</style>
</head>

<body>
<button onclick="deneme()">Tıklayınız</button>
<div id="OrnekBir">Volkan Alakent <span class="ornek">Javascript</span> Eğitim Seti</div> <!-- HTML Açıklama Alanı -->
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// nodeType 		:	Belge içerisindeki herhangi bir node'un (düğümün) türünü elde etmek için kullanılır.

function deneme(){
	var islem		=	document.body.childNodes;
	var metin		=	"";
	var baslangic;
	for(baslangic = 0; baslangic<islem.length; baslangic++){
		metin	=	metin + islem[baslangic].nodeType + "<br />";
	}
	document.getElementById("sonuc").innerHTML = metin;
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

<body> <!-- Deneme İçin Gizli Açıklama (HTML) -->
<p id="deneme">Javascript Eğitim Seti</p><br />
<button onclick="ornek()">Tıklayınız</button>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// nodeName		:	Belge içerisindeki herhangi bir node'un (düğümün) adını elde etmek için kullanılır.

function ornek(){
	var islemyap	=	document.body.childNodes;
	var uzunluk		=	islemyap.length;
	var metin		=	"";
	var baslangic;
	for(baslangic = 0; baslangic<uzunluk; baslangic++){
		metin 	=	metin + islemyap[baslangic].nodeName + "<br />";
	}
	document.getElementById("sonuc").innerHTML = metin;
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
<button onclick="ornek()">Tıklayınız</button><br /><br />
<div id="kimlik"><span>Javascript Eğitim Seti</span> <span>Volkan Alakent</span></div><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// childElementCount	:	Belge içerisindeki herhangi bir HTML elemanının içerdiği alt elemanlarının sayısını elde etmek için kullanılır.

function ornek(){
	var islemyap	=	document.getElementById("kimlik").childElementCount;
	document.getElementById("sonuc").innerHTML = "İlgili HTML elemanın içerisinde " + islemyap + " adet alt eleman var";
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
<button onclick="ornek()">Tıklayınız</button><br /><br />
<div id="bir"></div>
<div id="iki"><div></div></div>
<div id="uc">Volkan Alakent</div>
<div id="dort"><div>Javascript Eğitim Seti</div></div>
<br /><br />
<div id="sonucbir"></div>
<div id="sonuciki"></div>
<div id="sonucuc"></div>
<div id="sonucdort"></div>


<script type="text/javascript" language="javascript">
// hasChildNodes() 	:	Belge içerisindeki herhangi bir HTML elemanının alt node'larının (düğümlerinin) olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

function ornek(){
	var kontrolbir	=	document.getElementById("bir").hasChildNodes();
	if(kontrolbir==true){
		document.getElementById("sonucbir").innerHTML = "HTML elemanının alt node'u (düğümü) vardır."
	}else{
		document.getElementById("sonucbir").innerHTML = "HTML elemanının alt node'u (düğümü) yoktur."
	}
	
	var kontroliki	=	document.getElementById("iki").hasChildNodes();
	if(kontroliki==true){
		document.getElementById("sonuciki").innerHTML = "HTML elemanının alt node'u (düğümü) vardır."
	}else{
		document.getElementById("sonuciki").innerHTML = "HTML elemanının alt node'u (düğümü) yoktur."
	}
	
	var kontroluc	=	document.getElementById("uc").hasChildNodes();
	if(kontroluc==true){
		document.getElementById("sonucuc").innerHTML = "HTML elemanının alt node'u (düğümü) vardır."
	}else{
		document.getElementById("sonucuc").innerHTML = "HTML elemanının alt node'u (düğümü) yoktur."
	}
	
	var kontroldort	=	document.getElementById("dort").hasChildNodes();
	if(kontroldort==true){
		document.getElementById("sonucdort").innerHTML = "HTML elemanının alt node'u (düğümü) vardır."
	}else{
		document.getElementById("sonucdort").innerHTML = "HTML elemanının alt node'u (düğümü) yoktur."
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
<div id="alanimiz">
	<div>Javascript</div>
	<div>Php</div>
	<div>Css</div>
	<div>Html</div>
	<div>JQuery</div>
</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// children 	:	Belge içerisindeki herhangi bir HTML elemanının içerdiği alt elemanları elde etmek için kullanılır.

var baglan		=	document.getElementById("alanimiz").children;
document.getElementById("sonuc").innerHTML = baglan;
document.getElementById("sonuc").innerHTML = "İlgili HTML elemanının " + baglan + " adet alt (çocuk) elemanı vardır.";

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
<div id="alanimiz">
	<div>Javascript</div>
	<p>Php</p>
	<div>Css</div><br />
	<span>Html </span><br />
	<div>JQuery</div>
</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// children 	:	Belge içerisindeki herhangi bir HTML elemanının içerdiği alt elemanları elde etmek için kullanılır.

var alan			=	document.getElementById("alanimiz").children;
var alanuzunlugu	=	alan.length;
var metin			=	"";
for(var baslangic = 0; baslangic<alanuzunlugu; baslangic++){
	metin	=	metin + alan[baslangic].tagName + "<br />";
}
document.getElementById("sonuc").innerHTML = metin;

var alan	=	document.getElementById("secim").children[2].text;
document.getElementById("sonuc").innerHTML = alan;

document.getElementById("alanimiz").children[2].style.color = "red";

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

<div id="alanimiz">
	<div>Javascript</div>
	<div>Java</div>
	<div>Html</div>
	<div>Css</div>
	<div>Php</div>
</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// childNodes 		:	Belge içerisindeki herhangi bir HTML elemanının içerdiği alt node'ları (düğümleri) elde etmek için kullanılır.

var islemyap	=	document.getElementById("alanimiz").childNodes;
var uzunluk		=	islemyap.length;
var metin		=	"";
for(var baslangic = 0; baslangic<uzunluk; baslangic++){
	metin	=	metin + islemyap[baslangic].nodeName + "<br />";
}

document.getElementById("sonuc").innerHTML = metin;

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

<div id="alanimiz"><div>Javascript</div><div>Java</div><div>Html</div><div>Css</div><div>Php</div></div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// childNodes 		:	Belge içerisindeki herhangi bir HTML elemanının içerdiği alt node'ları (düğümleri) elde etmek için kullanılır.

var islemyap	=	document.getElementById("alanimiz").childNodes.length;
document.getElementById("sonuc").innerHTML = "İlgili HTML elemanın " + islemyap + " adet alt node'u (düğümü) vardır.";

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
<div id="alan">
	<p>Volkan Alakent</p>
	<p>Javascript Eğitim Seti</p>
</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// firstElementChild 	:	Belge içerisindeki herhangi bir HTML elemanının içerdiği ilk elemanı elde etmek için kullanılır.

var deger	=	document.getElementById("alan").firstElementChild;
var deger	=	document.getElementById("alan").firstElementChild.tagName;
var deger	=	document.getElementById("alan").firstElementChild.innerHTML;
document.getElementById("sonuc").innerHTML = deger;

</script>
</body>
</html>
```