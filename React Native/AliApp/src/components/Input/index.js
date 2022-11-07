import React from "react";
import { TextInput ,View ,Text} from "react-native";
import styles from './Input.style'

function Input({label,placeholder,onChangeText}){
    return(
        <View style={styles.container}>
            <Text style={styles.label}>{label}</Text>
            <View style={styles.input_container}>
            <TextInput placeholder={placeholder} onChangeText={onChangeText} />
            </View>
        </View>
    );
}
export {Input};