import React from 'react';
import {StyleSheet,View,SafeAreaView, Text,  Alert,} from 'react-native';

const App = () => {
  return (
    <SafeAreaView style={styles.container}>
      <View style={styles.mrbdunya}>
      <Text>Pamukun Dünyası </Text>     
      </View>
      <View style={styles.mrbdunya}>
      <Text>Merhaba Dünyası </Text>     
      </View>
      <View style={styles.mrbdunya}>
      <Text>Merhaba Dünyası </Text>     
      </View>
      <View style={styles.mrbdunya}>
      <Text>Merhaba Dünyası </Text>     
      </View>
      
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor:'yellow',
    margin:10,
    padding:3,
    flex:1,
    borderRadius:8,
    justifyContent: 'center', //6 farklı stili vardır aralarında dikeydeki boşlukları ayaralamak için kullanılmaktadır
    marginHorizontal: 16,
    flexDirection:'row-reverse', //Dik için row - yatay için cloumn
    alignItems:'flex-start' //yatayda boşlukları ayarlamak için kullanılmakdırd
  }, 
  mrbdunya: {
    textAlign:'center',
    textAlignVertical:'center',
    backgroundColor:'red',
    margin:4,
    padding:1,
    borderRadius:8,
    width:75,
    height:75,
  }
});

export default App;
