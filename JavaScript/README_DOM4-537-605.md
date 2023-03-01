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
<input type="text" onkeyup="ornek()">
<div id="sonuc"></div>
<script type="text/javascript" language="javascript">
// keyCode 	:	Belge içerisindeki onkeypress, onkeydown veya onkeyup event'ı (olayı) gerçekleştiğinde klavyeden basılan tuşun unicode (evrensel kod) kodlamasına dönüştürerek oluşturduğu değeri geriye döndürür.

function ornek(){
	var deger	=	event.keyCode;
	document.getElementById("sonuc").innerHTML += deger + " ";
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
<input type="text" onkeyup="ornek()">
<div id="sonuc"></div>
<script type="text/javascript" language="javascript">
// which 	:	Belge içerisindeki onkeypress, onkeydown veya onkeyup event'ı (olayı) gerçekleştiğinde klavyeden basılan tuşun unicode (evrensel kod) kodlamasına dönüştürerek oluşturduğu değeri geriye döndürür.

function ornek(){
	var deger	=	event.which;
	document.getElementById("sonuc").innerHTML += deger + " ";
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
<input type="text" onkeydown="ornek()">
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// location 	:	Belge içerisindeki onkeydown veya onkeyup event'ı (olayı) gerçekleştiğinde ilgili tuşun klavyedeki lokasyon / konum bilgisi değerini geriye döndürür.
/*
0	:	Standart Tuşlar
1	:	Sol Tuşlar
2	:	Sağ Tuşlar
3	:	NumPad Tuşları
*/

function ornek(){
	var sonuc	=	event.location;
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
<input type="text" onkeydown="ornek()">
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// altKey	:	Belge içerisindeki herhangi bir event (olay) tetiklenirken alt tuşuna basılıp basılmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

function ornek(){
	var deger	=	event.altKey;
	if(deger==true){
		document.getElementById("sonucalani").innerHTML = "Olay tetiklenirken alt tuşuna basıldı.";
	}else{
		document.getElementById("sonucalani").innerHTML = "Olay tetiklenirken alt tuşuna basılmadı.";
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
<textarea onkeydown="ornek()"></textarea>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// ctrlKey	:	Belge içerisindeki herhangi bir event (olay) tetiklenirken ctrl tuşuna basılıp basılmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

function ornek(){
	var deger	=	event.ctrlKey;
	if(deger==true){
		document.getElementById("sonucalani").innerHTML = deger;
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
<div onmousedown="ornek()">Volkan Alakent Javascript Eğitim Seti</div>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// shiftKey 	:	Belge içerisindeki herhangi bir event (olay) tetiklenirken shift tuşuna basılıp basılmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

function ornek(){
	var deger	=	event.shiftKey;
	if(deger==true){
		document.getElementById("sonucalani").innerHTML = "Shift tuşuna basılıyor.";
	}else{
		document.getElementById("sonucalani").innerHTML = "Shift tuşuna basılmadı.";
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
<div onmousedown="deneme()">İçerik</div>

<script type="text/javascript" language="javascript">
// metaKey	:	Belge içerisindeki herhangi bir event (olay) tetiklenirken pencere tuşuna (windows) veya emir tuşuna (apple) basılıp basılmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

function deneme(){
	var kontrol		=	event.metaKey;
	if(kontrol==true){
		alert("metaKey tuşuna basıldı");
	}else{
		alert("metaKey tuşuna basılmadı");
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

<body onload="ornek()">

<script type="text/javascript" language="javascript">
// onload	:	Sayfanın veya herhangi bir HTML elemanının yüklenmesi tamamlandığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Sayfa Tamamen Yüklendi");
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

<body onunload="ornek()">

<script type="text/javascript" language="javascript">
// onunload		:	Sayfanın veya herhangi bir HTML elemanının kapatıldığında veya kaldırıldığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Sayfa Kapatıldı / Yenilendi")
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

<body onbeforeunload="return ornek()">
<a href="https://www.google.com.tr">Google'a Git</a>

<script type="text/javascript" language="javascript">
// onbeforeunload	:	Sayfanın kullanıcı tarafından yenileme ve kapatma isteklerinde işlem gerçekleştirilmeden belirtilecek olan fonksiyon çalışır.

function ornek(){
	return " ";
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

<body onhashchange="ornekiki()">
<button onclick="ornek()">Tıkla</button>
<div id="sonucalani"></div>
<div id="sonucalaniiki"></div>

<script type="text/javascript" language="javascript">
// onhashchange 	:	Sayfa URL'inin (Uniform resource locator) (nizami kaynak bulucu) bağlantı bölümünde değişiklik olur ise belirtilecek fonksiyon çalışır.

function ornek(){
	location.hash 	=	"OrnekSayfa";
	var deger		=	location.hash;
	document.getElementById("sonucalani").innerHTML = "Hash değeri değişti : " + deger;
}

function ornekiki(){
	document.getElementById("sonucalaniiki").innerHTML = "Hash değeri değişti";
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

<body onhashchange="yaz()">
<button onclick="baglantidegistir()">Tıkla</button>
<div id="eski"></div>
<div id="yeni"></div>

<script type="text/javascript" language="javascript">
// oldURL 	:	Sayfa URL'inin (Uniform resource locator) (nizami kaynak bulucu) bağlantı bölümünde değişiklik olduğundaki eski URL (Uniform resource locator) (nizami kaynak bulucu) adresini geriye döndürür.
// newURL 	:	Sayfa URL'inin (Uniform resource locator) (nizami kaynak bulucu) bağlantı bölümünde değişiklik olduğundaki yeni URL (Uniform resource locator) (nizami kaynak bulucu) adresini geriye döndürür.

function baglantidegistir(){
	location.hash 	=	"Javascript-Egitim-Seti";
}

function yaz(){
	var eskiadres	=	event.oldURL;
	var yeniadres	=	event.newURL;
	document.getElementById("eski").innerHTML =	"Eski URL Değeri : " + eskiadres;
	document.getElementById("yeni").innerHTML =	"Yeni URL Değeri : " + yeniadres;
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

<body onpageshow="bir()" onpagehide="iki()">
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// onpageshow	:	Sayfa kullanıcı tarafından görüntülenebiliyorsa belirtilecek olan fonksiyon çalışır.
// onpagehide	:	Sayfa kullanıcı tarafından görüntülenemiyorsa belirtilecek olan fonksiyon çalışır.

function bir(){
	document.getElementById("sonucalani").innerHTML = "Sayfamıza Hoş Geldiniz...";
}

function iki(){
	document.getElementById("sonucalani").innerHTML = "Sayfa Görüntülenemiyor...";
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

<body ononline="bir()" onoffline="iki()">
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// ononline		:	Browser (tarayıcı) sayfayı çevrimdışı modda çalıştırırken, çevrimiçi modda çalıştırmaya başladığında belirtilecek olan fonksiyon çalışır.
// onoffline	:	Browser (tarayıcı) sayfayı çevrimiçi modda çalıştırırken, çevrimdışı modda çalıştırmaya başladığında belirtilecek olan fonksiyon çalışır.

function bir(){
	document.getElementById("sonuc").innerHTML 	=	"Sayfa çevrimiçi modda çalıştırılmaya başladı.";
}

function iki(){
	document.getElementById("sonuc").innerHTML 	=	"Sayfa çevrimdışı modda çalıştırılmaya başladı.";
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

<body onresize="ornek()">
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// onresize		:	Kullanıcı tarafından browser'ın (tarayıcının) sayfa boyutu değiştirilmek istendiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("sonuc").innerHTML += "Sayfa Boyutu Değiştirildi... ";
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
.islem{
	width:300px;
	height:300px;
	overflow:scroll;
	border:3px double black;
}
</style>
</head>

<body>
<div id="alanim" onscroll="ornek()" class="islem">Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript</div>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// onscroll 	:	Sayfanın veya herhangi bir HTML elemanının kaydırma çubuğu yukarı veya aşağı kaydırıldığında belirtilecek olan fonksiyon çalışır.

var sayi	=	0;

function ornek(){
	document.getElementById("sonucalani").innerHTML = sayi += 1;
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
<details ontoggle="ornek()">
<summary>Burası açılır / kapanır alan</summary>
<div>Javascript</div>
<div>Php</div>
<div>Css</div>
<div>Html</div>
<div>Python</div>
</details>

<script type="text/javascript" language="javascript">
// ontoggle		:	Belge içerisindeki HTML details elemanının içeriği açıldığında veya kapandığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Olay gerçekleştirildi.");
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
<video oncanplay="ornek()" controls>
	<source src="Video.mp4" type="video/mp4">
	<source src="Video.webm" type="video/webm">
	<source src="Video.ogg" type="video/ogg">
</video>

<script type="text/javascript" language="javascript">
// oncanplay	:	Medya elemanı yürütülemeye hazır olduğunda belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Medya dosyası oynatılmaya hazır");
}

</script>
</body>
</html>


 <!-- Ses dosyası örneği -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<audio src="Ses.mp3" oncanplay="ornek()" controls></audio>

<script type="text/javascript" language="javascript">
// oncanplay	:	Medya elemanı yürütülemeye hazır olduğunda belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Medya dosyası oynatılmaya hazır");
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
<video onplay="test()" controls>
	<source src="Video.mp4" type="video/mp4">
	<source src="Video.webm" type="video/webm">
	<source src="Video.ogg" type="video/ogg">
</video>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// onplay 	:	Medya elemanı yürütülmeye başlandığında belirtilecek olan fonksiyon çalışır.

function test(){
	document.getElementById("sonuc").innerHTML += "Medya Yürütülmeye Başladı<br />";
}

</script>
</body>
</html>

<!-- Ses dosyası örneği -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<audio src="Ses.mp3" onplay="test()" controls></audio>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// onplay 	:	Medya elemanı yürütülmeye başlandığında belirtilecek olan fonksiyon çalışır.

function test(){
	document.getElementById("sonuc").innerHTML += "Medya Yürütülmeye Başladı<br />";
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