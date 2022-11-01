import React, {useState} from 'react';
import {View, Text, StyleSheet, TextInput} from 'react-native';

import {Input1} from './Input1';
import {Input2} from './Input2';

import {styles} from './styles';

const App = () => {
    console.log('APP');
  const [numberA, setNumberA] = useState(0);
  const [numberB, setNumberB] = useState(0);

  const [numbers, setNumbers] = useState({numberA: '', numberB: ''});

  const calc = (a, b) => {
    let result = 1;

    for (let i = 1; i <= a; i++) {
      result *= b;
    }

    return result;
  };

  return (
    <View style={styles.mainContainer}>
      <Input1
        value={numbers.numberA}
        onChangeText={d => setNumbers({...numbers, numberA: parseInt(d, 10)})}
      />

      <Input2
        value={numbers.numberB}
        onChangeText={d => setNumbers({...numbers, numberB: parseInt(d, 10)})}
      />

      <Text style={styles.text}>{calc(numbers.numberA, numbers.numberB)}</Text>
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
