import React, {useState, useEffect} from 'react'; //import React, {useState} from 'react';
import {  Button,  SafeAreaView,  ScrollView,  StatusBar,  FlatList,  Switch,  StyleSheet,  Text,  useColorScheme,  View,} from 'react-native';

function App() {
    const [helloFlag, setHelloFlag] = useState(true);
  
    function updateFlag() {
      setHelloFlag(!helloFlag);
    }
  
    return (
      <SafeAreaView>
        <Text>Hello Lifecycle</Text>
        <Button title="Up" onPress={updateFlag} />
      </SafeAreaView>
    );
  }
  
  export default App;