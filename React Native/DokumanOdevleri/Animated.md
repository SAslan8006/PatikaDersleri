## Animated
***
Animated kütüphanesi, animasyonları akıcı, güçlü ve ağrısız hale getirmek ve sürdürmek için tasarlanmıştır. Animated, girdiler ve çıktılar arasındaki bildirimsel ilişkilere, aradaki yapılandırılabilir dönüşümlere ve zamana dayalı animasyon yürütmesini kontrol etmek için start/stop yöntemlerine odaklanır. Bileşenlerin style özellikleri değiştirilerek kullanıcıya akıcı bir deneyim sunar.Bir animasyon oluşturmak için temel iş akışı, bir 'Animated.Value' oluşturmak, onu animasyonlu bir bileşenin bir veya daha fazla stil özelliğine bağlamak ve ardından 'Animated.timing()' kullanarak animasyonlar aracılığıyla güncellemeleri yönlendirmek.

```
Not: Animasyonlu değeri doğrudan değiştirmeyin. Değişken bir ref nesnesi döndürmek için 'useRef Hook'u kullanabilirsiniz. 
Bu ref nesnesinin geçerli özelliği, verilen argüman olarak başlatılır ve bileşen yaşam döngüsü boyunca devam eder.
```
***
### Example
Aşağıdaki örnek, animasyonlu 'fadeAnim' değerine bağlı olarak solup sönecek bir 'View' içermektedir.
```JS
import React, { useRef } from "react";
import { Animated, Text, View, StyleSheet, Button, SafeAreaView } from "react-native";
//Kullanılması için ilk olarak kütüphanesi tanımlanmalıdır 
const App = () => {
  // opaklık değeri olarak fadeAnim kullanılacak. Başlangıç ​​değeri: 0
  const fadeAnim = useRef(new Animated.Value(0)).current;

  const fadeIn = () => {
    // fadeAnim değerini 5 saniyede 1 olarak değiştirecek
    Animated.timing(fadeAnim, {
      toValue: 1,
      duration: 5000
    }).start();
  };

  const fadeOut = () => {
    // FadeAnim değerini 3 saniyede 0 olarak değiştirecek
    Animated.timing(fadeAnim, {
      toValue: 0,
      duration: 3000
    }).start();
  };

  return (
    <SafeAreaView style={styles.container}>
      <Animated.View
        style={[
          styles.fadingContainer,
          {
           // Opaklığı canlandırılmış değere bağla
            opacity: fadeAnim
          }
        ]}
      >
        <Text style={styles.fadingText}>Fading View!</Text>
      </Animated.View>
      <View style={styles.buttonRow}>
        <Button title="Fade Başlat" onPress={fadeIn} />
        <Button title="Fade Kapat" onPress={fadeOut} />
      </View>
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: "center",
    justifyContent: "center"
  },
  fadingContainer: {
    padding: 20,
    backgroundColor: "powderblue"
  },
  fadingText: {
    fontSize: 28
  },
  buttonRow: {
    flexBasis: 100,
    justifyContent: "space-evenly",
    marginVertical: 16
  }
});

export default App;
``` 
***
### Overview
'Animated' ile kullanabileceğiniz iki değer türü vardır:
1. 'Animated.Value()' tek değerler için
2.  'Animated.ValueXY()' vektörler için 
'Animated.Value' stil özelliklerine veya diğer aksesuarlara bağlanabilir ve ayrıca enterpolasyon yapılabilir. Tek bir 'Animated.Value' herhangi bir sayıda mülkü çalıştırabilir.
#### Configuring animations
Animated kütüphanesinin içerisinde, animasyon oluşturmayı sağlayan üç farklı metod vardır. Her animasyon türü, değerlerinizin başlangıç değerinden son değerine kadar nasıl canlandırılacağını kontrol eden belirli bir animasyon eğrisi sağlar:
1. Animated.decay(): Bu fonksiyon, başlangıçta verilen hız ile animasyon başlatır ve yavaş yavaş bitirir.
```JS
Animated.decay(value, {  
  toValue: 100,  
}).start(); 
``` 
2. Animated.spring(): Fnskiyon, bir yay hareketi olarak düşünülebilir. Yaylar sıkışır ve eski hallerine geri dönerler. Ancak eski hallerine hemen değil birkaç seferde ulaşırlar. Animasyonda bu mantıkla çalışır. Örneğin, bir bileşen belirli bir büyüklüğe gelip tekrar eski haline dönerken birkaç adımda bu gerçekleşir. Veya bir bileşen ekranın sol tarafından gelip sağ tarafta çarpma efekti yaratıp orada durur.
```JS
Animated.spring(value, {  
  toValue: 100,  
  friction: 5  
}).start();  
``` 
3. Animated.timing(): Bu fonksiyon bileşenin hareket hızını zamanla değiştirmek için kullanılır. Örneğin 3 saniye içerisinde ekranın sol tarafından sağ tarafına doğru hareket et gibi.
```JS
Animated.timing(value, {  
  toValue: 100,  
  duration: 2000  
}).start();    
``` 


