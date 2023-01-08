import React, { useContext } from 'react'
import { View, Text } from 'react-native'
import { FoodValueContext } from '../../../context/FoodValueContext'
import styles from "./MakroFoodEatenCard.style"
const MakroFoodEatenCard = () => {
    const { totalCountFood, breakFat, breakPro, breakCarb, dinnerFat, dinnerPro, dinnerCarb,
        lunchFat, lunchPro, lunchCarb } = useContext(FoodValueContext)

    return (
        <View style={styles.container}>
            <Text style={styles.container_title}>Yenen Gıdalar</Text>
            <View style={styles.header}>
                <Text style={styles.left_title}>Yemekler</Text>
                <Text style={styles.carb}>Karb(g)</Text>
                <Text style={styles.fat}>Yağ(g)</Text>
                <Text style={styles.prot}>Prot(g)</Text>
            </View>
            {
                totalCountFood.map((item, index) => (
                    item.count !== 0 && (<View style={styles.food_info} key={index}>
                        <Text style={styles.foodName}>{item.food_name}</Text>
                        <Text style={styles.food_tvalue}>{item.count * item.carbon}</Text>
                        <Text style={styles.food_tvalue}>{item.count * item.fat}</Text>
                        <Text style={styles.food_tvalue}>{item.count * item.protein}</Text>
                    </View>)
                ))
            }
            <View style={styles.toplam_container}>
                <Text style={styles.toplam}>Toplam</Text>
                <Text style={styles.toplam_value}>{breakCarb + lunchCarb + dinnerCarb}</Text>
                <Text style={styles.toplam_value}>{breakFat + lunchFat + dinnerFat}</Text>
                <Text style={styles.toplam_value}>{breakPro + lunchPro + dinnerPro}</Text>
            </View>
        </View>
    )
}

export default MakroFoodEatenCard
