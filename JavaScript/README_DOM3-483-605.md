# Javascript Notları 

## DOM işlemleri  

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<ul id="alan"><li>Volkan Alakent</li>
	<li>Javascript Eğitim Seti</li>
</ul>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// firstChild		:	Belge içerisindeki herhangi bir HTML elemanının içerdiği ilk alt node'u (düğümü) elde etmek için kullanılır.
var deger	=	document.getElementById("alan").firstChild;
var deger	=	document.getElementById("alan").firstChild.nodeName;
var deger	=	document.getElementById("alan").firstChild.nodeName;
var deger	=	document.getElementById("alan").firstChild.innerHTML;
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
<div id="alan">
	<div>Javascript</div>
	<div>Css</div>
	<div>Html</div>
	<div>Php</div>
	<div>Python</div>
</div><br />

<script type="text/javascript" language="javascript">
// lastElementChild 	:	Belge içerisindeki herhangi bir HTML elemanının içerdiği son elemanı elde etmek için kullanılır.
var deger	=	document.getElementById("alan").lastElementChild;
var deger	=	document.getElementById("alan").lastElementChild.tagName;
var deger	=	document.getElementById("alan").lastElementChild.innerHTML;
document.getElementById("sonuc").innerHTML = deger;
document.getElementById("alan").lastElementChild.style.color = "blue";

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
<div id="kimlik"><div>Volkan Alakent</div><div>Javascript</div><div>Eğitim Seti</div><!-- Gizli Açıklama --></div><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// lastChild	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki son alt node'u (düğümü) elde etmek için kullanılır.
var deger	=	document.getElementById("kimlik").lastChild;
var deger	=	document.getElementById("kimlik").lastChild.nodeName;
var deger	=	document.getElementById("kimlik").lastChild.innerHTML;
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
<div>
	<p id="bir">Javascript</p>
    <div id="iki">PHP</div>
	<p id="uc">HTML</p>
    <div id="dort">JQuery</div>
	<p id="bes">CSS</p>
</div><br /><br /><br />
<div id="sonuc"></div>


<script type="text/javascript" language="javascript">
// nextElementSibling 	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki aynı seviyede yani kardeş olan elemanlardan, belirtilecek olan elemandan sonra gelen ilk elemanı elde etmek için kullanılır.

var deger	=	document.getElementById("bir").nextElementSibling;
var deger	=	document.getElementById("dort").nextElementSibling;
var deger	=	document.getElementById("uc").nextElementSibling.innerHTML;
var deger	=	document.getElementById("uc").nextElementSibling.tagName;
var deger	=	document.getElementById("uc").nextElementSibling.id;
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
<div>
	<p id="birincieleman">Javascript</p>
    <div id="ikincieleman">PHP</div>
	<p id="ucuncueleman">CSS</p>
    <div id="dorduncueleman">HTML</div>
	<p id="besincieleman">JQuery</p>
    <div id="altincieleman">XML</div>
</div>
<br /><br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// nextSibling	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki aynı seviyede yani kardeş olan node'lardan (düğümlerden), belirtilecek olan node'dan (düğümden) sonra gelen ilk node'u (düğümü) elde etmek için kullanılır.

var sonuc	=	document.getElementById("ucuncueleman").nextSibling;
var sonuc	=	document.getElementById("ucuncueleman").nextSibling.tagName;
var sonuc	=	document.getElementById("ucuncueleman").nextSibling.id;
document.getElementById("sonucalani").innerHTML = sonuc;
document.getElementById("ucuncueleman").nextSibling.style.color = "red";

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
<div>
	<div id="aaa">Javascript</div>
    <p id="bbb">Php</p>
	<div id="ccc">Html</div>
    <p id="ddd">Css</p>
	<div id="eee">Jquery</div>
    <p id="fff">Xml</p>
	<div id="ggg">Python</div>
</div>
<br /><br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// previousElementSibling 	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki aynı seviyede yani kardeş olan elemanlardan, belirtilecek olan elemandan önce gelen ilk elemanı elde etmek için kullanılır.
var sonuc	=	document.getElementById("ccc").previousElementSibling;
var sonuc	=	document.getElementById("ddd").previousElementSibling.tagName;

var sonuc	=	document.getElementById("ddd").previousElementSibling.id;
document.getElementById("sonuc").innerHTML = sonuc;
document.getElementById("ddd").previousElementSibling.style.backgroundColor = "grey";
document.getElementById("ddd").previousElementSibling.style.color = "white";
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
<ol><li id="bir">Javascript</li><li id="iki">Css</li><li id="uc">Html</li><li id="dort">Php</li><li id="bes">Xml</li></ol>
<br /><br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// previousSibling	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki aynı seviyede yani kardeş olan node'lardan (düğümlerden), belirtilecek olan node'dan (düğümden) önce gelen ilk node'u (düğümü) elde etmek için kullanılır.

var sonuc	=	document.getElementById("uc").previousSibling;
var sonuc	=	document.getElementById("uc").previousSibling.nodeName;
var sonuc	=	document.getElementById("uc").previousSibling.nodeName;
var sonuc	=	document.getElementById("uc").previousSibling.innerHTML;
document.getElementById("sonucalani").innerHTML = sonuc;
document.getElementById("uc").previousSibling.style.fontWeight = "bold";
document.getElementById("uc").previousSibling.style.color = "blue";


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
<div id="deneme"><span id="yazilimdili"><b id="kalinlastir">Java</b>script</span> Eğitim Seti</div>
<br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// offsetParent 	:	Belge içerisindeki herhangi bir HTML elemanının içerisinde mutlak olarak konumlandırıldığı ilk elemanın referans nesnesini elde etmek için kullanılır.

var bul	=	document.getElementById("kalinlastir").offsetParent;
document.getElementById("sonucalani").innerHTML = bul;

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
	<p id="bir">Javascript Eğitim Seti</p>
	<p id="iki">Php Eğitim Seti</p>
</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// contains() 	:	Belge içerisindeki herhangi bir node'un (düğümün), başka bir node'un (düğümün) alt node'u düğümü olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

var kontrol		=	document.getElementById("alan");
var islemyap	=	document.getElementById("bir").contains(kontrol);
var kontrol		=	document.getElementById("bir");
var islemyap	=	document.getElementById("alan").contains(kontrol);
document.getElementById("sonuc").innerHTML = islemyap;

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