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

```Html

```

```Html

```

```Html

```

```Html

```