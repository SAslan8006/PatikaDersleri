import React from 'react'
import { View, Text, TouchableOpacity } from 'react-native'
import styles from "./Button.style"
const Button = ({ labelText, theme, handleOnPress, ...more }) => {
    return (
        <TouchableOpacity style={styles[theme].container}
            onPress={handleOnPress}
            activeOpacity={0.9}
            {...more}
        >
            <Text style={styles[theme].title}>{labelText}</Text>
        </TouchableOpacity>
    )
}

export default Button
