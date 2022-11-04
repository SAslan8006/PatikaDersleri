## Dimensions Kullanımı
***
useWindowDimensions, React bileşenlerinde tercih edilen API'dir. Kullanıcının farklı ekranlarda kullandıkça boyutlar güncellenir. React paradigmasıyla iyi çalışır.Bu komutu style sayfasında kullanarak resimlerimizin yada menülerimizin boyutlarını buradan şekillendirebiliriz. Bu şekilde tüm telefon ekranlarında düzgün görünmesini sağlayabiliriz.
İlk olarak çalışması için asağıdaki kütüphane import edilmelidir;
```JS
import { Dimensions } from 'react-native'; 
```
Aşağıdaki kodu kullanarak bir sabite uygulama penceresinin genişliğini ve yüksekliğini alabilirsiniz:
```JS
const windowWidth = Dimensions.get('window').width;
const windowHeight = Dimensions.get('window').height;
```
```
 Not:Ekran boyutlar hemen kullanılabilir olsa da değişebilirler (ör. Telefonu döndürme, katlanama vb. nedeniyle), 
 bu nedenle değerleri sabit değişkene atamak yerine StyleSheet'te bir değerde kullanılımalıdır.
```
```JS
Stylede:
 banner_image: {
    height: Dimensions.get('window').height / 5,
    width: Dimensions.get('window').width / 2,
  } 
//bu şekilde get ile ekran genişliğini alabiliriz.
```
Katlanabilir cihazları veya ekran boyutunu veya uygulama penceresi boyutunu değiştirebilen cihazları hedefliyorsanız, aşağıdaki örnekte gösterildiği gibi Dimensions modülünde bulunan olay dinleyicisini kullanabilirsiniz. Ek olarak konu örneği linktedir: https://github.com/SAslan8006/PatikaDersleri/tree/master/React%20Native/news_App
Örneğin ; 
```JS
import React, { useState, useEffect } from "react";
//İlk olarak çalışması için asağıdaki kütüphane import edilmelidir
import { View, StyleSheet, Text, Dimensions } from "react-native";

const window = Dimensions.get("window"); //window değerini alığ window constuna atanmıştır.
const screen = Dimensions.get("screen"); //screen değerini alığ screen constuna atanmıştır.

const App = () => {
  const [dimensions, setDimensions] = useState({ window, screen });

  useEffect(() => {
  //Kodda, ekranda herhangi bir değişiklik yapıldığında, "change" ile değerlerde değişiklik yapması için yazılmıştır.
    const subscription = Dimensions.addEventListener(
      "change",
      ({ window, screen }) => {
        setDimensions({ window, screen });
      }
    );
    return () => subscription?.remove();
  });
 
  return (
    <View style={styles.container}>
      <Text style={styles.header}>Window Dimensions</Text>
      {Object.entries(dimensions.window).map(([key, value]) => (
        <Text>{key} - {value}</Text>
      ))}
      <Text style={styles.header}>Screen Dimensions</Text>
      {Object.entries(dimensions.screen).map(([key, value]) => (
        <Text>{key} - {value}</Text>
      ))}
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center"
  },
  header: {
    fontSize: 16,
    marginVertical: 10
  }
});

export default App;
```
### Kullanılan Methodlar: 
#### addEventListener(type, handler) :
Bir olay Eventi eklememize yardımcı olur. Bu event sayesinde ekran değiştiğinde değerleri yeniden alabilmemizi sağlar.Desteklenen event ise ;
#### change:
Dimensions nesnesindeki bir özellik değiştiğinde tetiklenir. Olay işleyicisinin bağımsız değişkeni, DimensionsValue türünde bir nesnedir.
#### get(dim): 
İlk ekran boyutu runApplication çağrısı yapılmadan önce ayarlanmaktadır. Bu yüzden diğer ihtiyaçlar çalıştırılmadan önce kullanılabilir olmasını sağlar ancak daha sonra ekran boyutu güncellenebilir.Örneğin;
```JS
const {height, width} = Dimensions.get('window');
//window yazısı zorunlu girilmelidir. get ile değer dimension için çağrılırken set methodu değeri döndürür.
```
#### removeEventListener(type, handler):
Kullanımdan kaldırılmıştır. addEventListener() tarafından döndürülen remove() yöntemini kullanılabilir. Örneğin: 

```JS
useEffect(() => {
 //Kodda, ekranda herhangi bir değişiklik yapıldığında, "change" ile değerlerde değişiklik yapması için yazılmıştır.
    const subscription = Dimensions.addEventListener(
      "change",
      ({ window, screen }) => {
        setDimensions({ window, screen });
      }
    );
    return () => subscription?.remove();
});
```
#### set(dims):
Bu method, yalnızca didUpdateDimensions olayı gönderilerek native code den çağrılmaktadır. Set methodu gönderilir dönüşünü get methodu yapmaktadır.


