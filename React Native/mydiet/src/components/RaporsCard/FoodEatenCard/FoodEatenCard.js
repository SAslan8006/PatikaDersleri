import React, { useContext } from 'react'
import { View, Text } from 'react-native'
import { FoodValueContext } from '../../../context/FoodValueContext'
import styles from "./FoodEatenCard.style"
const FoodEatenCard = () => {

    const { totalCountFood, breakCalori, lunchCalori, dinnerCalori, countTotal } = useContext(FoodValueContext)
    //console.log(totalCountFood)
    return (
        <View style={styles.container}>
            <Text style={styles.container_title}>Yenen Gıdalar</Text>
            <View style={styles.header}>
                <Text style={styles.left_title}>Yemekler</Text>
                <Text style={styles.count}>Yeme Tekrarları</Text>
                <Text style={styles.calori}>Kal (kcal)</Text>
            </View>
            {
                totalCountFood.map((item, index) => (
                    item.count !== 0 && (<View style={styles.food_info} key={index}>
                        <Text style={styles.foodName}>{item.food_name}</Text>
                        <Text style={styles.food_count}>x{item.count}=</Text>
                        <Text style={styles.food_calori}>{item.count * item.calori}</Text>
                    </View>)
                ))
            }
            <View style={styles.toplam_container}>
                <Text style={styles.toplam}>Toplam</Text>
                <Text style={styles.food_tcount}>x{countTotal}=</Text>
                <Text style={styles.food_tcalori}>{breakCalori + lunchCalori + dinnerCalori}</Text>
            </View>
        </View>
    )
}

export default FoodEatenCard
