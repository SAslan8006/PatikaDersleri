import React, { useContext } from 'react'
import { View, Text, TouchableWithoutFeedback } from 'react-native'
import { UserInfoContext } from '../../../context/UserInfoContext'

import styles from "./SearchFoodCard.style"

const SearchFoodCard = ({ food, onPress }) => {

    const { userInfo } = useContext(UserInfoContext)
    const foodTgd = Math.floor(food.nf_calories * 100 / userInfo.TGD)


    return (
        <TouchableWithoutFeedback onPress={onPress}>
            <View style={styles.container}>
                <Text style={styles.food_name}>{food.brand_name}</Text>
                <Text style={styles.values}>{`TGD % ${foodTgd} - ${Math.floor(food.nf_calories)} kcal`}</Text>
            </View>
        </TouchableWithoutFeedback>
    )
}

export default SearchFoodCard
