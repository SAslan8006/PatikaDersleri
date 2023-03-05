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
<video onstalled="ornek()" controls>
	<source src="Video.mp4" type="video/mp4">
	<source src="Video.webm" type="video/webm">
	<source src="Video.ogg" type="video/ogg">
</video>

<script type="text/javascript" language="javascript">
// onstalled 	:	Browser (tarayıcı) medya elemanı verisini indirmeye çalışırken medya verisini alamıyorsa belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Medya Verisi Alınamıyor");
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
<audio src="Ses.mp3" onstalled="ornek()" controls></audio>

<script type="text/javascript" language="javascript">
// onstalled 	:	Browser (tarayıcı) medya elemanı verisini indirmeye çalışırken medya verisini alamıyorsa belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Medya Verisi Alınamıyor");
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
<video onabort="ornek()" controls>
	<source src="Video.mp4" type="video/mp4">
	<source src="Video.webm" type="video/webm">
	<source src="Video.ogg" type="video/ogg">
</video>

<script type="text/javascript" language="javascript">
// onabort 		:	Sayfanın, HTML elemanının veya medya elemanı verisinin yüklenmesi durdurulduğunda veya iptal edildiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Bilinmeyen Hata");
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
<audio src="Ses.mp3" onabort="ornek()" controls></audio>

<script type="text/javascript" language="javascript">
// onabort 		:	Sayfanın, HTML elemanının veya medya elemanı verisinin yüklenmesi durdurulduğunda veya iptal edildiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Bilinmeyen Hata");
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
<video ondurationchange="ornek()" controls>
	<source src="Video.mp4" type="video/mp4">
	<source src="Video.webm" type="video/webm">
	<source src="Video.ogg" type="video/ogg">
</video>

<script type="text/javascript" language="javascript">
// ondurationchange 	:	Medya elemanının nesnesinin süresi değiştirildiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Medya Dosyası Nesnesi Süresi Değiştirildi");
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
<audio src="Ses.mp3" ondurationchange="ornek()" controls></audio>

<script type="text/javascript" language="javascript">
// ondurationchange 	:	Medya elemanının nesnesinin süresi değiştirildiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Medya Dosyası Nesnesi Süresi Değiştirildi");
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
Adınız Soyadınız : <input id="isimsoyisim" type="text" onfocus="ornek()">

<script type="text/javascript" language="javascript">
// onfocus	:	Form içerisindeki bir elemana odaklanıldığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("isimsoyisim").style.backgroundColor = "#F1F1F1";
	document.getElementById("isimsoyisim").style.color = "red";
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
İsim Soyisim : <input type="text" onfocus="bir(this)" onblur="iki(this)"><br />
E-Mail : <input type="text" onfocus="bir(this)" onblur="iki(this)">

<script type="text/javascript" language="javascript">
// onblur	:	Form içerisindeki bir elemanın odağından çıkıldığında belirtilecek olan fonksiyon çalışır.

function bir(parametre){
	parametre.style.backgroundColor 	=	"#F1F1F1";
}

function iki(parametre){
	parametre.style.backgroundColor 	=	"white";
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
İsim Soyisim : <input type="text" onfocusin="ornek(this)">

<script type="text/javascript" language="javascript">
// onfocusin	:	Form içerisindeki bir elemana odaklanılmak üzereyken belirtilecek olan fonksiyon çalışır.

function ornek(deger){
	deger.style.backgroundColor = "red";
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
Ad Soyad : <input type="text" onfocusin="bir()" onfocusout="iki()">
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// onfocusout 	:	Form içerisindeki bir elemanın odağından çıkılmak üzereyken belirtilecek olan fonksiyon çalışır.

function bir(){
	document.getElementById("sonuc").innerHTML = "Odaklanmak üzere";
}

function iki(){
	document.getElementById("sonuc").innerHTML = "Odaktan çıkılmak üzere";
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
Renk Seçiniz :
<select id="secim" onchange="ornek()">
	<option>Mavi</option>
	<option>Kırmızı</option>
	<option>Siyah</option>
</select>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// onchange		:	Form içerisindeki bir elemanın değeri veya seçimi değiştirildiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	var veri	=	document.getElementById("secim").value;
	document.getElementById("sonuc").innerHTML = veri;
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
Adınız Soyadınız : <select id="isimsoyisim" oninput="ornek()">
	<option></option>
	<option>Volkan Alakent</option>
	<option>Hakan Alakent</option>
</select>

<script type="text/javascript" language="javascript">
// oninput	:	Form içerisindeki bir elemanın değeri veya seçimi değiştirilirken belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Olay gerçekleşti");
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
<form action="#" method="get">
İsm Soyisim <input id="adsoyad" type="text" oninvalid="ornek()" required>
<input type="submit" value="Gönder">
</form>

<script type="text/javascript" language="javascript">
// oninvalid	:	Form içerisindeki bir elemanın değeri geçersiz ise belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Lütfen ilgili alanı boş bırakmayınız");
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
Arama İçeriği : <input type="search" id="aramalani" onsearch="ornek()">

<script type="text/javascript" language="javascript">
// onsearch 	:	Form içerisindeki arama alanı işleme alındığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Arama kutusu devreye girdi");
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
<form action="#" method="get" onsubmit="ornek()">
İsim Soyisim : <input type="text" id="adsoyad">
<input type="submit" value="Gönder">
</form>

<script type="text/javascript" language="javascript">
// onsubmit		:	Belge içerisindeki form gönderilmek istenirse belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Form Gönderilmek Üzere");	
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
<form action="#" method="get" onreset="ornek()">
İsim Soyisim : <input type="text"><br /><br />
E-Mail : <input type="text"><br /><br />
<input type="submit" value="Gönder"> <input type="reset">
</form>

<script type="text/javascript" language="javascript">
// onreset 		:	Belge içerisindeki form sıfırlanmak istenirse belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Form Sıfırlanıyor");
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
<textarea onselect="ornek()" style="width:300px; height:300px;">Volkan Alakent Javascript Eğitim Seti</textarea>

<script type="text/javascript" language="javascript">
// onselect 	:	Form içerisindeki bir elemanın metni seçilirse belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Seçim işlemi Gerçekleşti");
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
<div oncopy="ornek()">İsim Soyisim : Volkan Alakent</div>

<script type="text/javascript" language="javascript">
// oncopy 	:	Form veya belge içerisindeki bir elemanın metin içeriği kullanıcı tarafından kopyalandığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("İçerik Kopyalandı!");
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
<div contenteditable="true" oncut="ornek()">Volkan Alakent Javascript Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// oncut 	:	Form veya belge içerisindeki bir elemanın metin içeriği kullanıcı tarafından kesildiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Metin içeriği kesildi");
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
<p contenteditable="true" onpaste="ornek()">Volkan Alakent javascript Eğitim Seti</p>

<script type="text/javascript" language="javascript">
// onpaste 		:	Form veya belge içerisindeki bir elemanın metin içeriğine kullanıcı tarafından herhangi bir içerik yapıştırıldığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Yapıştırma işlemi gerçekleşti");
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
<span draggable="true" ondrag="ornek()">Javascript</span>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// ondrag 	:	Belge içerisindeki herhangi bir eleman sürüklendiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("sonuc").innerHTML += "Sürükleniyor ";
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
<span draggable="true" ondragstart="ornek()">Javascript Eğitim Seti</span>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// ondragstart		:	Belge içerisindeki herhangi bir eleman sürüklenmesi başladığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("sonuc").innerHTML += "Sürüklenme Başladı";
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
<div draggable="true" ondragend="ornek()">Javascript Eğitim Seti</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// ondragend 	:	Belge içerisindeki herhangi bir elemanın sürüklenmesi bittiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("sonuc").innerHTML = "Sürükle Bitti";
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
.hedefalani{
	border:1px solid black;
	width:250px;
	height:50px;
}
</style>
</head>

<body>
<span draggable="true">Javascript</span><br /><br /><br /><br /><br />
<div id="hedef" class="hedefalani" ondragenter="ornek()"></div>
<div id="yazialani"></div>

<script type="text/javascript" language="javascript">
// ondragenter		:	Belge içerisindeki herhangi bir elemanın hedef kapsama alanı üzerine giriş yaptığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("hedef").style.borderColor = "red";
	document.getElementById("hedef").style.backgroundColor = "yellow";
	document.getElementById("yazialani").innerHTML = "Sürüklenen Nesne Hedefe Giriş Yaptı";
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
<span draggable="true">Volkan Alakent</span><br /><br /><br />
<div id="hedef" style="background-color:yellow; border:1px solid black; text-align:center; width:500px; height:250px;" ondragleave="ornek()">Hedef</div>
<div id="metin"></div>

<script type="text/javascript" language="javascript">
// ondragleave	:	Belge içerisindeki herhangi bir elemanın hedef kapsama alanından çıkış yaptığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("metin").innerHTML = "Eleman Hedef Alanından Çıkış Yaptı.";
	document.getElementById("hedef").style.backgroundColor = "#FFFFFF";
	document.getElementById("hedef").style.borderColor = "blue";
	document.getElementById("hedef").style.color = "blue";
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
	border:3px double #3D3D3D;
	background-color:#F1F1F1;
	padding:5px;
	text-align:center;
	width:500px;
	height:300px;
}
</style>
</head>

<body>
<span draggable="true">Javascript</span><br /><br /><br /><br /><br />
<div id="hedef" class="ornek" ondragover="deneme()">Hedef</div><br />
<div id="metin"></div>

<script type="text/javascript" language="javascript">
// ondragover	:	Belge içerisindeki herhangi bir elemanın hedef kapsama alanı üzerindeyken belirtilecek olan fonksiyon çalışır.

function deneme(){
	document.getElementById("metin").innerHTML += "Eleman Hedef Üzerinde ";
	document.getElementById("hedef").style.backgroundColor = "black";
	document.getElementById("hedef").style.color = "white";
	document.getElementById("hedef").style.borderColor = "red";
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
.bicimlendirme{
	border:1px solid black;
	width:250px;
	height:25px;
	margin:20px;
	padding:20px;
	float:left;
	text-align:center;
}
</style>
</head>

<body>
<div>İşlem Sonucu : <span id="metinalani"></span></div><br /><br />

<div class="bicimlendirme" ondrop="birakildi(event)" ondragover="uzerinde(event)" ondragleave="ayrildi(event)">
	<span id="kimlik" ondragstart="basladi(event)" draggable="true">Javascript</span>
</div>

<div class="bicimlendirme" ondrop="birakildi(event)" ondragover="uzerinde(event)" ondragleave="ayrildi(event)"></div>

<script type="text/javascript" language="javascript">

function basladi(event){
	event.dataTransfer.setData("TasinanEleman", event.target.id);
	//document.getElementById("metinalani").innerHTML = "Sürükleme Başladı";
}

function uzerinde(event){
	event.preventDefault();
	document.getElementById("metinalani").innerHTML = "Hedef üzerine Gelindi";
}

function ayrildi(event){
	document.getElementById("metinalani").innerHTML = "Hedef üzerinenden Çıkıldı";
}

function birakildi(event){
	event.preventDefault();
	var veri	=	event.dataTransfer.getData("TasinanEleman");
	event.target.appendChild(document.getElementById(veri));
	document.getElementById("metinalani").innerHTML = "Eleman Bırakıldı";
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

<body onbeforeprint="ornek()">
Volkan Alakent Javascript Eğitim Seti

<script type="text/javascript" language="javascript">
// onbeforeprint 	:	Belge içeriği kullanıcı tarafından yazdırılmak istendiğinde yazdırma işlemi başlamadan belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Yazdırma işlemi birazdan başlayacak");
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

<body onafterprint="ornek()">
Volkan Alakent Javascript Eğitim Seti

<script type="text/javascript" language="javascript">
// onafterprint 	:	Belge içeriği kullanıcı tarafından yazdırılmak istendiğinde yazdırma işlemi başladıktan sonra belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Yazdırma işlemi başladı");
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
<button onclick="ornek(event)">Tıkla</button>
<div onmouseover="ornek(event)">Javascript Eğitim Seti</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// type 	:	Belge içerisinde tanımlı herhangi bir event (olay) türü adının referansını elde etmek için kullanılır.

function ornek(event){
	var tur		=	event.type;
	document.getElementById("sonuc").innerHTML = "Event Türü : " + tur;
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

<body onclick="ornek(event)">
<div><span>Eğitim Seti Adı : </span>Javascript</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// currentTarget 	:	Belge içerisinde tanımlı event'ı (olayı) tetikleyen herhangi bir HTML elemanının event (olay) işaretleyicileri / dinleyicileri tarafından tag (etiket) adı referansını elde etmek için kullanılır.

function ornek(event){
	var deger	=	event.currentTarget.nodeName;
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

<body onclick="ornek(event)">
<div><span>Eğitim Seti Adı : </span>Javascript</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// target 	:	Belge içerisinde tanımlı event'ı (olayı) tetikleyen herhangi bir HTML elemanının tag (etiket) adı referansını elde etmek için kullanılır.

function ornek(event){
	var deger	=	event.currentTarget.nodeName;
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
<button onclick="ornek(event)">Tıkla</button>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// timeStamp 	:	Belge içerisinde tanımlı event'ın (olayın) oluşturulduğu zaman ile çalıştırıldığı zaman arasındaki fark süresinin mikrosaniye olarak referansını elde etmek için kullanılır.

function ornek(event){
	var zamanfarki	=	event.timeStamp;
	document.getElementById("sonuc").innerHTML = "Tıklama oldu " + "Event'ın (Olayın) oluşturulma ve çalıştırılma arasındaki zaman farkı (mikrosaniye) : " + zamanfarki;
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
<button onclick="ornek(event)">Tıkla</button>

<script type="text/javascript" language="javascript">
// cancelable 	:	Belge içerisinde tanımlı event'ın (olayın) iptal edilebilir olup olmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

function ornek(event){
	var sonuc	=	event.cancelable;
	if(sonuc==true){
		alert("Event (Olay) iptal edilebilir");
	}else{
		alert("Event (Olay) iptal edilemez");
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
<a href="https://www.google.com.tr">Google'a Git</a>

<script type="text/javascript" language="javascript">
// preventDefault() 	:	Belge içerisinde tanımlı event'ın (olayın) işlevini kaldırmak / iptal etmek / geçersiz kılmak için kullanılır.

document.getElementsByTagName("A")[0].addEventListener("click", function(event){
	event.preventDefault();
});

</script>
</body>
</html>

<!-- Örnek -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
Alışveriş : <input id="alan" type="checkbox">

<script type="text/javascript" language="javascript">
// preventDefault() 	:	Belge içerisinde tanımlı event'ın (olayın) işlevini kaldırmak / iptal etmek / geçersiz kılmak için kullanılır.

document.getElementById("alan").addEventListener("click", function(event){
	event.preventDefault();
});

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
<a id="kimlik" href="https://www.google.com.tr" onclick="ornek(event)">Google'a Git</a>

<script type="text/javascript" language="javascript">
// defaultPrevented 	:	Belge içerisinde tanımlı event (olay) için preventDefault() metodunun çağrılıp çağrılmadığını kontrol ederek boolean (mantıksal) veri türünde sonucu geriye döndürür.

function ornek(event){
	var sonuc	=	event.defaultPrevented;
	alert(sonuc);
}

</script>
</body>
</html>
```
