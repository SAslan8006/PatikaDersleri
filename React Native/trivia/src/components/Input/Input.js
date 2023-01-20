import React from 'react'
import { View, Text, TextInput } from 'react-native'
import styles from "./Input.style"
const Input = ({ labelText, placeHolderText, onChangeText, value, ...more }) => {
    return (
        <View style={styles.container}>
            <Text>{labelText}</Text>
            <TextInput style={styles.input}
                placeholder={placeHolderText}
                value={value}
                onChangeText={onChangeText}
                {...more}
            />
        </View>
    )
}

export default Input
