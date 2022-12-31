# Vector Icons Kurulumu ve Kullanımı
## Kurulum Aşaması 
1. https://www.npmjs.com/package/react-native-vector-icons sitesine gidiyoruz. 
2. Kurulum aşamalarının en güncel hali her zaman https://github.com/oblador/react-native-vector-icons sitesinde bulabilirsiniz. Burada android için işlemler yapılmıştır. 
3. Ios kurulumu yukarıdaki linkteki işlemleri takip ederek ilerleyebilirsiniz. 
4. Son olarak yazılanları takip edip yapamamanız durumunda https://www.youtube.com/watch?v=R0KKUwN64hk linkteki videoyu izleyebilirsiniz. 
5. npm i react-native-vector-icons ile kurulumu terminalden projemize yapıyoruz. 
6. android/app/build.grandle  içerisine  yaklaşık 86 satıra şu kodu ekliyoruz...  
```JS
apply from: "../../node_modules/react-native-vector-icons/fonts.gradle"
```
isterseniz şeçime bağlı paketleride ekleyebilirsiniz.... yine aynı şekilde burada projeye dahil olmasını istediğiniz paketleri isimlerini ekleyebilirsiniz.
```JS
project.ext.vectoricons = [
    iconFontNames: [ 'MaterialIcons.ttf', 'EvilIcons.ttf' ] // Name of the font files you want to copy
]

apply from: "../../node_modules/react-native-vector-icons/fonts.gradle"
```
4. Aynı dosyanın içerisinide app/build.grandle nin içerisinde yaklaşık 256. satıra yani dependencies {... içerisine aşağıdaki kodu ekliyorsunuz
```JS
    implementation project(':react-native-vector-icons')  //Vector icons
```
Not: Önemli bir hatırlatma eğer bir paketi kurulumunu yaparken sonuna //Paket İsmini yazarak yorum bırakırsanız paketin yükleme aşamaları aklınızda kalmasa bile yorum satırını aratarak hangi işlemleri yaptığınız kayıt etmiş olursunuz. yine kurulum yapacağınızda size kolaylık olmuş olur
5. Son olarak ise android/settings.gradle içerisiniz 4 satır sonuna aşağıdaki kodu ekleyiniz. 
```JS
include ':react-native-vector-icons'  //Vector icons
project(':react-native-vector-icons').projectDir = new File(rootProject.projectDir, '../node_modules/react-native-vector-icons/android')  //Vector icons
```
## Kullanımı Ve Icon isimleri nereden alındığı
1. Vector icon kutüphanesi içerisindeki icon isimleri https://oblador.github.io/react-native-vector-icons/ sitesinde bakabilirsiniz kullanmak istediğiniz icon ismini kütüphanesini oradan seçebilirsiniz
2. Örneğin FontAwesome kütüphanesindeki music isimli iconu kullnacaksanız aşağıdaki kodları kullanırsınız: 
```JS
import React from 'react';
import {ActivityIndicator, Text, SafeAreaView } from 'react-native';
import Icon from 'react-native-vector-icons/FontAwesome';

export default App=()=> {  
    return (
      <SafeAreaView style={{flex:1,alignItems:'center',justifyContent:'center'}}>
        <Icon name='music' size={72} color="green" />
      </SafeAreaView>
    )
  }


```
