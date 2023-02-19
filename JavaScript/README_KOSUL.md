# Javascript Notları 

## İf -else if - else kullanımı  

```JS
// if		=	Eğer
// else if	=	Değilse Eğer
// else 	=	Değilse
/*
if(kosul / kosullar){
	ifade / ifadeler
}else if(kosul / kosullar){
	ifade / ifadeler
}else{
	ifade / ifadeler
}
*/

var saat		=	8;
var verituru	=	typeof saat;

if(saat>=0 && saat<=5){
	document.write("İyi Geceler");
}else if(saat>5 && saat<=9){
	document.write("Günaydın");
}else if(saat>9 && saat<=16){
	document.write("İyi Günler");
}else if(saat>16 && saat<=23){
	document.write("İyi Akşamlar");
}else if(saat>23){
	document.write("Değer Çok Büyük");
}else if(verituru=="string"){
	document.write("Değer Rakamsal Olmalıdır");
}else{
	document.write("Hata");
}

```
##  Switch Kullanımı

```JS  
// switch		=	Koşul başlatır.
// case			=	Koşul kontrolü.
// break		=	Koşul kontrolü sonlandırması.
// default		=	Koşul olumsuzlukları sonucu.
/*
switch(koşul){
	case koşul kontrolü:
	.....
	break;
	case koşul kontrolü:
	.....
	break;
	case koşul kontrolü:
	.....
	break;
	case koşul kontrolü:
	.....
	break;
	default:
	.....
}
*/

var metin		=	"Volkan";

switch(metin){ // Volkan or true
	case "Volkan":
	document.write("İçerik Volkan");
	break;
	case "Hakan":
	document.write("İçerik Hakan");
	break;
	default:
	document.write("İçerik Tanınmıyor");
}

```

##  Ternary Kullanımı

```JS  
// ?:	=	ternary operatörü
// koşul ? çalıştırılacak ifade 1 : çalıştırılacak ifade 2;

var kontrol	=	("Volkan"=="Hakan") ? "Doğru" : "Yanlış";
document.write(kontrol);


```

##  Try-Catch-Finally and Throw Kullanımı

```JS  
// try		=	Hata oluşturabilecek kodlar için kullanılır.
// catch	=	Hata oluşursa çalıştırılacak kodlar için kullanılır.
// finally	=	Hata oluşsada oluşmasada çalıştırılacak kodlar için kullanılır.
// throw	=	Hata oluşturabilecek kodlar için istisnai durumlarda kullanılır.

try{
	var isim	=	"Volkan";
	document.write(isim + "<br />");
	document.write(soyisim);
	throw(err);
}
catch(err){
	document.write("Hata oluştu<br />");
	document.write(err);
	document.write("<br />");
}
finally{
	document.write("Hata olsada olmasada çalıştı.");
}


```


##  While and Do While  Kullanımı

```JS  
/*
while(koşul){
	çalışacak kodlar
}
*/

var baslangic	=	50;
while(baslangic>=0){
	document.write(baslangic + "<br />");
	baslangic--;
}

/*
do{
	Kodlar
}while(koşul);
*/

var deger	=	50;
do{
	document.write(deger + "<br />");
	deger--;
}while(deger>=0);


```
##  For Kullanımı

```JS  
/*
1. parametre	=	Döngünün başlangıç değeri
2. parametre	=	Koşul
3. parametre	=	Arttırma / azaltma

for(1. parametre, 2. parametre, 3. parametre){
	Kodlar
}
*/

for(var deger = 50; deger>=0; deger--){
	document.write(deger + "<br />");
}

```

##  For in Kullanımı

```JS  
/*
1. parametre 	:	Değişken
2. parametre	:	Dizi / Nesne

for(1. parametre in 2. parametre){
	....
}
*/
var ornek	=	{isim:"Volkan", soyisim:"Alakent", dogumtarihi:"1980"};
document.write(ornek + "<br /><br />");

var sonuc;
for(sonuc in ornek){
	if(ornek[sonuc]=="Volkan"){
		document.write("A kodlamasını çalıştır.<br />");
	}else if(ornek[sonuc]=="Alakent"){
		document.write("B kodlamasını çalıştır.<br />");
	}else if(ornek[sonuc]=="1980"){
		document.write("C kodlamasını çalıştır.<br />");
	}
}

```

##  Döngü Kullanımı notları

```JS  

// break	=	Döngüden çıkmak için kullanılır.
// continue	=	Döngünün o anki işlemini sonlandırarak döngünün başına döner ve işleme kaldığı yerden devam eder.

var ornek	=	{renk1:"Siyah", renk2:"Beyaz", renk3:"Sarı", renk4:"Mavi", renk5:"Kırmızı"};

var sonuc;
for(sonuc in ornek){
	document.write(ornek[sonuc] + "<br />");
	if(sonuc=="renk3"){
		break;
	}
      if(sonuc=="renk2"){
		continue;
	}
}

```