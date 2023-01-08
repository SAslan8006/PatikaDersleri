import React from 'react'
import { View, TextInput } from 'react-native'
import styles from "./Input.style"
const Input = ({ placeholder, onType, value, isSecure }) => {
    return (
        <View style={styles.container}>
            <TextInput
                style={styles.input}
                autoCapitalize="none"
                placeholder={placeholder}
                onChangeText={onType}
                value={value}
                placeholderTextColor={"white"}
                secureTextEntry={isSecure}
            />
        </View>
    )
}

export default Input