import React from 'react'
import { View, Text, Image } from 'react-native'
import styles from "./StoriesCard.style"

const StoriesCard = ({ stories }) => {

    return (
        <View style={styles.container}>

            <Image source={{ uri: stories?.thumbnail === null ? "https://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available.jpg" : stories?.thumbnail?.path + '.' + stories?.thumbnail?.extension }} style={styles.image} />
            <View style={styles.name_container}>
                <Text style={styles.name}>{stories.title.slice(0, 25)}</Text>
            </View>

        </View>
    )
}

export default StoriesCard