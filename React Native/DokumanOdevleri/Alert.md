## Alert
***
Başlığı ve mesajı olan uyarıları yada onay almak için kullanılan iletişim kutusu başlatır. İsteğe bağlı olarak düğme listesi sağlayabiliyorsunuz. Açılan iletişim kutusunda herhangi bir düğmeye dokunduğunda ilgili onPress callBack'i tetikler ve pencereyi kapatır. 
Varsayılan olarak iletişim kutusu penceresinde 'Tamam(Ok)' düğmesi olmaktadır.
Hem Android hem de iOS üzerinde çalışan ve statik uyarılar gösterebilen bir API'dir. iOS'ta yalnızca kullanıcıdan bazı bilgileri girmesini isteyen uyarı mevcuttur.
***
### Example
```JS
import React, { useState } from "react";
import { View, StyleSheet, Button, Alert } from "react-native";
//Kullanılması için ilk olarak kütüphanesi tanımlanmalıdır 

const App = () => {
  const createTwoButtonAlert = () => //iki alertli buton 
    Alert.alert(
       "Alert Başlığı", //Alert başlığı yazılmalısı gereklidir.
       "My Alert Msg", //Alert mesajı
      [
        {  //Button konsepti olarak negative(Negatif) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.      
          text: "Cancel",
          onPress: () => console.log("Cancel Pressed"),
          style: "cancel" //3 Stil vardır: default,cancel ve destructive
        },
        { //Button konsepti olarak positive(Pozitif) kullanılmaktadır. Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
            text: "OK", 
            onPress: () => console.log("OK Pressed") 
        }
      ]
    );

  const createThreeButtonAlert = () => // Android'de en fazla üç button belirtilebilir. 3 buttonlu Alert
    Alert.alert(
      "Alert Title",
      "My Alert Msg",
      [
        { //Button konsepti olarak neutral(Nötr) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
          text: "Ask me later",
          onPress: () => console.log("Ask me later pressed")
        },
        {//Button konsepti olarak negative(Negatif) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
          text: "Cancel",
          onPress: () => console.log("Cancel Pressed"),
          style: "cancel",
          

        },
        { //Button konsepti olarak positive(Pozitif) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
            text: "OK", onPress: () => console.log("OK Pressed") 
        }
      ],
    );

  return (
    <View style={styles.container}>
      <Button title={"2-Button Alert"} onPress={createTwoButtonAlert} />
      <Button title={"3-Button Alert"} onPress={createThreeButtonAlert} />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "space-around",
    alignItems: "center"
  }
});

export default App;

```
***
### iOS

iOS'ta istediğiniz sayıda button belirleyebilirsiniz. Her button isteğe bağlı olarak stil belirlenebilir, mevcut seçenekler AlertButtonStyle enum ile temsil edilir.
### Android
Android'de en fazla üç button belirtilebilir. Androide kulllanılan konsepler ise neutral(Nötr), negative(Negatif) ve positive(Pozitif) buttonlarıdır:
1. Eğer bir buton kullanılıyorsa kullanılan konsept 'positive(pozitif)' olmalıdır('Ok' yada 'Tamam' gibi).
2. Eğer iki buton kullanılıyorsa kullanılan konsept 'negative(Negatif)'ve 'positive(pozitif)' olmalıdır('Ok(Tamam)' ve 'Cancel(İptal)' gibi).
3. Eğer üç buton kullanılıyorsa kullanılan konsept neutral(Nötr),'negative(Negatif)'ve 'positive(pozitif)' olmalıdır('Ok(Tamam)','Latter(Daha Sonra)' ve 'Cancel(İptal)' gibi).

Android'deki Alertler, alert kutusunun dışına dokunularak kapatılabilir. Varsayılan olarak bu özellik devre dışıdır. Bu özellik iptal edilebilir özelliği true olarak ayarlanmış isteğe bağlı bir Seçenekler parametresi sağlanarak etkinleştirilebilir { cancelable: true }.

Olay iptal etmek için options parametresi içinde bir onDismiss callback özelliği sağlanarak işlenebilir.
***
###  Example (Android)

```JS
import React from "react";
import { View, StyleSheet, Button, Alert } from "react-native";
//Kullanılması için ilk olarak kütüphanesi tanımlanmalıdır 

const showAlert = () =>
  Alert.alert(
    "Alert Başlığı", //Alert başlığı yazılmalısı gereklidir.
    "My Alert Msg", //Alert mesajı
    [
      {//Button konsepti olarak positive(Pozitif) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
        text: "Cancel",
        onPress: () => Alert.alert("Cancel Pressed"),
        style: "cancel", ///3 Stil vardır: default,cancel ve destructive
      },
    ],
    {
      cancelable: true, //alert kutusunun dışına dokunularak kapatılabilmek için true yapılmaktadır
      onDismiss: () => //cancelable callback fonksiyorundur. İsteğe bağlı kullanımdır.
        Alert.alert(
          "This alert was dismissed by tapping outside of the alert dialog."
        ),
    }
  );

const App = () => (
  <View style={styles.container}>
    <Button title="Show alert" onPress={showAlert} />
  </View>
);

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center"
  }
});

export default App;
```

***
###  Reference
###  Methods
#### alert()
```JS
static alert(title, message?, buttons?, options?)
```
##### Parameters:

| NAME     |  TYPE                      | DESCRİPTION          |                
|--------:|----------------------------|:--------------------:|
|  title (Required) |    string                  |  İletişim kutusunun başlığı. Null veya boş dize geçmek başlığı gizleyecektir. |                
|message  |  string                 | İletişim kutusunun başlığının altında görünen isteğe bağlı bir mesaj.| 
|buttons  |    Buttons              |Düğme yapılandırmasını içeren isteğe bağlı bir dizi.|                   
|options  |      Options               | İsteğe bağlı bir Uyarı yapılandırması.|        

#### prompt() iOS
```JS
static prompt(title, message?, callbackOrButtons?, type?, defaultValue?, keyboardType?)
``` 
Uyarı biçiminde bir metin girmek için bir bilgi istemi oluşturun ve görüntüleyin.
##### Parameters:
|NAME     | TYPE                       | DESCRIPTION          |                   
|--------:|----------------------------|:--------------------:|
|title (Required)|    string        |   İletişim kutusunun başlığı. |                   
|     message    |             string        |  Metin girişinin üzerinde görünen isteğe bağlı bir mesaj.  |           
|  callbackOrButtons | function   |  Bir işlev iletilirse, kullanıcı 'Tamam'a dokunduğunda bilgi isteminin değeri (metin: dize) => void ile çağrılır. |             
|    callbackOrButtons      |  Buttons | Bir dizi iletilirse, düğmeler dizi içeriğine göre yapılandırılacaktır. |         
|  type |       AlertType |   Bu, metin girişini yapılandırır.|                   
|   defaultValue |  string   | Metin girişinde varsayılan metin.|  
|  keyboardType | string         |İlk metin alanının klavye türü (varsa). TextInput klavye türlerinden biri.  |                   
|     options    |    Options   |  İsteğe bağlı bir Uyarı yapılandırması.                     | 
***
###  Type Definitions
#### AlertButtonStyle (iOS)
İOS için Alert button sitili
| TYPE |
|--------:|
|  enum  |
##### Constants:
| VALUE | DESCRIPTION | 
|--------:|----------------------------|
|'default'| Varsayılan button stili.|   
| 'cancel'|Cancel button sitili |      
|'destructive'|Destructive button sitili|         
***
#### AlertType (iOS)
İOS için Alert tipi
| TYPE |
|--------:|
|  enum  |
##### Constants:
| VALUE | DESCRIPTION | 
|--------:|----------------------------|
|'default'| Girişsiz varsayılan uyarı|   
| 'plain-text'|Düz metin girişi uyarısı |      
|'secure-text'|Güvenli metin girişi uyarısı|         
|'login-password'| Giriş ve şifre uyarısı| 
***
#### Buttons
Alert button yapılandırmasını içeren nesneler dizisi.
| TYPE |
|--------:|
|  Array objesi  |
##### Objects properties:
|NAME     |  TYPE                      | DESCRİPTION          |                
|--------:|----------------------------|:--------------------:|
|text |    string                  | Button etiketi |                
|onPress  |  function                 | Düğmeye basıldığında geri arama işlevi.| 
|style (iOS)  |    AlertButtonStyle           |Düğme stili, Android'de bu özellik yok sayılır.| 
***
#### Options
| TYPE |
|--------:|
|  object  |
##### Properties:
|NAME     |  TYPE                      | DESCRİPTION          |                
|--------:|----------------------------|:--------------------:|
|cancelable (Android)| boolean   | Uyarı kutusunun dışına dokunularak uyarının kapatılıp kapatılamayacağını tanımlar. |                
|userInterfaceStyle (iOS) |  string  | Uyarı için kullanılan arayüz stili açık veya koyu olarak ayarlanabilir, aksi takdirde varsayılan sistem stili kullanılacaktır.| 
|onDismiss (Android) |    	function           |Uyarı kapatıldığında geri arama işlevi başlatıldı.| 

