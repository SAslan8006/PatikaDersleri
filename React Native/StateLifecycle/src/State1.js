
import React, {useState} from 'react';
import {  Button,  SafeAreaView,  ScrollView,  StatusBar,  StyleSheet,  Text,  useColorScheme,  View,} from 'react-native';


function App () {
    const [counter,useCounter]=useState(0);
      function increaseCounter(){
        useCounter(counter+1);
      }
      function decreaseCounter(){
        useCounter(counter-1);
      }
  return (
    <SafeAreaView style={styles.sectionContainer}>
      <View>
        <Text style={{fontSize:34}}>Counter:{counter}</Text>
        <Button title="İncrease Counter" onPress={increaseCounter} />
        <Button title="Decrease Counter" onPress={decreaseCounter} />
      </View>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  sectionContainer: {
    marginTop: 32,
    paddingHorizontal: 24,
    fontSize: 34,
    fontWeight: '600',
  },
  
});

export default App;
