import React from 'react'
import { TouchableOpacity, Text } from 'react-native'
import styles from "./Button.style"

const Button = ({ onPress, theme, text, loading, iconName, color }) => {
    return (
        <TouchableOpacity onPress={onPress} style={styles[theme].container} disabled={loading} >
            <Text style={styles[theme].title}>{text}</Text>
        </TouchableOpacity >
    )
}

export default Button
