import React, {useEffect} from 'react';
import {View, Text, TextInput} from 'react-native';

const Input2 = props => {
  useEffect(() => {
    console.log('Input2');
  });

  return (
    <View style={{padding: 16}}>
      <Text>B sayısı: </Text>
      <TextInput
        style={{borderWidth: 1, borderRadius: 4, borderColor: 'green'}}
        value={props.value}
        onChangeText={props.onChangeText}
      />
    </View>
  );
};

export {Input2};
