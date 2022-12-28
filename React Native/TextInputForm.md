# Text Inputta Form İşlemleri
### Aşağıda bir örnek mevcuttur.
```JS
import React, { useState } from 'react'
import { Text, TextInput, TouchableOpacity, View, } from 'react-native'
import { styles } from './styles';


export default FormIslemleriScreen = () => {

    const [sayi, setSayi] = useState('');
    const [faktoriyel, setFaktoriyel] = useState('');

    const getFaktoriyel = value => {
        let f = 1;
        for(let index = 1; index <= value; index++){
            f *= index;
        }
        return f;
    }

    return (
        <View style = {{flex: 1, margin: 10, alignItems: 'center', justifyContent: 'center'}}>
          <TextInput 
            value = {sayi}
            onChangeText = {value => { 
                setSayi(value);
                setFaktoriyel('');
            }}
            style = {{
                borderRadius: 20, 
                borderColor: '#00f',
                width: '100%',
                borderWidth: 1,
            
            }}>
          </TextInput>
           <TouchableOpacity
             onPress = {() => {
                 setFaktoriyel(getFaktoriyel(sayi));
             }}
             style = {{
                 alignItems: 'center',
                 justifyContent: 'center',
                 backgroundColor: '#0f0',
                 padding: 5,
                 margin: 10,
                 width: '100%',
                 height: 50,
                 borderRadius: 20
             }}
           >
               <Text style = {styles.textStyle2}>Hesapla</Text>
           </TouchableOpacity>
           <Text style = {styles.textStyle2}>{faktoriyel != '' ? sayi +' != ' +faktoriyel: '' }</Text>
        </View>
    );
};
```
### State Form Örneği 
```JS
import React, { useState } from 'react';
import { Text,View,TouchableOpacity, TextInput } from 'react-native';
//import { styles } from './screens';


export default LoginFormIslemleriScreen = () => {

    const [mail, setMail] = useState('');
    const [sifre, setSifre] = useState('');

    const checkUser = () => {
        if(mail == "deneme@gmail.com" && sifre == "123") {
            alert("Giriş Başarılı");
        }else{
            alert("hata Oluştu");
        }
    };

    return (

        <View style = {{flex: 1, margin: 20,justifyContent: 'center', alignItems: 'center'}}>

<TextInput 
            value = {mail}
            onChangeText = {value => {                 
                setMail(value);
            }}
            style = {{
                borderRadius: 20, 
                borderColor: '#0f0',
                width: '100%',
                borderWidth: 1,
                padding: 10
            }}>
          </TextInput>
            <TextInput 
            style = {{
                borderRadius: 20,
                borderColor: '#0f0',
                height: 50,
                width: '100%',
                borderWidth: 1,
                margin: 10,
                padding: 10
            }}
                placeholder = "Şifre"
                secureTextEntry
                value = {sifre}
                onChangeText = {value => {
                    setSifre(value);
                    console.log(sifre);
                }}>
            </TextInput>

            <TouchableOpacity 
            onPress = {() => {
                checkUser();
            }}
            style = {{
                borderColor: '#0f0',
                backgroundColor: '#0f0',
                borderRadius: 20,
                height: 50,
                width: '100%',
                alignItems: 'center'
            }}>
                <Text style = {{fontSize: 25, alignContent: 'center', alignItems: 'center'}}>Giriş Yap</Text>
            </TouchableOpacity>
        </View>

    );
}
```
