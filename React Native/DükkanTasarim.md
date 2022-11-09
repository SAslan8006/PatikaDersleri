## Dükkan Tasarımı (WebApi-Customhook)
Bu yazımızda dükkanımıza nasıl api den veri cektiğimi anlatmaya calışacağım.

1. Navigation install aşamalarını yap. (https://reactnavigation.org/docs/getting-started/) ilk iki sayfayu uygulamalısın.
2. Stack kurulumun aşamalarını yap. (https://reactnavigation.org/docs/stack-navigator/)
3. https://github.com/luggit/react-native-config sayfasındaki ayarlamaları yapıyoruz.
4. https://www.npmjs.com/package/dotenv sayfasındaki ayarlamalar ve kurulumları yapıyoruz.
* npm install react-native-dotenv dosyasını yükle daha sonra ise
* babel.config.js dosyasına aşağıdaki kodu ekleyin.
* [ ["module:react-native-dotenv", { "moduleName": "@env", "path": ".env", "blacklist": null, "whitelist": null, "safe": false, "allowUndefined": true }] ]  
* extra olarak yapılsa iyi olur :android/app/build.gradle dosya yoluna : apply from: project(':react-native-config').projectDir.getPath() + "/dotenv.gradle"   yazısını 2. satırına ekleyiniz.
* Daha sonra .env dosyasını gitignorenin bulundugu konuma oluşturup gerekli değerlerinizi giriniz. 
5. https://reactjs.org/docs/hooks-custom.html custom hooks yapısını entegre ettik yapımıza.
6. 



