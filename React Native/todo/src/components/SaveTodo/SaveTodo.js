import React from 'react'
import { View, Text, TextInput, Pressable } from 'react-native'
import styles from "./SaveTodo.styles"
const SaveTodo = ({setTodo,handleSaveTodo,text}) => {

    return (
        <View style={styles.container}>
            <TextInput
                style={styles.inputItem}
                placeholder="ToDo List..."
                placeholderTextColor="#808080"
                value={text}
                onChangeText={(text)=>setTodo(text)}
            ></TextInput>
            <Pressable style={text.length>0 ? styles.button_hover : styles.button} onPress={handleSaveTodo}>
                <Text style={styles.text}>Kaydet</Text>
            </Pressable>
        </View>
    )
}
export default SaveTodo;