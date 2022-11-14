## Dükkan Tasarımı (WebApi-Customhook)
Bu yazımızda dükkanımıza nasıl api den veri cektiğimi anlatmaya calışacağım.

1. Navigation install aşamalarını yap. (https://reactnavigation.org/docs/getting-started/) ilk iki sayfayu uygulamalısın.
2. Edit MainActivity.java file which is located in android/app/src/main/java/<your package name>/MainActivity.java.

Add the following code to the body of MainActivity class:

@Override
protected void onCreate(Bundle savedInstanceState) {
  super.onCreate(null);
}
and make sure to add the following import statement at the top of this file below your package statement:

    import android.os.Bundle;
3. Stack kurulumun aşamalarını yap. (https://reactnavigation.org/docs/stack-navigator/)
4. https://reactnavigation.org/docs/native-stack-navigator
5. https://github.com/luggit/react-native-config sayfasındaki ayarlamaları yapıyoruz.
  Extra step for Android
You'll also need to manually apply a plugin to your app, from android/app/build.gradle:

// 2nd line, add a new apply:
apply from: project(':react-native-config').projectDir.getPath() + "/dotenv.gradle"
  
6. https://www.npmjs.com/package/dotenv sayfasındaki ayarlamalar ve kurulumları yapıyoruz.
* npm install react-native-dotenv dosyasını yükle daha sonra ise
* babel.config.js dosyasına aşağıdaki kodu ekleyin.
*  plugins: [ ["module:react-native-dotenv", { "moduleName": "@env", "path": ".env", "blacklist": null, "whitelist": null, "safe": false, "allowUndefined": true }] ]  
* extra olarak yapılsa iyi olur :android/app/build.gradle dosya yoluna : apply from: project(':react-native-config').projectDir.getPath() + "/dotenv.gradle"   yazısını 2. satırına ekleyiniz.
* Daha sonra .env dosyasını gitignorenin bulundugu konuma oluşturup gerekli değerlerinizi giriniz. 
7.  'npm install axios'  axios kuruluyor daha sonra ise android/app/build.gradle gidiyoruz. Sonra çalışmıyorsa enableHermes: false yapıyoruz.bu işlem onerilmiyor ama calışmasını sağlıyor 
8.  https://reactjs.org/docs/hooks-custom.html custom hooks yapısını entegre ettik yapımıza. Ek makale(https://erdemuslu.medium.com/custom-react-hooks-aa88c1305cef)
9. Sistemimiz animasyon kullanmak için : https://github.com/lottie-react-native/lottie-react-native paketini kuruyoruz.
10. https://lottiefiles.com/ sitesinde lottie animasyonlarımız indiriniz. indirim sırasında dosya formatı olarak json seçiyoruz.Dosyaları src klasorü altındaki assets klasor oluşturup içerisine kayıt ediyoruz. 
9. Lottide Android specific problems ler için https://www.npmjs.com/package/lottie-react-native en altına bakınız. 
10. Genellikle : android/app/src/main/java/\<AppName\>/MainApplication.java içerisine --- import com.airbnb.android.react.lottie.LottiePackage; --- eklemelisiniz hatası karşımıza çıkmaktadır. 
11. Formik ve yup kullanımı ile login girişi kontrolleri kolaylaştırmak için yüklendi https://formik.org/docs/overview :  npm install formik yup
12. https://github.com/oblador/react-native-vector-icons bu nu kullanmak için yüklüyoruz
13. https://www.youtube.com/watch?v=R0KKUwN64hk&amp;ab_channel=L%E1%BA%ADpTr%C3%ACnhC%C3%B9ngNg%C3%A2n



