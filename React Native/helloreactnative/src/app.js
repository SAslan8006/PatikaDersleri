import React, {useState, useEffect} from 'react';
import {View, Text} from 'react-native';

import {Input1} from './Input1';
import {Input2} from './Input2';

import {styles} from './styles';

const App = () => {
  console.log('APP');
  const [numberA, setNumberA] = useState('0');
  const [numberB, setNumberB] = useState('0');

  useEffect(() => {
    alert('test');
  }, [numberB]);

  return (
    <View style={styles.mainContainer}>
      <Input1 value={numberA} onChangeText={d => setNumberA(parseInt(d, 10))} />
      <Input2 value={numberB} onChangeText={d => setNumberB(parseInt(d, 10))} />
    </View>
  );
};

// const styles = StyleSheet.create({
//   mainContainer: {},
//   text: {
//     fontSize: 24,
//     color: 'red',
//     fontWeight: 'bold',
//     borderWidth: 5,
//     borderColor: 'green',
//   },
// });

export {App};
