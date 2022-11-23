# Unit Testing
***
1. https://testing-library.com/docs/react-native-testing-library/intro
2. https://jestjs.io/
3. Test yazarken isterseniz test klasorüne toplanabilir isterseniz de buton componeneti örneğin içerisine button.test.js yazarakda oluşturabilirsiniz. 
4. Buton.test.js yapmak dosyların hangisi testi olduğunu daha net şekilde kullanım kolaylığı sağlar tercihen. 
5. ilk once testing library kurulumu yapıyoruz bunun için adımlar : 
  1. npm install --save-dev @testing-library/react-native kuruyoruz.
  2. Dev kelimesi ile geliştirici modunda kullanılacaktır demek yani yayınladığında eklenmeyecektir pakete bu önemli bir bilgildir. 
```JS
import react from "react";
import Button from "./Button";
import {render} from '@testing-library/react-native';
test('should match with snapshot', () => { 
    const comp =render (<Button/>);
    expect(comp).toMatchSnapshot(); 
});

```
3. çalıştırırken npm test komutu kullanılmaktadır.
