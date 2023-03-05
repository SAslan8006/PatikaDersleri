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