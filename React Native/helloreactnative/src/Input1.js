import React from 'react';
import {View, Text, TextInput} from 'react-native';

const Input1 = props => {
  console.log('Input1');
  return (
    <View style={{padding: 16}}>
      <Text>A sayısı: </Text>
      <TextInput
        style={{borderWidth: 1, borderRadius: 4, borderColor: 'gray'}}
        value={props.value}
        onChangeText={props.onChangeText}
      />
    </View>
  );
};

export {Input1};
