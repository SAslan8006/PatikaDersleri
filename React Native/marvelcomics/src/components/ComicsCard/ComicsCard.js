import React from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import styles from "./ComicsCard.style"

const ComicsCard = ({ comics, onSelect }) => {

    return (
        <TouchableOpacity style={styles.container} onPress={onSelect}>

            <Image source={{ uri: comics?.thumbnail?.path + '.' + comics?.thumbnail?.extension }} style={styles.image} />
            <View style={styles.name_container}>
                <Text style={styles.name}>{comics?.title?.length > 15 ? comics.title.slice(0, 35) + "..." : comics.title}</Text>
            </View>

        </TouchableOpacity>
    )
}

export default ComicsCard
