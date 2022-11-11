import React, { useState } from 'react';
import {SafeAreaView, Text, Image, StyleSheet, View, Alert} from 'react-native';

import {Input,Button} from '../components';

function Login({navigation}){
    const[Mail,setMail]=useState(null);
    const[Pasword,setPasword]=useState(null);  
    //Burada şimdilik veri tabanı olmadığı için sistemde isim ve soyad olmadan sabit tanımlanarak kontrol edilmiştir.
    function handleSubmit(){
        const user={
            Name:"Ahmet",
            Surname:"Dağ",
            Mail,
            Pasword,
        }
        if(Pasword=='1234' && Mail=='email'){
            navigation.navigate('Shop',{user});
        }
       
        
    };
    
    return (
        //Safe areaView ile veriler yansıtılmıştır
        <SafeAreaView style={styles.container}>   
            <View style={styles.modal}>         
                <Input  label="Mail" placeholder="Mail giriniz...(email)" onChangeText={setMail}/>
                <Input  label="Şifre" placeholder="Şifrenizi giriniz...(1234)" onChangeText={setPasword} />
                <Button text="Giriş Yap" onPress={handleSubmit}/>
            </View>
        </SafeAreaView>
    );
}

export default Login;

const styles=StyleSheet.create({
    container:{ 
        flex: 1, 
        justifyContent: 'center',
        borderRadius: 12,
        padding: 8,
        alignItems: 'center',
        marginTop: 16,
        backgroundColor: 'white',
      },
     modal: {
        width: '85%',
        minHeight: '30%',
        backgroundColor: 'white',
        borderRadius: 16,
        padding: 4,
        shadowColor: 'red',
        shadowOffset: {
          width: 0,
          height: 2,
        },
        shadowOpacity: 1,
        shadowRadius: 4,
        elevation: 8,
      },
  });