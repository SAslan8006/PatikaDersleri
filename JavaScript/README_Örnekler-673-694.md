# Javascript Notları 

## Örnekler  

```Html
<!-- Json Örneği -->

<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Bilgileri Getir</button>
<br /><br />
<div id="sonuc">Verileri Elde Etmek İçin Yukarıdaki Butona Tıklayınız</div>

<script type="text/javascript" language="javascript">
function ornek(){
	var istek	=	new XMLHttpRequest();
	istek.onreadystatechange = function(){
		if(this.readyState==4 && this.status==200){
			var jsondegerleri	=	JSON.parse(this.responseText);
			var metinsonucu				=	"";
			var isimdegeri				=	jsondegerleri.isim;
			var soyisimdegeri			=	jsondegerleri.soyisim;
			var yasdegeri				=	jsondegerleri.yas;
			var meslekdegeri			=	jsondegerleri.meslek;
			var sehirdegeri				=	jsondegerleri.sehir;
			var bildigidillerdegeri		=	jsondegerleri.bildigidiller;
			
			var nesnelerisay			=	bildigidillerdegeri.length;
			var dillersonuc				=	"";
				for(var baslangic = 0; baslangic<nesnelerisay; baslangic++){
					dillersonuc		+=	"Dil : " + bildigidillerdegeri[baslangic].dil + "<br />Seviye : " + bildigidillerdegeri[baslangic].seviye + "<br /><br />";
				}
			
			metinsonucu		=	"İsim Soyisim : " + isimdegeri + " " + soyisimdegeri + "<br />Yaşı : " + yasdegeri + "<br />Mesleği : " + meslekdegeri + "<br />Yaşadığı Şehir : " + sehirdegeri + "<br /><br />Bildiği Diller : <br /><br />" + dillersonuc;
			
			document.getElementById("sonuc").innerHTML = metinsonucu;
		}else{
			document.getElementById("sonuc").innerHTML = "Bilmeyen Bir Hata Oluştu!";
		}
	};
	istek.open("GET", "veri.json", true);
	istek.send();
}
</script>
</body>
</html>

<!-- 2. Örnek -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Bilgileri Getir</button>
<br /><br />
<div id="sonuc">Verileri Elde Etmek İçin Yukarıdaki Butona Tıklayınız</div>

<script type="text/javascript" language="javascript">
function ornek(){
	var istek	=	new XMLHttpRequest();
	istek.onreadystatechange = function(){
		if(this.readyState==4 && this.status==200){
			var jsondegerleri	=	JSON.parse(this.responseText);
			var metinsonucu				=	"";
			var setdegerleri			=	jsondegerleri.setler;
			var setdegerleriuzunlugu	=	setdegerleri.length;
				for(var baslangic = 0; baslangic<setdegerleriuzunlugu; baslangic++){
					metinsonucu		+=	"Eğitim Seti Adı : " + setdegerleri[baslangic].icerik + "<br />Eğitimci : " + setdegerleri[baslangic].egitmen + "<br />Fiyat : " + setdegerleri[baslangic].fiyat + "<br /><br /><br />";
				}
			
			document.getElementById("sonuc").innerHTML = metinsonucu;
		}else{
			document.getElementById("sonuc").innerHTML = "Bilmeyen Bir Hata Oluştu!";
		}
	};
	istek.open("GET", "veri.json", true);
	istek.send();
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
table,th,td{
	border:1px solid black;
	border-collapse:collapse;
}
th,td{
	width:300px;
	padding:5px;
}
</style>
</head>

<body>
<button onclick="ornek()">Eğitim Setlerini Listele</button>
<br /><br />
<table id="sonuc"></table>

<script type="text/javascript" language="javascript">
function ornek(){
	var istek	=	new XMLHttpRequest();
	istek.onreadystatechange = function(){
		if(this.readyState==4 && this.status==200){
			var tablo			=	"<tr style=\"background-color:#FFFCCC\"><th>Eğitim Seti Adı</th><th>Eğitmen Adı</th><th>Set Ücreti</th></tr>";
			var xmldegerleri	=	istek.responseXML;
			var etiket			=	xmldegerleri.getElementsByTagName("SETLER");
			var etiketsayisi	=	etiket.length;
			for(var baslangic = 0; baslangic<etiketsayisi; baslangic++){
				var renkkontrol		=	baslangic % 2;
					if(renkkontrol==0){
						var renkyaz		=	"style=\"background-color:#FFFFFF\"";
					}else{
						var renkyaz		=	"style=\"background-color:#F1F1F1\"";
					}
				tablo += "<tr " + renkyaz + "><td>" + 
				etiket[baslangic].getElementsByTagName("ICERIK")[0].childNodes[0].nodeValue + 
				"</td><td>" + etiket[baslangic].getElementsByTagName("EGITMEN")[0].childNodes[0].nodeValue + 
				"</td><td>" + etiket[baslangic].getElementsByTagName("FIYAT")[0].childNodes[0].nodeValue + 
				"</td></tr>";
			}
			document.getElementById("sonuc").innerHTML = tablo;
		}else{
			document.getElementById("sonuc").innerHTML = "<tr><td>İstek veya Yanıt anında hata oluştu.</td></tr>";
		}
	};
	istek.open("GET", "dosya.xml", true);
	istek.send();
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
<div style="text-align:right;"><select onchange="ornek(this.value)">
	<option value=""></option>
	<option value="1">Volkan Alakent</option>
	<option value="2">Hakan Alakent</option>
	<option value="3">Ümit Okudan</option>
	<option value="4">Onur Tatlı</option>
</select></div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
function ornek(gelendeger){
	var istek	=	new XMLHttpRequest();
	istek.onreadystatechange = function(){
		if(this.readyState==4 && this.status==200){
			document.getElementById("sonuc").innerHTML = this.responseText;
		}else{
			document.getElementById("sonuc").innerHTML = "Bilinmeyen Bir Hata Oluştu!";
		}
	};
	istek.open("GET", "kaynak.php?deger=" + gelendeger, true);
	istek.send();
}
</script>
</body>
</html>

<!-- kaynak.php -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<?php
$GelenVeri 	=	$_GET["deger"];
if($GelenVeri!=""){
	$VeritabaniBaglantisi	=	mysqli_connect("localhost", "root", "", "ders");
	if(!$VeritabaniBaglantisi){
		die("Veritabanı Bağlantı Hatası");
	}
	mysqli_select_db($VeritabaniBaglantisi, "ders");
	mysqli_set_charset($VeritabaniBaglantisi, "utf8");
	
	$KayitSorgula	=	mysqli_fetch_assoc(mysqli_query($VeritabaniBaglantisi,"SELECT * FROM kisiler WHERE id=$GelenVeri ORDER BY id ASC LIMIT 1"));
		$isimdegeri					=	$KayitSorgula["isim"];
		$soyisimdegeri				=	$KayitSorgula["soyisim"];
		$yasdegeri					=	$KayitSorgula["yas"];
		$meslekdegeri				=	$KayitSorgula["meslek"];
		$sehirdegeri				=	$KayitSorgula["sehir"];
		$emailadresidegeri			=	$KayitSorgula["emailadresi"];
		$websitesiadresidegeri		=	$KayitSorgula["websitesiadresi"];
	
	echo	"İsim : ".$isimdegeri."<br />";
	echo	"Soyisim : ".$soyisimdegeri."<br />";
	echo	"Yaş : ".$yasdegeri."<br />";
	echo	"Meslek : ".$meslekdegeri."<br />";
	echo	"Şehir : ".$sehirdegeri."<br />";
	echo	"E-Mail : ".$emailadresidegeri."<br />";
	echo	"Web Sitesi : ".$websitesiadresidegeri."<br />";
	
	mysqli_close($VeritabaniBaglantisi);
}else{
	echo	"Lütfen geçerli bir kayıt seçiniz";
}
?>
</body>
</html>

<!-- kisiler.sql -->
-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 31 Ara 2016, 18:46:15
-- Sunucu sürümü: 10.1.13-MariaDB
-- PHP Sürümü: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ders`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kisiler`
--

CREATE TABLE `kisiler` (
  `id` int(11) UNSIGNED NOT NULL,
  `isim` varchar(255) NOT NULL,
  `soyisim` varchar(255) NOT NULL,
  `yas` int(2) NOT NULL,
  `meslek` varchar(255) NOT NULL,
  `sehir` varchar(255) NOT NULL,
  `emailadresi` varchar(255) NOT NULL,
  `websitesiadresi` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `kisiler`
--

INSERT INTO `kisiler` (`id`, `isim`, `soyisim`, `yas`, `meslek`, `sehir`, `emailadresi`, `websitesiadresi`) VALUES
(1, 'Volkan', 'Alakent', 36, 'Bilgisayar Yazılımcısı', 'İstanbul', 'info@extraegitim.com', 'http://www.extraegitim.com'),
(2, 'Hakan', 'Alakent', 38, 'Bölge Müdürü', 'İstanbul', 'hakanalakent@extraegitim.com', 'http://www.extraegitim.net'),
(3, 'Ümit', 'Okudan', 38, 'Müşteri Temsilcisi', 'Ankara', '', ''),
(4, 'Onur', 'Tatlı', 34, 'Müdür', 'İzmir', '', '');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kisiler`
--
ALTER TABLE `kisiler`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kisiler`
--
ALTER TABLE `kisiler`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;


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
<br />
<div id="icerik">Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt volkanalakent@extraegitim.com Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt volkanalakent@yandex.com Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt ipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt info@extraegitim.com Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt Javascipt</div>

<script type="text/javascript" language="javascript">
	var deger		=	document.getElementById("icerik").innerHTML;
	var desen		=	/[A-Z0-9a-z_.-]+@[A-Z0-9a-z\-]+\.[A-Za-z]{2,3}/gi;
	var sonuc		=	deger.match(desen);
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
<a href="javascript:ornek('https://www.google.com.tr', 1000, 650);">Google'a Git</a>

<script type="text/javascript" language="javascript">

function ornek(adres, istenilengenislik, istenilenyukseklik){
	var solhesap	=	parseInt((screen.availWidth/2) - (istenilengenislik/2));
	var usthesap	=	parseInt((screen.availHeight/2) - (istenilenyukseklik/2));
	var ozellikler	=	"width=" + istenilengenislik + ",height=" + istenilenyukseklik + ",left=" + solhesap + ",top=" + usthesap;
	window.open(adres, "Google", ozellikler);
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
<div id="gezenalan"><img src="nazarboncugu.png" width="25" height="26" style="border:none" /></div>

<script type="text/javascript" language="javascript">

var alan	=	document.getElementById("gezenalan");
alan.style.position = "absolute";
window.onmousemove = function(event){
	alan.style.left 	=	event.clientX + 15 + "px";
	alan.style.top 	 	=	event.clientY + "px";
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
body{
	margin:0;
}
#kayanyazi{
	width:100%;
	height:25px;
	background-color:red;
	color:white;
	position:fixed;
	padding-top:5px;
	bottom:0;
	left:0;
}
</style>
</head>

<body>
Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />Javascript<br />

<div id="kayanyazi"><marquee onmouseover="this.stop()" onmouseout="this.start()">Javascript Eğitim Seti Volkan Alakent</marquee></div>
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
Merhaba Sayfa 5 Saniye Sonra Otomatik Olarak Kapanacaktır!

<script type="text/javascript" language="javascript">

function ornek(){
	window.setTimeout("self.close()", 5000);
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
var sira	=	1;
var metin1	=	"Javascript - Extra Eğitim";
var metin2	=	"Php - Extra Eğitim";
var metin3	=	"Html - Extra Eğitim";
var metin4	=	"Css - Extra Eğitim";
var metin5	=	"Java - Extra Eğitim";
var metin6	=	"Xml - Extra Eğitim";

function ornek(){
	if(sira==1){
		window.status 	=	metin1;
		document.title 	=	metin1;
		sira++;
	}else if(sira==2){
		window.status 	=	metin2;
		document.title 	=	metin2;
		sira++;
	}else if(sira==3){
		window.status 	=	metin3;
		document.title 	=	metin3;
		sira++;
	}else if(sira==4){
		window.status 	=	metin4;
		document.title 	=	metin4;
		sira++;
	}else if(sira==5){
		window.status 	=	metin5;
		document.title 	=	metin5;
		sira++;
	}else if(sira==6){
		window.status 	=	metin6;
		document.title 	=	metin6;
		sira 	=	1;
	}
	window.setTimeout("ornek();", 2000);	
}
ornek();

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
#kapsamalani{
	margin:50px auto;
	width:542px;
	height:348px;
	border:3px double black;
	position:relative;
}
#metinalani{
	width:532px;
	height:50px;
	position:absolute;
	bottom:0;
	left:0;
	background-color:#FFFFFF;
	padding:5px;
	opacity:0.7;
	-moz-opacity:0.7;
	filter:alpha(opacity=70);
}
#metin{
	color:black;
	opacity:1;
	-moz-opacity:1;
	filter:alpha(opacity=100);
}
</style>


</head>

<body>
<div id="kapsamalani" onmouseover="goster()" onmouseout="gizle()">
	<img src="resim.jpg" width="542" height="348" style="border:none;" />
	<div id="metinalani" style="display:none;"><div id="metin">Kız Kulesi, hakkında çeşitli rivayetler anlatılan, efsanelere konu olan, İstanbul Boğazı'nın Marmara Denizi'ne yakın kısmında, Salacak açıklarında yer alan küçük adacık üzerinde inşa edilmiş yapıdır.</div></div>
</div>

<script type="text/javascript" language="javascript">

function goster(){
	document.getElementById("metinalani").style.display = "block";
}

function gizle(){
	document.getElementById("metinalani").style.display = "none";
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
body{
	margin:0;
}
#kapsamalani{
	width:100%;
	height:100%;
	text-align:center;
}
#haberalani{
	width:1000px;
	margin:0 auto;
}
#baslikalani{
	width:900px;
	height:60px;
	float:left;
	text-align:left;
}
#iconalani{
	width:100px;
	height:45px;
	padding-top:15px;
	float:left;
	text-align:right;
}
#icerik{
	text-align:justify;
	font-size:15px;
}
</style>
</head>

<body>

<div id="kapsamalani">
	<div id="haberalani">
		<div id="baslikalani"><h3>Yeni ehliyetler için gerekli evraklar nelerdir?</h3></div>
		<div id="iconalani"><img src="buyut.jpg" title="Metni Büyüt" style="cursor:pointer;" onclick="buyut()" /> <img src="kucult.jpg" title="Metni Küçült" style="cursor:pointer;" onclick="kucult()" /></div>
        <hr>
        <div id="icerik">Yeni yılla birlikte yeni uygulamalar da devreye girmeye başladı. Bunlardan biri de ehliyetler oldu. İçişleri Bakanlığı tarafından Karayolları Trafik Yönetmeliğinde yapılan değişiklikle mevcut ehliyetler 1 Ocak 2016’dan itibaren değiştirilmeye başlandı. Bu yıl dahil olmak üzere toplamda beş yıl içerisinde tüm ehliyetler değişmiş olacak. Emniyet Genel Müdürlüğü, sürücülerin yeni ehliyetlerini kolayca edinebilmeleri için online başvuru ve randevu sistemi kurdu. Sistem, EGM'nin  (Emniyet Genel Müdürlüğü) resmi sitesinin surucurandevu.egm.gov.tr  adresi üzerinden hizmet veriyor. Böylece sürücüler zaman kaybetmeden, zorlanmadan eski ehliyetlerini değiştirebilecekler. Vatandaşlar, Emniyet Genel Müdürlüğü'ne ait internet adresinden online randevu aldıktan sonra il/ilçe trafik tescil birimlerinde yeni tip sürücü belgesi işlemlerini gerçekleştirebilecek. Ancak yeni tip ehliyetlerin edinilebilmesi için bazı şartlar ve belgeler gerekiyor. Peki, 1 Ocak 2016 tarihinden itibaren değiştirilmesi gereken ehliyet için neler yapılmalı? Yeni ehliyetleri almak için gerekli evraklar nelerdir? Merak edilenler haberimizde!<br /><br />
<strong>YENİ TİP EHLİYET ALMA ŞARTLARI</strong><br />
Randevu sırasında sizden istenen mail adresine eski ehliyetinizi değiştirme talebiniz için onay kodu gönderilecek. Bu onay kodunun çıktısı ve hazırlanan evraklar ile birlikte randevu saatinizden 15 dakika önce randevu aldığınız Trafik ve Tescil Şube Müdürlüğü`ne gitmeniz gerekecek. Başvurunuz kontrol edildikten sonra form doldurulacak ve eski ehliyetiniz geri alınacak. Yeni ehliyet edinilene kadar "geçici sürücü belgesi" verilecek. 15 gün içerisinde ise yeni ehliyetiniz adresinize gönderilecek.<br /><br />
<strong>YENİ EHLİYET ALABİLMEK İÇİN GEREKLİ BELGELER</strong><br />
Eski sürücü belgesi, nüfus cüzdanı, pasaport veya avukatlık kimliği, sürücü sağlık raporu, 15 TL (13 TL değerli kağıt bedeli, 2 TL vakıf payı) bedelin vergi dairelerine veya bankalara yatırıldığına dair makbuz, 2 adet fotoğraf (5x6 ebadında arka fon beyaz olacak şekilde biyometrik bir vesikalık fotoğraf), kan grubunu belirtir belge veya yazılı beyan.<br /><br />
<strong>YENİ EHLİYETLER İLE İLGİLİ BİLİNMESİ GEREKENLER</strong><br />
Yeni tip ehliyetler, minibüs, otobüs, kamyon ve çekici sınıfları için 5 yıl, motosiklet, otomobil, traktör ve iş makinesi sınıfları için ise 10 yıl geçerli olacak. Belirlenen sürenin sonunda ehliyetler, sağlık kontrolünden geçirilerek yeniden düzenlenecek. Yeni tip sürücü belgesini alan sürücüler trafik konvansiyonuna üye 84 ülkede araç kullanabilecek.<br /><br />
<strong>SAĞLIK RAPORU BİLMECESİNE BAKANLIKTAN AÇIKLAMA</strong><br />
Sağlık Bakanlığı, sürücü belgesi için istenilen 'sağlık raporuna' ilişkin yayınlanan haberlerde kamuoyunu yanlış bilgilendiren ifadelerin yer alması gerekçesiyle konuyla ilgili bir açıklama yaptı. Açıklamada "Aile hekimlerine giden ve ileri bir sağlık sorunu olmadığı tespit edilen vatandaşlardan işlem karşılığında herhangi bir ücret talep edilmemektedir. Her sürücü adayına zeka testi yapılmayacaktır. Aile hekiminin sevk etmesi, psikiyatri uzmanının da uygun görmesi halinde zekâ testi yapılabilecektir" denildi. Sağlık muayenesi yapılmak üzere sağlık kuruluşlarına sevk edilenler için uygulanacak ücret tarifesiyse şöyle açıklandı: "Aile hekiminin muayenesi sonucu kişide uzmanlık gerektirecek bir sağlık probleminin tespit edilmesi durumunda, kişi söz konusu uzmanlık dallarının bulunduğu sağlık kuruluşlarına sevk edilir. Bu aşamada sağlık kuruluşunun basamağına göre aşağıdaki ücret tarifesi uygulanır. Tek Hekim Sağlık Raporu: (5 ayrı branşta uzman hekimden oluşan kurul) Devlet hastaneleri 50 TL, Üniversite hastaneleri ve eğitim Araştırma Hastaneleri 75 TL; Sağlık Kurulu Raporu Devlet hastaneleri, 200 TL; Üniversite hastaneleri ve Eğitim Araştırma Hastaneleri 300 TL"</div>
	</div>
</div>

<script type="text/javascript" language="javascript">
var standartfontboyutu	=	15;

function buyut(){
	standartfontboyutu 		=	standartfontboyutu+1;
	document.getElementById("icerik").style.fontSize = standartfontboyutu + "px";
}

function kucult(){
	standartfontboyutu 		=	standartfontboyutu-1;
	document.getElementById("icerik").style.fontSize = standartfontboyutu + "px";
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
<textarea id="alan" style="width:500px; height:100px;" onkeypress="ornek()"></textarea>
<br />
<div>Kullanılan Karakter Sayısı : <span id="kullanilankarakter">0</span></div>
<div >Kalan Karakter Sayısı : <span id="kalankarakter">250</span></div>

<script type="text/javascript" language="javascript">
var kullanilan		=	0;
var maksimum		=	249;

function ornek(){
	var baglan			=	document.getElementById("alan");
	var uzunluk			=	baglan.value.length;
	if(uzunluk>=maksimum){
		var deger		=	baglan.value;
		var olustur		=	deger.substr(0, maksimum);
		document.getElementById("alan").value	=	olustur;
		document.getElementById("kullanilankarakter").innerHTML		=	maksimum + 1;
		document.getElementById("kalankarakter").innerHTML			=	0;
	}else{
		var deger		=	baglan.value;
		var olustur		=	deger.substr(0, maksimum);
		document.getElementById("alan").value	=	olustur;
		document.getElementById("kullanilankarakter").innerHTML		=	uzunluk + 1;
		document.getElementById("kalankarakter").innerHTML			=	(maksimum + 1) - (uzunluk + 1);
	}
}
</script>
</body>
</html>
```

```Html

<!-- Üyelik Formu -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<script type="text/javascript" language="javascript">
function formkontrolu(){
	if(document.getElementById("kullaniciadi").value==""){
		alert("Kullanıcı Adı Alanı Boş Bırakılamaz!");
		document.uyelikformu.kullaniciadi.focus();
		return;
	}
	if(document.getElementById("kullaniciadi").value!=""){
		if(document.getElementById("kullaniciadi").value.length<4 || document.getElementById("kullaniciadi").value.length>25){
			alert("Kullanıcı Adı Minimum 4 Karakter Maksimum 25 Karakter Aralığında Olmalıdır!");
			document.uyelikformu.kullaniciadi.value = "";
			document.uyelikformu.kullaniciadi.focus();
			return;
		}		
	}
	if(document.getElementById("kullanicisifresi").value==""){
		alert("Kullanıcı Şifre Alanı Boş Bırakılamaz!");
		document.uyelikformu.kullanicisifresi.focus();
		return;
	}
	if(document.getElementById("kullanicisifresi").value!=""){
		if(document.getElementById("kullanicisifresi").value.length<4 || document.getElementById("kullanicisifresi").value.length>25){
			alert("Kullanıcı Şifresi Minimum 4 Karakter Maksimum 25 Karakter Aralığında Olmalıdır!");
			document.uyelikformu.kullanicisifresi.value = "";
			document.uyelikformu.kullanicisifresitekrar.value = "";
			document.uyelikformu.kullanicisifresi.focus();
			return;
		}		
	}
	if(document.getElementById("kullanicisifresitekrar").value==""){
		alert("Kullanıcı Şifre Tekrar Alanı Boş Bırakılamaz!");
		document.uyelikformu.kullanicisifresitekrar.focus();
		return;
	}
	if(document.getElementById("kullanicisifresitekrar").value!=""){
		if(document.getElementById("kullanicisifresitekrar").value.length<4 || document.getElementById("kullanicisifresitekrar").value.length>25){
			alert("Kullanıcı Şifresi Tekrarı Minimum 4 Karakter Maksimum 25 Karakter Aralığında Olmalıdır!");
			document.uyelikformu.kullanicisifresi.value = "";
			document.uyelikformu.kullanicisifresitekrar.value = "";
			document.uyelikformu.kullanicisifresi.focus();
			return;
		}		
	}
	if(document.getElementById("kullanicisifresi").value!="" && document.getElementById("kullanicisifresitekrar").value!=""){
		if(document.getElementById("kullanicisifresi").value!=document.getElementById("kullanicisifresitekrar").value){
			alert("Kullanıcı Şifresi İle Kullanıcı Şifresi Tekrarı Birbirleri İle Aynı Değildir!");
			document.uyelikformu.kullanicisifresi.value = "";
			document.uyelikformu.kullanicisifresitekrar.value = "";
			document.uyelikformu.kullanicisifresi.focus();
			return;
		}
	}
	if(document.getElementById("emailadresi").value==""){
		alert("E-Mail Adresi Alanı Boş Bırakılamaz!");
		document.uyelikformu.emailadresi.focus();
		return;
	}
	if(document.getElementById("emailadresi").value!=""){
		if(document.getElementById("emailadresi").value.indexOf("@", 0) == -1 || document.getElementById("emailadresi").value.indexOf(".", 0) == -1){
			alert("E-Mail Adresi Uygun Değildir!");
			document.uyelikformu.emailadresi.value = "";
			document.uyelikformu.emailadresi.focus();
			return;
		}
	}
	if(document.getElementsByName("cinsiyet")[0].checked==false && document.getElementsByName("cinsiyet")[1].checked==false){
		alert("Cinsiyet Alanı Seçilmelidir!");
		return;
	}
	if(document.getElementsByName("hobiler")[0].checked==false && document.getElementsByName("hobiler")[1].checked==false && document.getElementsByName("hobiler")[2].checked==false){
		alert("Hobiler Alanı Seçilmelidir!");
		return;
	}
	if(document.getElementById("kullanicinotu").value==""){
		alert("Kullanıcı Notu Alanı Boş Bırakılamaz!");
		document.uyelikformu.kullanicinotu.focus();
		return;
	}
	
	document.uyelikformu.submit();
}
</script>
</head>

<body>
<form id="uyelikformu" name="uyelikformu" action="xxx.php" method="post">
<table>
	<tr>
    	<th colspan="3">Üyelik Formu</th>
    </tr>
	<tr>
    	<td>Kullanıcı Adı</td>
    	<td>:</td>
    	<td><input type="text" id="kullaniciadi" name="kullaniciadi"></td>
    </tr>
	<tr>
    	<td>Kullanıcı Şifresi</td>
    	<td>:</td>
    	<td><input type="password" id="kullanicisifresi" name="kullanicisifresi"></td>
    </tr>
	<tr>
    	<td>Kullanıcı Şifresi Tekrar</td>
    	<td>:</td>
    	<td><input type="password" id="kullanicisifresitekrar" name="kullanicisifresitekrar"></td>
    </tr>
	<tr>
    	<td>E-Mail Adresi</td>
    	<td>:</td>
    	<td><input type="text" id="emailadresi" name="emailadresi"></td>
    </tr>
	<tr>
    	<td>Cinsiyet</td>
    	<td>:</td>
    	<td><input type="radio" id="cinsiyet1" name="cinsiyet" value="Erkek"> Erkek <input type="radio" id="cinsiyet2" name="cinsiyet" value="Kadın"> Kadın</td>
    </tr>
	<tr>
    	<td>Hobiler</td>
    	<td>:</td>
    	<td><input type="checkbox" id="hobiler1" name="hobiler" value="Alışveriş"> Alışveriş <input type="checkbox" id="hobiler2" name="hobiler" value="Gezmek"> Gezmek <input type="checkbox" id="hobiler3" name="hobiler" value="Müzik"> Müzik</td>
    </tr>
	<tr>
    	<td>Not</td>
    	<td>:</td>
    	<td><textarea id="kullanicinotu" name="kullanicinotu"></textarea></td>
    </tr>
	<tr>
    	<td colspan="3" style="text-align:center;"><input type="button" value="Gönder" onclick="formkontrolu()"></td>
    </tr>
</table>
</form>
</body>
</html>

```

```Html

<!-- Güvenlik Kodu Capcha : -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body onload="ornek()">
<div>Güvenlik Kodu :</div>
<br />
<canvas id="guvenlikkodualani" width="150" height="50"></canvas>
<br /><br />
<button onclick="degistir()">Kodu Değiştir</button>

<script type="text/javascript" language="javascript">

var islem;

function ornek(){
	islem 	=	document.getElementById("guvenlikkodualani").getContext("2d");
	islem.fillStyle 	=	"#e6cd57";
	degistir();
}

function degistir(){
	var metin	=	"";
	for(var baslangic = 0; baslangic<6; baslangic++){
		var rastgeledeger	=	Math.random();
		if(Math.round(rastgeledeger) == 0){
			metin 	+=	String.fromCharCode(48+9 * Math.random());
		}else{
			metin 	+=	String.fromCharCode(65+25 * Math.random());
		}
	}
	islem.clearRect(0, 0, 150, 50);
	islem.fillRect(0, 0, 150, 50);
	islem.font 	=	"30px calibri";
	islem.strokeText(metin, 24, 34);
}

</script>
</body>
</html>
```

```Html

<!-- Javascript Tab Menü İçeriği -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
ul{
	margin:0; margin-bottom:5px;
}
li{
	display:inline; margin:0; height:22px; padding-top:5px; padding-bottom:5px; padding-left:5px; padding-right:50px; color:red; border:1px solid red;
}
div{
	width:679px; height:250px; margin-left:40px; padding:5px; border:1px solid red;
}
</style>
</head>

<body>
<ul>
	<li onclick="goster('birincialan')" style="cursor:pointer;">Javascript Eğitim Seti</li>
	<li onclick="goster('ikincialan')" style="cursor:pointer;">Php Eğitim Seti</li>
	<li onclick="goster('ucuncualan')" style="cursor:pointer;">Html Eğitim Seti</li>
	<li onclick="goster('dorduncualan')" style="cursor:pointer;">Css Eğitim Seti</li>
</ul>

<div id="birincialan">Javascript Tab'ının İçeriği</div>

<div id="ikincialan" style="display:none;">Php Tab'ının İçeriği</div>

<div id="ucuncualan" style="display:none;">Html Tab'ının İçeriği</div>

<div id="dorduncualan" style="display:none;">Css Tab'ının İçeriği</div>

<script type="text/javascript" language="javascript">

function tumunugizle(){
	var alanlar		=	document.getElementsByTagName("DIV");
	var uzunluk		=	alanlar.length;
	for(var baslangic = 0; baslangic<uzunluk; baslangic++){
		alanlar[baslangic].style.display = "none";
	}
}

function goster(deger){
	tumunugizle();
	document.getElementById(deger).style.display = "block";
}

</script>
</body>
</html>

```

```Html

<!-- Slayt Resim Örneği -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
*{
	margin:0px;
}
#slaytalani{
	width:1000px;
	height:350px;
	margin: 50px auto;
	position:relative;
	overflow:hidden;
	border-radius:5px;
}
#resim{
	width:1000px;
	height:350px;
	position:relative;
}
.solalani{
	width:100px;
	height:350px;
	position:absolute;
	text-align:left;
	left:0px;
	top:0px;
}
.sagalani{
	width:100px;
	height:350px;
	position:absolute;
	text-align:right;
	right:0px;
	top:0px;
}
.sol{
	width:50px;
	height:50px;
	position:absolute;
	top:40%;
	left:25px;
	opacity:0;
	transition: all .5s ease-in-out 0s;
}
.sag{
	width:50px;
	height:50px;
	position:absolute;
	top:40%;
	right:25px;
	opacity:0;
	transition: all .5s ease-in-out 0s;
}
.solalani:hover .sol{
	opacity:0.5;	
}
.sagalani:hover .sag{
	opacity:0.5;	
}
</style>
</head>

<body onload="calistir()">
<div id="slaytalani">
    <img id="resim" src="slayt1.jpg" width="1000" height="350" style="border:none;" />
    <div class="solalani"><img src="solok.png" width="50" height="50" class="sol" onclick="resimdegistir(-1)" style="border:none; cursor:pointer;"/></div>
    <div class="sagalani"><img src="sagok.png" width="50" height="50" class="sag" onclick="resimdegistir(1)" style="border:none; cursor:pointer;"/></div>
</div>

<script type="text/javascript" language="javascript">
var resimsirasi 	=	1;
var toplamresim 	=	10;

function resimdegistir(deger){
	var resim		=	document.getElementById("resim");
	resimsirasi		=	resimsirasi + deger;
	if(resimsirasi>toplamresim){
		resimsirasi		=	1;
	}
	if(resimsirasi<1){
		resimsirasi		=	toplamresim;
	}
	resim.src 	=	"slayt" + resimsirasi + ".jpg";
	clearInterval(zaman);
	zaman		=	window.setInterval(function calistir(){
		var resim		=	document.getElementById("resim");
		resimsirasi		=	resimsirasi + 1;
			if(resimsirasi>toplamresim){
				resimsirasi		=	1;
			}
			if(resimsirasi<1){
				resimsirasi		=	toplamresim;
			}
		resim.src 	=	"slayt" + resimsirasi + ".jpg";
	}, 3000);
}

var zaman		=	window.setInterval(function calistir(){
var resim		=	document.getElementById("resim");
resimsirasi		=	resimsirasi + 1;
	if(resimsirasi>toplamresim){
		resimsirasi		=	1;
	}
	if(resimsirasi<1){
		resimsirasi		=	toplamresim;
	}
	resim.src 	=	"slayt" + resimsirasi + ".jpg";
}, 3000);
</script>
</body>
</html>
```

```Html
<!-- Hesap Makinesi Örneği -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.numara{
	width:100%;
	height:25px;
	background-color:#DDDBDB;
}
.islem{
	width:100%;
	height:25px;
	background-color:#939191;
}
</style>
</head>

<body>
<form name="hesapmakinesi">
	<table>
		<tr>
        	<th colspan="4"><input type="text" name="ekran"></th>
        </tr>
		<tr>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='1'">1</button></td>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='2'">2</button></td>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='3'">3</button></td>
        	<td><button class="islem" type="button" onclick="document.hesapmakinesi.ekran.value+='/'">/</button></td>
        </tr>
		<tr>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='4'">4</button></td>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='5'">5</button></td>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='6'">6</button></td>
        	<td><button class="islem" type="button" onclick="document.hesapmakinesi.ekran.value+='*'">*</button></td>
        </tr>
		<tr>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='7'">7</button></td>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='8'">8</button></td>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='9'">9</button></td>
        	<td><button class="islem" type="button" onclick="document.hesapmakinesi.ekran.value+='+'">+</button></td>
        </tr>
		<tr>
        	<td><button class="islem" type="button" onclick="document.hesapmakinesi.ekran.value=''">C</button></td>
        	<td><button class="numara" type="button" onclick="document.hesapmakinesi.ekran.value+='0'">0</button></td>
        	<td><button class="islem" type="button" onclick="document.hesapmakinesi.ekran.value=eval(document.hesapmakinesi.ekran.value)">=</button></td>
        	<td><button class="islem" type="button" onclick="document.hesapmakinesi.ekran.value+='-'">-</button></td>
        </tr>
	</table>
</form>
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