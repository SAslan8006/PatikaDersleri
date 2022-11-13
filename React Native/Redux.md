#Redux Yapısı Ne işe yapar

1. Redux değişkenlerin yada veririnin tüm uygulamada kullanılmasını ve onlara ulaşılmasını sağlayan sarmallama yapısıdır. Örneğin 1 kullanıcı şifresini girdiğinde bu işlem sonucu dondürülen tokenın olup olmadığını kullanmamızı sağlayan yapıdır.
2. Redux ile verileri globalleştirebildiğimiz kadar bu verilerin güncellemesini yapabiliriz. 
Kurulum aşamaları:

1. npm install @reduxjs/toolkit ile isterseniz toolkitini kurabilirsiniz kullanımı kolaylaştırmaktadır. 
2. npm install redux ile reduxu kuruyoruz bu olmazsa olmazdır uygulama kurulması gerekmektedir. 
3. npm install react-redux  kuruyoruz bu olmazsa olmazdır uygulama kurulması gerekmektedir. 
4. npm install --save-dev @redux-devtools/core buda kittir kurulumu seçime bağlıdır.
5. npm i react-redux redux redux-persist redux-thunk @reduxjs/toolkit bu kurulmalıdır kısaca

redux yapısının kullanımı ve mantığı : 
```JS
import {legacy_createStore as createStore} from 'redux';
import { Provider,useSelector,useDispatch } from 'react-redux';
```
