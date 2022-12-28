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
