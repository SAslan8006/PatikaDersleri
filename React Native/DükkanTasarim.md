## Dükkan Tasarımı (WebApi-Customhook)
Bu yazımızda dükkanımıza nasıl api den veri cektiğimi anlatmaya calışacağım.

1. Navigation install aşamalarını yap. (https://reactnavigation.org/docs/getting-started/) ilk iki sayfayu uygulamalısın.
2. Stack kurulumun aşamalarını yap. (https://reactnavigation.org/docs/stack-navigator/)
3. https://github.com/luggit/react-native-config sayfasındaki ayarlamaları yapıyoruz.
4. https://www.npmjs.com/package/dotenv sayfasındaki ayarlamalar ve kurulumları yapıyoruz.
* npm install react-native-dotenv dosyasını yükle daha sonra ise
* babel.config.js dosyasına aşağıdaki kodu ekleyin.
*  plugins: [ ["module:react-native-dotenv", { "moduleName": "@env", "path": ".env", "blacklist": null, "whitelist": null, "safe": false, "allowUndefined": true }] ]  
* extra olarak yapılsa iyi olur :android/app/build.gradle dosya yoluna : apply from: project(':react-native-config').projectDir.getPath() + "/dotenv.gradle"   yazısını 2. satırına ekleyiniz.
* Daha sonra .env dosyasını gitignorenin bulundugu konuma oluşturup gerekli değerlerinizi giriniz. 
5. https://reactjs.org/docs/hooks-custom.html custom hooks yapısını entegre ettik yapımıza. Ek makale(https://erdemuslu.medium.com/custom-react-hooks-aa88c1305cef)
6. Sistemimiz animasyon kullanmak için : https://github.com/lottie-react-native/lottie-react-native paketini kuruyoruz.
7. https://lottiefiles.com/ sitesinde lottie animasyonlarımız indiriniz. indirim sırasında dosya formatı olarak json seçiyoruz.Dosyaları src klasorü altındaki assets klasor oluşturup içerisine kayıt ediyoruz. 
8. Lottide Android specific problems ler için https://www.npmjs.com/package/lottie-react-native en altına bakınız. 
9. Genellikle : android/app/src/main/java/\<AppName\>/MainApplication.java içerisine --- import com.airbnb.android.react.lottie.LottiePackage; --- eklemelisiniz hatası karşımıza çıkmaktadır. 



