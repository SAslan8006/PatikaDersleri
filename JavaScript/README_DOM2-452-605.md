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