import React from 'react';
import {
  StyleSheet,
  Button,
  View,
  SafeAreaView,
  Text,
  Alert,
} from 'react-native';
// View : Cerceve yer ayırmaktır
// Text : Yazı için

//function App(){
const App = () => {
  //Array function
  const sagButton = label => {
    Alert.alert('Right button pressed ' + label);
  };

  const sayHello1 = () => {
    console.log('Merhabalar!!');
    return 5;
  };
  return (
    <SafeAreaView style={styles.container}>
      <View style={styles.container}>
      <Text color="blue">Pamukun Dünyası </Text>
      <Text>Yardımcı Dünyası </Text>
      <Text className="greeting">Hello, world!</Text>
      <Button
        title="Learn More"
        color="#2196F3"
        onPress={() => sayHello1()}
        disabled={false}
      />
      </View>
      <Text> </Text>
      <View style={styles.fixToText}>
        <Button
          title="Left button"
          onPress={() => Alert.alert('Left button pressed')}
        />

        <Button title="Right button" onPress={() => sagButton('sag')} />
      </View>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor:'red',
    justifyContent: 'center',
    marginHorizontal: 16,
  },
  title: {
    textAlign: 'center',
    marginVertical: 8,
  },
  fixToText: {
    flexDirection: 'row',
    justifyContent: 'space-between',
  },
  separator: {
    marginVertical: 8,
    borderBottomColor: '#737373',
    borderBottomWidth: StyleSheet.hairlineWidth,
  },
});

export default App;
