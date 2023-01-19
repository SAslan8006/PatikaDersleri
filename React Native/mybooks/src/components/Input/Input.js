import React from 'react'
import { View, TextInput } from 'react-native'
import styles from "./Input.style"
const Input = ({ placeholder, onChangeText, value, isSecure, placeholderTextColor, onBlur, style }) => {
    return (
        <View styles={styles.container}>
            <TextInput
                style={styles.input}
                autoCapitalize="none"
                placeholder={placeholder}
                onChangeText={onChangeText}
                onBlur={onBlur}
                value={value}
                placeholderTextColor={placeholderTextColor}
                secureTextEntry={isSecure}
                style={style}
            />
        </View>
    )
}

export default Input
