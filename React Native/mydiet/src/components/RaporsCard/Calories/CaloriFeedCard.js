import React from 'react'
import { View, Text } from 'react-native'
import styles from "./CaloriFeedCard.style"
const CaloriFeedCard = ({ breakCalori, dinnerCalori, lunchCalori }) => {
    return (
        <View>
            <View style={styles.cal_title}>
                <Text style={styles.title}>Kal</Text>
                <Text style={styles.title}>(kcal)</Text>
            </View>
            <View style={styles.feed_container}>
                <View style={styles.feed_left}>
                    <Text style={styles.feed_orange}></Text>
                    <Text style={styles.feed_name}>Kahvaltı</Text>
                </View>
                <View style={styles.feed_right}>
                    <Text style={styles.feed_value}>({breakCalori ? Math.floor(100 * breakCalori / (breakCalori + dinnerCalori + lunchCalori)) : 0}%)</Text>
                    <Text style={styles.feed_calori}>{breakCalori ? breakCalori : "-"}</Text>
                </View>
            </View>
            <View style={styles.feed_container}>
                <View style={styles.feed_left}>
                    <Text style={styles.feed_blue}></Text>
                    <Text style={styles.feed_name}>Öğle Yemeği</Text>
                </View>
                <View style={styles.feed_right}>
                    <Text style={styles.feed_value}>({lunchCalori ? Math.floor(100 * lunchCalori / (breakCalori + dinnerCalori + lunchCalori)) : 0}%)</Text>
                    <Text style={styles.feed_calori}>{lunchCalori ? lunchCalori : "-"}</Text>
                </View>
            </View>
            <View style={styles.feed_container}>
                <View style={styles.feed_left}>
                    <Text style={styles.feed_pink}></Text>
                    <Text style={styles.feed_name}>Akşam Yemeği</Text>
                </View>
                <View style={styles.feed_right}>
                    <Text style={styles.feed_value}>({dinnerCalori ? Math.floor(100 * dinnerCalori / (breakCalori + dinnerCalori + lunchCalori)) : 0}%)</Text>
                    <Text style={styles.feed_calori}>{dinnerCalori ? dinnerCalori : "-"}</Text>
                </View>
            </View>
        </View>
    )
}

export default CaloriFeedCard
