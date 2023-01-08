import React, { useContext } from 'react'
import { View, Text } from 'react-native'
import { FoodValueContext } from '../../../context/FoodValueContext'
import styles from "./DailyHeader.style"
const DailyHeader = () => {
    const { foodValue, breakFat, breakPro, breakCarb, breakTgd, breakCalori, dinnerFat, dinnerPro, dinnerCarb,
        dinnerTgd, dinnerCalori, lunchFat, lunchPro, lunchCarb, lunchTgd, lunchCalori } = useContext(FoodValueContext)
    return (
        <View style={styles.container}>
            <View style={styles.item}>
                <Text style={styles.item_title}>Yağ</Text>
                <Text style={styles.item_value}>{foodValue.length > 0 ? breakFat + dinnerFat + lunchFat : "-"}</Text>
            </View>
            <View style={styles.item}>
                <Text style={styles.item_title}>Karb</Text>
                <Text style={styles.item_value}>{foodValue.length > 0 ? breakCarb + lunchCarb + dinnerCarb : "-"}</Text>
            </View>
            <View style={styles.item}>
                <Text style={styles.item_title}>Prot</Text>
                <Text style={styles.item_value}>{foodValue.length > 0 ? breakPro + lunchPro + dinnerPro : "-"}</Text>
            </View>
            <View style={styles.item}>
                <Text style={styles.item_title}>TGD</Text>
                <Text style={styles.item_value}>{foodValue.length > 0 ? breakTgd + lunchTgd + dinnerTgd : "-"}</Text>
            </View>
            <View style={styles.item}>
                <Text style={styles.item_cal}>Kalori</Text>
                <Text style={styles.item_value_cal}>{breakCalori + lunchCalori + dinnerCalori}</Text>
            </View>
        </View>
    )
}

export default DailyHeader
