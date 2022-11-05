import React ,{useState,useEffect} from 'react'; //import React, {useState} from 'react';
import {  Button,  SafeAreaView,  ScrollView,  StatusBar, FlatList, Switch,  StyleSheet,  Text,  useColorScheme,  View,} from 'react-native';

function App () {
    const [number,setNumber]=useState(0); //bu şekilde çağırarakda kullanılabilir. React.useState();
    const [counter,setCounter]=useState(0);
    //console.log('render');
    useEffect(()=>{
        console.log('Updated number...');
    },[number]); //use effet fonsiyonu sadece numberdaki değişikleri takip eder
    
    useEffect(()=>{
        console.log('Mounting..');
    }, []);

    function updateCounter(){
        console.log('1. state value:'+number);
        setNumber(number+1);
        console.log('2. state value:'+number); //iki değerde aynı olur üsteki state 1 ve state 2
    }

  return (
    <SafeAreaView >
        <Text>Hello Lifecycle</Text>
        <Text>Number :{number}</Text>
        <Text>Counter :{counter}</Text>        
        <Button styles={styles.mainContainer} title='Up' onPress={()=>setNumber(number+1)}/>
        <Button styles={styles.mainContainer}  title='Counter' onPress={()=>setCounter(counter+1)}/>

    </SafeAreaView>
  )
};

const styles = StyleSheet.create({
    mainContainer: {},
    text: {
      fontSize: 24,
      color: 'red',
      fontWeight: 'bold',
      borderWidth: 5,
      borderColor: 'green',
      textAlign: 'center',
    },
   
     
});

export default App;
