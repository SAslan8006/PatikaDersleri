import React, { useContext } from 'react'
import { View, Text } from 'react-native'
import CaloriFeedCard from '../../../components/RaporsCard/Calories'
import FoodEatenCard from '../../../components/RaporsCard/FoodEatenCard'
import { FoodValueContext } from '../../../context/FoodValueContext'
import styles from "./Calories.style"
import { UserInfoContext } from '../../../context/UserInfoContext';
const Calories = () => {

    const { breakCalori, dinnerCalori, lunchCalori } = useContext(FoodValueContext)
    const { userInfo } = useContext(UserInfoContext)




    return (
        <>
            <View style={styles.top_container}>
                <View style={styles.top_header}>
                    <Text style={styles.top_cal}>Kalori: {breakCalori + dinnerCalori + lunchCalori}</Text>
                    <Text style={styles.top_target}>Hedef:{userInfo.TGD} kcal</Text>
                </View>
                <CaloriFeedCard breakCalori={breakCalori} dinnerCalori={dinnerCalori} lunchCalori={lunchCalori} />
            </View>
            <FoodEatenCard />
        </>
    )
}

export default Calories
