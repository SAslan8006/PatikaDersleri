## Dükkan Tasarımı (WebApi-Customhook)
Bu yazımızda dükkanımıza nasıl api den veri cektiğimi anlatmaya calışacağım.

1. Navigation install aşamalarını yap. (https://reactnavigation.org/docs/getting-started/) ilk iki sayfayu uygulamalısın.
2. Stack kurulumun aşamalarını yap. (https://reactnavigation.org/docs/stack-navigator/)
3. https://github.com/luggit/react-native-config sayfasındaki ayarlamaları yapıyoruz.
4. https://www.npmjs.com/package/dotenv sayfasındaki ayarlamalar ve kurulumları yapıyoruz.
* npm install react-native-dotenv dosyasını yükle daha sonra ise
* babel.config.js dosyasına aşağıdaki kodu ekleyin.
* [ ["module:react-native-dotenv", { "moduleName": "@env", "path": ".env", "blacklist": null, "whitelist": null, "safe": false, "allowUndefined": true }] ]  



