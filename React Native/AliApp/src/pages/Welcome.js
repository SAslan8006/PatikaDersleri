import React from 'react';
import {SafeAreaView, Text, Image, StyleSheet, View} from 'react-native';

import {Button,Input} from '../components';

function Welcome({navigation}){
    function gotoLogin(){
        navigation.navigate('Login');    
    }
    function gotoRegister(){
      navigation.navigate('Register');    
  }
    return(
        <SafeAreaView style={styles.container}>
            <View style={styles.modal}>
                <Text style={styles.header}>Ali Dayı Alış-Veriş</Text>
                <View style={styles.Image1}>
                    <Image style={styles.Image} source={require('../images/logo.jpeg')}/>
                </View>
                <Button text="Üye Kayıdı Oluştur" onPress={gotoRegister} />
                <Button text="Üye Girişi" onPress={gotoLogin} />
            </View>
        </SafeAreaView>
    );
}

export default Welcome;

const styles = StyleSheet.create({
    container: {
      flex: 1, 
      justifyContent: 'center',
      borderRadius: 12,
      padding: 8,
      alignItems: 'center',
      marginTop: 16,
      backgroundColor: 'white',
    },
    header:{
      textAlign:'center',
      fontSize:30,
      fontWeight:'bold',
    },
    Image1:{
      alignItems:'center',
    },
    Image:{
        width: 250, 
        height: 200,
        flexDirection: 'column',
        justifyContent: 'center',
        alignItems: 'center',
        borderRadius:20,
    },
    modal: {
        width: '85%',
        minHeight: '30%',
        backgroundColor: 'white',
        borderRadius: 16,
        padding: 24,
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