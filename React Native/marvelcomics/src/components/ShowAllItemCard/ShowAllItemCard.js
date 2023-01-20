import React from 'react'
import { View, Text,Image } from 'react-native'
import styles from "./ShowAllItemCard.style"
const ShowAllItemCard = ({data}) => {
    return (
        <View style={styles.container}>
            <Image style={styles.image}
                    source={{
                        uri: data?.thumbnail!==null ?
                        `${data?.thumbnail?.path}.${data?.thumbnail?.extension}`
                    :
                    "https://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available.jpg"
                    }}
            
            />
            <Text style={styles.title}>{data.title ? data.title : data.name}</Text>
        </View>
    )
}

export default ShowAllItemCard
