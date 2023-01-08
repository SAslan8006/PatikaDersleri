import React, { useContext } from 'react'
import { View, Text } from 'react-native'
import { FoodValueContext } from '../../../context/FoodValueContext'
import styles from "./MakroCard.style"
const MakroCard = () => {
    const { breakFat, breakPro, breakCarb, dinnerFat, dinnerPro, dinnerCarb,
        lunchFat, lunchPro, lunchCarb } = useContext(FoodValueContext)

    const totalCarbon = Math.floor(100 * (breakCarb + lunchCarb + dinnerCarb) / (breakCarb + lunchCarb + dinnerCarb + breakFat + breakPro + dinnerFat + dinnerPro + lunchFat + lunchPro))
    const totalFat = Math.floor(100 * (breakFat + lunchFat + dinnerFat) / (breakCarb + lunchCarb + dinnerCarb + breakFat + breakPro + dinnerFat + dinnerPro + lunchFat + lunchPro))
    const totalProtein = Math.floor(100 * (breakPro + lunchPro + dinnerPro) / (breakCarb + lunchCarb + dinnerCarb + breakFat + breakPro + dinnerFat + dinnerPro + lunchFat + lunchPro))
    return (
        <View style={styles.container}>
            <View style={styles.container_title}>
                <Text style={styles.container_toplam}>Toplam</Text>
                <Text style={styles.container_target}>Hedef</Text>
            </View>
            <View style={styles.feed_container}>
                <View style={styles.feed_left}>
                    <Text style={styles.feed_blue}></Text>
                    <Text style={styles.feed_name}>karbonhidrat</Text>
                </View>
                <View style={styles.feed_right}>
                    <Text style={totalCarbon < 50 ? styles.feed_value : styles.feed_redValue}>{totalCarbon ? totalCarbon : 0}%</Text>
                    <Text style={styles.feed_calori}>50%</Text>
                </View>
            </View>
            <View style={styles.feed_container}>
                <View style={styles.feed_left}>
                    <Text style={styles.feed_orange}></Text>
                    <Text style={styles.feed_name}>Yağ</Text>
                </View>
                <View style={styles.feed_right}>
                    <Text style={totalFat < 30 ? styles.feed_value : styles.feed_redValue}>{totalFat ? totalFat : 0}%</Text>
                    <Text style={styles.feed_calori}>30%</Text>
                </View>
            </View>

            <View style={styles.feed_container}>
                <View style={styles.feed_left}>
                    <Text style={styles.feed_pink}></Text>
                    <Text style={styles.feed_name}>Protein</Text>
                </View>
                <View style={styles.feed_right}>
                    <Text style={totalProtein < 20 ? styles.feed_value : styles.feed_redValue}>{totalProtein ? totalProtein : 0}%</Text>
                    <Text style={styles.feed_calori}>20%</Text>
                </View>
            </View>

        </View>
    )
}

export default MakroCard
