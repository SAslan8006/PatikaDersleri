import React from "react"
import { TextInput, View } from "react-native"
import styles from "./Input.styles"
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
const Input = ({ placeholder, value, onType, iconName,isSecure }) => {
    return (
        <View style={styles.container}>
            <TextInput
                style={styles.input}
                placeholder={placeholder}
                onChangeText={onType}
                value={value}
                placeholderTextColor={"black"}
                secureTextEntry={isSecure}
            />
            <Icon name={iconName} size={25} color="gray" />
        </View>
    )
}

export default Input;