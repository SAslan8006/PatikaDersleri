import React from 'react'
import { View, Text, TouchableWithoutFeedback } from 'react-native'
import styles from "./RoomCard.style"
const RoomCard = ({ roomName, onSelect }) => {

    return (
        <TouchableWithoutFeedback onPress={onSelect}>
            <View style={styles.container}>
                <Text style={styles.room_name}>{roomName.text}</Text>
            </View>
        </TouchableWithoutFeedback>
    )
}

export default RoomCard
