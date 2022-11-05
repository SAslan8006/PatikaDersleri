import React from 'react'
import { View, Text } from 'react-native'
import styles from "./TodoCounter.styles"
const TodoCounter = ({list}) => {

    const listCount=list.filter((item)=>!item.isDone)
    return (
        <View style={styles.container}>
            <Text style={styles.title}>ToDo List</Text>
            <Text style={styles.counter}>{listCount.length}</Text>
        </View>
    )
}
export default TodoCounter;