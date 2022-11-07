import React, { useState } from "react";
import { SafeAreaView , Alert,StyleSheet,Image, View} from 'react-native';

import {Input,Button} from '../components';

function Register({navigation}){
    const[Name,setName]=useState(null);
    const[Surname,setSurname]=useState(null);
    const[Mail,setMail]=useState(null);
    const[Pasword,setPasword]=useState(null);

    function handleSubmit(){
        const user={
            Name,
            Surname,
            Mail,
            Pasword,
        };
        
        //console.log(user);

        if(!Name ||  !Surname || !Mail || !Pasword ){
            Alert.alert('Ali Dayı Alış-Veriş','Bilgiler Boş Bırakılmaz');
            return;
        } else {
            navigation.navigate('Shop',{user});
        }
       
        
    };
    
    return (
        <SafeAreaView style={styles.container}>
            <View style={styles.modal}>
                <Input  label="Adı" placeholder="Üye adını giriniz..." onChangeText={setName}/>
                <Input  label="Soyadı" placeholder="Üye soyadını giriniz..." onChangeText={setSurname} />
                <Input  label="E-Posta" placeholder="Üye e-postasını giriniz..." onChangeText={setMail}/>
                <Input  label="Şifre" placeholder="Şifrenizi giriniz..." onChangeText={setPasword}/>
                <Button text="Kaydı Tamamla" onPress={handleSubmit}/>
            </View>           
        </SafeAreaView>
    );
}

export default Register;

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