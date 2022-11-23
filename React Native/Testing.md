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
4. Tüm testler izleme ve sürekli npm test yapmamak için ise : jest -u --watchAll yapabilirsiniz.

## Buton text ve render Kontrolu

```JS
import react from "react";
import Button from "./Button";
import {render} from '@testing-library/react-native';
test('should match with snapshot', () => { 
    const comp =render (<Button/>);
    expect(comp).toMatchSnapshot(); 
});

test('should render title correctly', () => {
    const testTitle='test';
    const comp=render(<Button title={testTitle}/>);

    const buttonText=comp.geyByTestId('btton-title').children[0];
    expect(buttonText).toBe(testTitle);
    console.log(buttonText);
})
```
## Buton onPress Kontrolu
```JS
test('should trigerr onPress', () => {
    const mockFunction=jest.fn();
    const comp=render(<Button onClick={mockFunction} />)  

    const buttonTouchable=com.geyByTestId('button-touchable');
    fireEvent(buttonTouchable,'press');
    
    expect(mockFunction).toBeCalled();
    //    expect(mockFunction).toBeCalledTimes(1); tıklanma sayısını kontrolü için kullanılmaktadır.
})
```
## Tema Kontrolu
```JS
test('should render default theme style', () => {
    const comp =render(<Button />);    
    const buttonContainer=comp.geyByTestId('button-touchable');
    expect(buttonStyles).toMatchObject(styles.primary.container);

})

test('should render given theme style', () => {
    const selectedTheme='primary';
    const comp =render(<Button />);    
    const buttonContainer=comp.geyByTestId('button-touchable');
    expect(buttonStyles).toMatchObject(styles[selectedTheme].container);

})
```
## Uygulama Genel testi
```JS
import react from "react";
import App from "./App";
import {render,fireEvent} from '@testing-library/react-native';

test('should match with snapshot', () => { 
    const comp =render (<App/>);
    expect(comp).toMatchSnapshot(); 
});

test('should render default theme style', () => {
    const comp =render (<App/>);
    const input=comp.getByTestId('input-area');
    fireEvent.changeText(input,'test element');
    
    const submintButton=comp.getByTestId('button-touchable');
    fireEvent.press(submintButton);
    
    const list=comp.getByTestId('list').props;
    expect(list.data.length).toBe(1);
})


test('should render given theme style', () => {
    const comp =render(<Button />);  

    const input=comp.getByTestId('input-area');
    fireEvent.changeText(input,'test element');
    
    const submintButton=comp.getByTestId('button-touchable');
    fireEvent.press(submintButton);
    fireEvent.press(submintButton);
    fireEvent.press(submintButton);
    
    const list=comp.getByTestId('list').props;
    expect(list.data.length).toBe(3);

})
```
## Coverage
  Testlerimizi hangi işlemlere yaptığımızı göstermektedir. 
  Test etmediğimiz alanlar hakkında bilgi vermektedir.
1. npm test --coverage

