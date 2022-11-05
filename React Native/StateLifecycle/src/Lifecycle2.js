import React, {useState, useEffect} from 'react'; //import React, {useState} from 'react';
import {
  Button,
  SafeAreaView,
  ScrollView,
  StatusBar,
  FlatList,
  Switch,
  StyleSheet,
  Text,
  useColorScheme,
  View,
} from 'react-native';

function App() {
  const [helloFlag, setHelloFlag] = useState(true);

  function updateFlag() {
    setHelloFlag(!helloFlag);
  }

  return (
    <SafeAreaView>
      <Text>Hello Lifecycle</Text>
      <Button title="Up" onPress={updateFlag} />
      {helloFlag && <Hello />}
    </SafeAreaView>
  );
}

export default App;

function Hello() {
    useEffect(()=>{
        console.log('Merhaba dünya');
        return ()=>{
            console.log('Gidiyorum ... ');
        };
    });

    return (
        <View style={{backgroundColor: 'aqua', padding: 10}}>
        <Text>Hello component</Text>
        </View>
    );
}
