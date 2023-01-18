// Cok Kullanilan Array(Dizi) Metotlari ve Array icinde Array
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array
// https://www.w3schools.com/js/js_array_methods.asp

let items = [1, 2, 3, 4, 5] 

// Array icinde Array:
let femaleUsers = ["Ayse", "Hulya", "Merve"]
let maleUsers = ["Ahmet", "Hasan", "Mehmet"]

items.unshift(femaleUsers) //başına ekleme

items.push(maleUsers) //sonuna ekleme

console.log(items)

console.log(items.length)
console.log(items[0].length) // Array icindeki istedigimiz Array'in length bilgisini aldik
console.log(items[0][0]) // Ayse bilgisine ulastik :)

// Array icerisinden oge ayirmak -> splice(pos, item?)
let newItems = items.splice(1, 5)

console.log("newItems: ", newItems)
console.log("items: ", items)
// Array icerisindeki ogenin index bilgisini bulmak -> indexOf('value')
items.unshift("lorem")
items.push("ipsum")

console.log( items.indexOf("ipsum") )

// Array Kopyalamak -> slice, [...ES6]
let copyItems = items
console.log(items)

copyItems.pop() // son ogeyi cikarttik
console.log("copyItems", copyItems)
console.log("items", items)

console.log("kopyalandiktan sonraki hali:")
copyItems = items.slice() // kopyalama yapti
copyItems.pop() // son ogeyi cikarttik
console.log("copyItems", copyItems)
console.log("items", items)

let es6Items = [...items] // es6 ve sonrasinda gelen kopyalama islemi
console.log(es6Items)

// Iki Array Bilgisini Birlestirmek -> [...ES6, ...ES6]
let allUsers = [...femaleUsers, ...maleUsers] // es6 birden fazla array yapisini birlestirmek
console.log(allUsers)

// Array icerisindeki bilgiyi String'e cevirmek -> toString, join
console.log(allUsers.toString())
console.log(allUsers.join(" --- "))


// Istedigimiz Index Bilgisine Oge Eklemek -> splice(index, 0, value)
allUsers.splice(allUsers.length -1, 0, "Melissa")
allUsers.splice(Math.floor( allUsers.length / 2 ), 0, "Lorem")
console.log(allUsers)

const alisverisListem = ["elma", "ekmek", "süt"];

const elmaVar = alisverisListem.includes("elma");
console.log(elmaVar);
const a="elma"

// Dizi içerisinde elma olduğu için true yazdırmasını bekleriz.
console.log(alisverisListem.includes(a))

const armutVar = alisverisListem.includes("armut");
console.log(armutVar);
// Dizi içerisinde armut olmadığı için ekrana false yazdırmasın


const yeniAlisverisListem = alisverisListem.slice(0,2);
// "elma"dan başlayıp "süt"e kadar olan elemanları kopyala."süt" dahil değil.

console.log(yeniAlisverisListem);
// ["elma", "ekmek"] görmeyi bekleriz.

const stringAlisverisListem =  alisverisListem.join();
console.log(stringAlisverisListem);
// Çıktıda "elma,ekmek,süt" bekleriz.

const stringAlisverisListem2 = alisverisListem.join(" kiraz ");
console.log(stringAlisverisListem2);
// Çıktıda "elma kiraz ekmek kiraz süt" bekleriz.

const yiyecekler = ["pasta", "baklava", "puding"];
const icecekler = ["su", "kahve"];

const menu = yiyecekler.concat(icecekler);
console.log(menu);
// Çıktıda ["pasta", "baklava", "puding", "su", "kahve"] bekleriz.

// Malzemeler dizisindeki her bir malzemeyi ve onun indeksini konsola yazdıran bir kod yazalım:

const malzemeler = ["yumurta", "un", "süt"];

malzemeler.forEach(function(malzeme, malzemeIndeksi) {
    console.log(malzeme, malzemeIndeksi);
});

// console.log() fonksiyonu her bir malzeme için ayrı ayrı çalışacağından çıktı olarak tüm malzemeleri (ve indekslerini) alt alta görürüz.

const sayilar = [1,2,3];

let sayilarin5kati = sayilar.map(function(sayi) {
    return sayi*5;
});

console.log(sayilarin5kati);
// Çıktı olarak [5,10,15] görmeyi bekleriz.

console.log(sayilar);
// Çıktı olarak [1,2,3] görmeyi bekleriz. Orijinal dizimiz aynı kalır.

const sayilar1 = [4,5,6];

// sonucu görebilmek çıktıyı sonuc adlı değişkende tutalım:
const sonuc1 = sayilar1.some(function(sayi) {
    return sayi > 5 ;
});

console.log(sonuc1);
// Dizi içerisinde 5'ten büyük bir eleman bulunduğu için çıktıda "true" görmeyi bekleriz.


const sonuc2 = sayilar1.some(function(sayi) {
    return sayi <3;
});

console.log(sonuc2);
// Dizi içerisinde 3'ten küçük herhangi bir sayı olmadığı için çıktıda "false" görmeyi bekleriz. 

const sayilar2 = [3,5,2,10,4];

sayilar2.sort(function(a,b) {
    return b-a;
});
console.log(sayilar2);
// Çıktı olarak [10, 5, 4, 3, 2] alırız.