import React, { useEffect, useContext, useState } from 'react'
import { View, Text, TouchableOpacity, } from 'react-native'
import { FoodValueContext } from '../../../context/FoodValueContext'
import { UserInfoContext } from '../../../context/UserInfoContext'
import styles from "./FoodInfo.style"

const FoodInfo = ({ navigation, route }) => {
    const [values, setValuees] = useState([])
    const [nutValue, setNutValue] = useState([])
    const [fat, setFat] = useState()
    const [protein, setProtein] = useState()
    const [carbon, setCarbon] = useState()
    const [calori, setCalori] = useState()

    const { userInfo } = useContext(UserInfoContext)

    const { foodValue, setBreakFat, setBreakPro, setBreakCarb, setBreakTgd, setBreakCalori,
        dinnerFat, setDinnerFat, dinnerPro, setDinnerPro, dinnerCarb, setDinnerCarb, dinnerTgd,
        setDinnerTgd, setDinnerCalori, setLunchFat, setLunchPro, setLunchCarb, setLunchTgd, setLunchCalori,
        breakfastValue, lunchValue, dinnerValue, totalCountFood, setTotalCountFood, countTotal, setCountTotal } = useContext(FoodValueContext)
    const { food, name } = route.params;
    const foodTgd = Math.floor(food.nf_calories * 100 / userInfo.TGD)


    const Nutrients = () => {
        // 203 -> protein, 204 -> yağ, 205 -> karbonhidrat

        food.full_nutrients.forEach(item => {
            if (item.attr_id === 203) {
                nutValue.push({ ...item })
                setProtein(Math.floor(item.value))
            } else if (item.attr_id === 204) {
                nutValue.push({ ...item })
                setFat(Math.floor(item.value))
            } else if (item.attr_id === 205) {
                nutValue.push({ ...item })
                setCarbon(Math.floor(item.value))
            }
        })

        const foodContent = {
            food_name: food.brand_name,
            value: nutValue
        }

        values.push(foodContent)
    }
    const handleSaveFood = () => {

        const foodContent = {
            feed: name,
            food_name: food.brand_name,
            calori: Math.floor(food.nf_calories),
            fat,
            protein,
            carbon,
            foodTgd
        }



        foodValue.push(foodContent)
        if (foodContent.feed == "Kahvaltı") {
            setBreakFat((prev) => prev + fat)
            setBreakPro((prev) => prev + protein)
            setBreakCarb((prev) => prev + carbon)
            setBreakTgd((prev) => prev + foodTgd)
            setBreakCalori((prev) => prev + Math.floor(food.nf_calories))
            setCountTotal((prev) => prev + 1)
            breakfastValue.push(foodContent)
        } else if (foodContent.feed == "Öğle Yemeği") {
            setLunchFat((prev) => prev + fat)
            setLunchPro((prev) => prev + protein)
            setLunchCarb((prev) => prev + carbon)
            setLunchTgd((prev) => prev + foodTgd)
            setLunchCalori((prev) => prev + Math.floor(food.nf_calories))
            setCountTotal((prev) => prev + 1)
            lunchValue.push(foodContent)
        } else if (foodContent.feed == "Akşam Yemeği") {
            setDinnerFat((prev) => prev + fat)
            setDinnerPro((prev) => prev + protein)
            setDinnerCarb((prev) => prev + carbon)
            setDinnerTgd((prev) => prev + foodTgd)
            setDinnerCalori((prev) => prev + Math.floor(food.nf_calories))
            setCountTotal((prev) => prev + 1)
            dinnerValue.push(foodContent)
        }

        const foodCount = {
            food_name: food.brand_name,
            calori: Math.floor(food.nf_calories),
            fat,
            protein,
            carbon,
            count: 1
        }

        if (totalCountFood.length > 0) {
            if (totalCountFood.find(item => item.food_name == foodCount.food_name)) {
                const total = totalCountFood.map(item => item.food_name == foodCount.food_name ?
                    { ...item, count: item.count + 1 } : item)
                setTotalCountFood(total)

            } else {
                totalCountFood.push(foodCount)

            }
        } else {
            totalCountFood.push(foodCount)


        }


        navigation.goBack()
    }

    useEffect(() => {
        Nutrients()

    }, [])
    return (
        <View style={styles.container}>
            <Text style={styles.title}>{food.brand_name}</Text>
            <View style={styles.value_container}>
                <View style={styles.value}>
                    <Text style={styles.value_title}>Kalori</Text>
                    <Text style={styles.value_count}>{`${Math.floor(food.nf_calories)} (%${foodTgd})`}</Text>
                </View>
                <View style={styles.value}>
                    <Text style={styles.value_title}>Yağ</Text>
                    <Text style={styles.value_count}>{fat}g</Text>
                </View>
                <View style={styles.value}>
                    <Text style={styles.value_title}>Karb</Text>
                    <Text style={styles.value_count}>{carbon}g</Text>
                </View>
                <View style={styles.value}>
                    <Text style={styles.value_title}>Protein</Text>
                    <Text style={styles.value_count}>{protein}g</Text>
                </View>
            </View>
            <TouchableOpacity style={styles.button} onPress={handleSaveFood}>
                <Text style={styles.button_text}>Kaydet</Text>
            </TouchableOpacity>
        </View>
    )
}

export default FoodInfo
