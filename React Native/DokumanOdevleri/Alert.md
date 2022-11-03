## Alert
***
Başlığı ve mesajı olan uyarıları yada onay almak için kullanılan iletişim kutusu başlatır. İsteğe bağlı olarak düğme listesi sağlayabiliyorsunuz. Açılan iletişim kutusunda herhangi bir düğmeye dokunduğunda ilgili onPress callBack'i tetikler ve pencereyi kapatır. 
Varsayılan olarak iletişim kutusu penceresinde 'Tamam(Ok)' düğmesi olmaktadır.
Hem Android hem de iOS üzerinde çalışan ve statik uyarılar gösterebilen bir API'dir. iOS'ta yalnızca kullanıcıdan bazı bilgileri girmesini isteyen uyarı mevcuttur.
***
### Example
```JS


```
***
### iOS

iOS'ta istediğiniz sayıda button belirleyebilirsiniz. Her button isteğe bağlı olarak stil belirlenebilir, mevcut seçenekler AlertButtonStyle enum ile temsil edilir.
### Android
Android'de en fazla üç düğme belirtilebilir. Androide kulllanılan konsepler ise neutral(Nötr), negative(Negatif) ve positive(Pozitif) buttonlarıdır:
1. Eğer bir buton kullanılıyorsa kullanılan konsept 'positive(pozitif)' olmalıdır('Ok' yada 'Tamam' gibi).
2. Eğer iki buton kullanılıyorsa kullanılan konsept 'negative(Negatif)'ve 'positive(pozitif)' olmalıdır('Ok(Tamam)' ve 'Cancel(İptal)' gibi).
3. Eğer üç buton kullanılıyorsa kullanılan konsept neutral(Nötr),'negative(Negatif)'ve 'positive(pozitif)' olmalıdır('Ok(Tamam)','Latter(Daha Sonra)' ve 'Cancel(İptal)' gibi).

Android'deki Alertler, alert kutusunun dışına dokunularak kapatılabilir. Varsayılan olarak bu özellik devre dışıdır. Bu özellik iptal edilebilir özelliği true olarak ayarlanmış isteğe bağlı bir Seçenekler parametresi sağlanarak etkinleştirilebilir { cancelable: true }.

Olay iptal etmek için options parametresi içinde bir onDismiss callback özelliği sağlanarak işlenebilir.
***
###  Example (Android)

```JS


```

***
###  Reference
###  Methods
#### alert()
```JS
static alert(title, message?, buttons?, options?)
```
##### Parameters:

|NAME     |  TYPE                      | DESCRİPTION          |                
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

