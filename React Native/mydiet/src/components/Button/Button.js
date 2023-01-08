import React from 'react'
import { Text, TouchableOpacity } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialCommunityIcons'
import styles from "./Button.style"
const Button = ({ onPress, iconName, theme, iconTheme, text, loading }) => {

    return (
        <TouchableOpacity onPress={onPress} style={styles[theme].container} disabled={loading}>
            {
                text ? <Text style={styles[theme].title}>{text}</Text>
                    : (<Icon name={iconName} size={30} color="#33B24B" style={styles[iconTheme].icon} />)
            }

        </TouchableOpacity>
    )
}

export default Button
