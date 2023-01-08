import React from 'react'
import { View, Text, TouchableOpacity } from 'react-native'
import styles from "./DinnerDetailCard.style"
const DinnerDetailCard = ({ food,styleCollapse }) => {
   
    return (
        <TouchableOpacity style={styleCollapse}>
            <View style={styles.container_left}>
                <Text style={styles.title}>{food.food_name}</Text>
                <View style={styles.food_values}>
                    <Text style={styles.value}>{food.fat}</Text>
                    <Text style={styles.value}>{food.carbon}</Text>
                    <Text style={styles.value}>{food.protein}</Text>
                    <Text style={styles.value}>%{food.foodTgd}</Text>
                </View>
            </View>
            <View style={styles.container_right}>
                <Text style={styles.calori}>{food.calori}</Text>
            </View>

        </TouchableOpacity>
    )
}

export default DinnerDetailCard
