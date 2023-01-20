import React from 'react'
import { View, Text, Image } from 'react-native'
import styles from "./EventCard.style"

const EventCard = ({ event }) => {

    return (
        <View style={styles.container}>

            <Image source={{ uri: event?.thumbnail?.path + '.' + event?.thumbnail?.extension }} style={styles.image} />
            <View style={styles.name_container}>
                <Text style={styles.name}>{event.title}</Text>
            </View>

        </View>
    )
}

export default EventCard