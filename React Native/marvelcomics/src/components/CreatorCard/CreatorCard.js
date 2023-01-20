import React from 'react'
import { View, Text, Image } from 'react-native'
import styles from "./CreatorCard.style"

const ComicsCard = ({ creator }) => {

    return (
        <View style={styles.container}>

            <Image source={{ uri: creator?.thumbnail?.path + '.' + creator?.thumbnail?.extension }} style={styles.image} />
            <View style={styles.name_container}>
                <Text style={styles.name}>{creator.fullName}</Text>
            </View>

        </View>
    )
}

export default ComicsCard