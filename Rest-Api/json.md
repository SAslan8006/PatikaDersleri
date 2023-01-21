# JSON Nedir?
JavaScript Object Notation ifadesinin kısaltmasıdır. Veri depolamak veya veri iletmek için kullanılan metin tabanlı bir söz dizimi yapısıdır. Genellikle bir sunucu ve istemci arasında veri alışverişi için veya yazılımların genel ayarları için kullanılan bir formattır.  

Drupal/config.json  
Node.js/package.json  
https://jsonplaceholder.typicode.com/users  
JSON Veri Tipleri   
String: "Sample String", "test1234", "A"   
Number: 7, 3.2, -97.238  
Boolean: true, false  
Null: null  
Array: [2,3,5,7] , ["İstanbul", "Ankara", "İzmir"] Array içerisinde kullanılan değerler sıralı olarak listelenebilir.
Object { "name": "Gürcan", "age":40 } JSON nesneleri verileri key-value çiftleri olarak tanımlar.
Yukarıda görmüş olduğunuz veri tiplerinin tamamı tekil olarak uygun bir JSON formatı işlevini görür. Ancak tek bir 3, string veya true gibi ifadeler için ayrı bir .json uzantılı dosya oluşturmak mantıklı değildir. Bu nedenle JSON doayaları bir array, nesne ve/veya bunların içiçe geçmiş formlarından oluşur.  

## Örnek :
```Js
movie.json
{
    "id":1,
    "title": "Matrix",
    "actors": ["Keanu Reeves", "Carrie Anne Moss"],
    "published_year": 1999,
    "genre": {
      "id": 6,
      "name": "Action"
    },
    "rating": 7.9
}   
```  
JSON dosyasının uygun formatta olup olmadığını kontrol etmek için JSONLINT ( https://jsonlint.com/ ) gibi çevrimiçi araçlar kullanabiliriz.  


Daha Fazlası İçin  
https://www.json.org/json-en.html   


# JSON - JavaScript - XML  
## JSON vs JavaScript  
JavaScript web uygulamalarında sıklıkla kullanılan dinamik bir programlama dilidir. JSON ise bir söz dizim olarak JavaScript'in bir alt kümesi olarak düşünülebilir. Bu nedenle uygun JSON formatındaki bir içerik JavaScript ifadesine (expression) denk gelir.  

{  
    "id":1,  
    "title": "Matrix",  
    "actors": ["Keanu Reeves", "Carrie Anne Moss"],  
    "published_year": 1999,  
    "genre": {  
      "id": 6,  
      "name": "Action"  
    },  
    "rating": 7.9  
}   
şeklindeki JSON söz dizimini bir JavaScript değişkenine atadığımızda, değişken değer olarak bir JavaScript nesnesini almış olur. JSON formatında key ifadelerin çift tırnak içerisine alınması zorunludur. Her ne kadar JSON söz dizimi olarak kendisine JavaScript'i örnek aldıysa da kullanımı bir çok programlama dili tarafında yaygındır.  

## JSON vs XML
### XML  
eXtensible Markup Language ifadesinin kısaltmasıdır. Veri depolamak ve iletmek için kullanılan bir script dilidir. 1998 yılında W3C tarafından standartlaştırılmıştır.  

<breakfast_menu><food><name>Belgian Waffles</name><price>$5.95</price><description>  
        Two of our famous Belgian Waffles with plenty of real maple syrup  
     </description><calories>650</calories></food>   
</breakfast_menu>  
Genel olarak ağaç yapısına (tree structure) sahiptir. Veriler açılış ve kapanış etiketlerinin içerisinde bulunur. Dıştaki etiket, içtekinin "parent"ı, içteki etiket ise dıştakinin "child"ı şeklinde düşünülür.  

JSON formatının XML formatına göre en büyük avantajı, doğalında bir nesne modeline sahip olmasıdır. Bu özellik sayesinde birçok programlama dili JSON verileri daha kolay bir şekilde işleyebilir.  


Daha Fazlası İçin  
W3Schools - XML
Erik Wilde - Youtube