import React from 'react'
import { View, Text,Image } from 'react-native'
import styles from "./BestScoreListCard.style"
const BestScoreListCard = ({item}) => {
    console.log(item)
    return (
        <View style={styles.container}>
            <Image source={require("../../../assets/profileicon.png")} style={styles.image}/>
            <Text style={styles.username}>{item.username.length>10 ? item.username.slice(0,10) :item.username}</Text>
            <Text style={styles.category}>{item.category.length>15 ? item.category.slice(0,15) :item.category}</Text>
            <Text style={styles.score}>{item.score}</Text>
        </View>
    )
}

export default BestScoreListCard
