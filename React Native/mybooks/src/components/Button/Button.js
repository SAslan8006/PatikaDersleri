import { isValid } from 'date-fns'
import React from 'react'
import { Text, TouchableOpacity } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialCommunityIcons'
import styles from "./Button.style"
const Button = ({ onPress, theme, text, loading, iconName, color }) => {
    return (
        <TouchableOpacity onPress={onPress} style={styles[theme].container} disabled={loading} >
            {iconName ? <Icon name={iconName} size={30} color={color ? color : null} /> : null}
            <Text style={styles[theme].title}>{text}</Text>
        </TouchableOpacity >
    )
}

export default Button
