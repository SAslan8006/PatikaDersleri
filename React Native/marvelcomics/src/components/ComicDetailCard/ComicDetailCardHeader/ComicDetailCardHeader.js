import React from 'react'
import { View, Text,Image } from 'react-native'
import styles from "./ComicDetailCardHeader.style"
const ComicDetailCardHeader = ({item}) => {
    return (
       <View style={styles.character_container}>
            <Image style={styles.character_image} source={{ uri: item?.thumbnail?.path + "." + item?.thumbnail?.extension }} />
            <View style={styles.character_info}>
                <Text style={styles.name}>{item?.title}</Text>
                <Text style={styles.description}>{item?.description}</Text>
            </View>

        </View>
    )
}

export default ComicDetailCardHeader
