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