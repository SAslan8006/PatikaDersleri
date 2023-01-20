import React from 'react'
import { View, Text, Image } from 'react-native'
import styles from "./ComicDetailCard.style"
const ComicDetailCard = ({ item }) => {
    return (
        <View style={styles.container}>

            <Image
                style={styles.image}
                source={{
                    uri: item?.thumbnail !== null ?
                        `${item?.thumbnail?.path}.${item?.thumbnail?.extension}`
                        :
                        "https://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available.jpg"
                }}
            />
            <Text style={styles.title}>{item.title}</Text>


        </View>
    )
}

export default ComicDetailCard
