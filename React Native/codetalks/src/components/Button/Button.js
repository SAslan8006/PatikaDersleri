import React from 'react'
import { ActivityIndicator, Text, TouchableOpacity } from 'react-native'
import styles from "./Button.style"
const Button = ({ onPress, text, theme, loading }) => {
    return (
        <TouchableOpacity style={styles[theme].container} onPress={onPress} disabled={loading}>
            {
                loading ? (<ActivityIndicator color="white" />)
                    : <Text style={styles[theme].title}>{text}</Text>
            }
        </TouchableOpacity>
    )
}

export default Button
