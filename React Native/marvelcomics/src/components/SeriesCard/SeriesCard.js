import React from 'react'
import { View, Text, Image } from 'react-native'
import styles from "./SeriesCard.style"

const SeriesCard = ({ series }) => {

    return (
        <View style={styles.container}>

            <Image source={{ uri: series?.thumbnail?.path + '.' + series?.thumbnail?.extension }} style={styles.image} />
            <View style={styles.name_container}>
                <Text style={styles.name}>{series.title.slice(0, 25)}</Text>
            </View>

        </View>
    )
}

export default SeriesCard