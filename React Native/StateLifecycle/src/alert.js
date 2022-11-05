import React, { useState } from "react";
import { View, StyleSheet, Button, Alert } from "react-native";
//Kullanılması için ilk olarak kütüphanesi tanımlanmalıdır 

const App = () => {
  const createTwoButtonAlert = () => //iki alertli buton 
    Alert.alert(
       "Alert Başlığı", //Alert başlığı yazılmalısı gereklidir.
       "My Alert Msg", //Alert mesajı
      [
        {  //Button konsepti olarak negative(Negatif) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.      
          text: "Cancel",
          onPress: () => console.log("Cancel Pressed"),
          style: "cancel" //3 Stil vardır: default,cancel ve destructive
        },
        { //Button konsepti olarak positive(Pozitif) kullanılmaktadır. Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
            text: "OK", 
            onPress: () => console.log("OK Pressed") 
        }
      ]
    );

  const createThreeButtonAlert = () => // Android'de en fazla üç button belirtilebilir. 3 buttonlu Alert
    Alert.alert(
      "Alert Title",
      "My Alert Msg",
      [
        { //Button konsepti olarak neutral(Nötr) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
          text: "Ask me later",
          onPress: () => console.log("Ask me later pressed")
        },
        {//Button konsepti olarak negative(Negatif) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
          text: "Cancel",
          onPress: () => console.log("Cancel Pressed"),
          style: "cancel",
          

        },
        { //Button konsepti olarak positive(Pozitif) kullanılmaktadır.Buttonların onPress Methodu ile gerekli dönüş yapılmaktadır.
            text: "OK", onPress: () => console.log("OK Pressed") 
        }
      ],
    );

  return (
    <View style={styles.container}>
      <Button title={"2-Button Alert"} onPress={createTwoButtonAlert} />
      <Button title={"3-Button Alert"} onPress={createThreeButtonAlert} />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "space-around",
    alignItems: "center"
  }
});

export default App;