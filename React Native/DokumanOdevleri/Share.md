## Share
***
  Uygulama içindeki ürünleri, öğeleri veya sayfaları paylaşmak için kullanılmaktadır. Linkedn veya herhangi uygulamadaki birinin profil sayfasını ilgilenebilecek bir arkadaşınızla paylaşmak için kullanıcılara bir “Tavsiye Et” düğmesi eklenebilir. Market uygulamaları, kullanıcının bir ürünün sayfasını başka birine hızlı bir şekilde göndermesine izin vermek için 'share' özelliklerini kullanabilir.
  Uygulamaların veya oyunların sosyal medya ile entegrasyonunda ve uygulamaların /oyunun topluluk oluşturmasına yardımcı olarak kullanılabilir.
### Example
```JS
import React from 'react';
//Kullanılması için ilk olarak kütüphanesi tanımlanmalıdır 
import { Share, View, Button } from 'react-native';

const ShareExample = () => {
  const onShare = async () => {
    try {
      const result = await Share.share({
        message:
        //share komutundaki penceredeki yazacak mesaj buraya yazılmaktadır.
          'React Native | A framework for building native apps using React',
      });
      if (result.action === Share.sharedAction) {
        if (result.activityType) { //Aktivite burada kontrol ediliyor if döngüsüyle
          // aktivite türüyle paylaşım  result.activityType
        } else {
          // paylaşım
        }
      } else if (result.action === Share.dismissedAction) {
        // dismissed
      }
    } catch (error) {
      alert(error.message);
    }
  };
  return (
    <View style={{ marginTop: 50 }}>
    {/* Eklenen butona onShare fonsiyonu eklenerek share api si eklenmiştir. */}
      <Button onPress={onShare} title="Share" />
    </View>
  );
};

export default ShareExample;
```
### Reference
***
#### Methods
##### share()
```JS
static share(content, options)
```
Metin içeriğini paylaşmak için bir iletişim kutusu açmaktadır.

iOS'ta, action ve ActivityType içeren bir nesneyle çağrılacak bir promise döndürür.Kullanıcı iletişim kutusunu kapattıysa, promise 'Share' eylemiyle çözülmeye devam edecektir. 'dismissedAction' ve diğer tüm anahtarlar tanımsız. Bazı paylaşım seçeneklerinin iOS simülatöründe görünmeyeceğini veya çalışmayacağını unutmayın.Android'de, eylemin Share.sharedAction olmasıyla her zaman çözülecek bir promise döndürür.

###### Properties:
| NAME     |  TYPE                      | DESCRİPTION          |                
|--------:|----------------------------|:--------------------:|
|  content (Required) |    object  | 1. message - a message to share  2. url - a URL to share (iOS) 3.title - title of the message (Android) 4. url ve message iletiden biri gereklidir.|                
|options  |  object                | 1. dialogTitle (Android) 2. excludedActivityTypes (iOS) 3. subject - a subject to share via email(iOS) 4. tintColor(iOS)|  
***
### Properties
#### sharedAction
```JS
static share(content, options)
```
İçerik başarıyla paylaşıldı.
#### dismissedAction (iOS)
```JS
static dismissedAction
```
Diyalog reddedildi.
