import React, { useState, useContext } from 'react'
import { View, Text, TouchableOpacity, Alert } from 'react-native'
import { SwipeListView } from 'react-native-swipe-list-view';
import Collapsible from 'react-native-collapsible';
import Icon from 'react-native-vector-icons/FontAwesome5'
import { FoodValueContext } from '../../../../context/FoodValueContext'
import colors from '../../../../styles/colors'
import FoodDetailCard from '../../FoodDetailCard'
import styles from "./BreakfastCard.style"
const BreakfastCard = ({ name, onNext }) => {
    const [isCollapsed, setIsCollapsed] = useState(true)

    const { breakfastValue, breakFat, breakPro, breakCarb, breakTgd, breakCalori, setBreakfastValue,
        setBreakFat, setBreakPro, setBreakCarb, setBreakTgd, setBreakCalori, countTotal, setCountTotal, totalCountFood, setTotalCountFood } = useContext(FoodValueContext)
    const handleInputToggle = () => {
        onNext()
    }


    const handleToggleCollapse = () => {
        setIsCollapsed(!isCollapsed)
    }
    const handleDanger = (item) => {
        Alert.alert(
            `${item.food_name} silinecek`,
            `${item.food_name} silmek istediğinize emin misiniz?`,
            [
                {
                    text: 'İptal',
                    onPress: () => console.log('Cancel Pressed'),
                    style: 'cancel',
                },
                {
                    text: 'Sil',
                    onPress: () => {
                        const newFood = [...breakfastValue];
                        const index = breakfastValue.findIndex((v) => v.food_name === item.food_name);
                        newFood.splice(index, 1);
                        setBreakfastValue(newFood);
                        setBreakFat(breakFat - item.fat)
                        setBreakCarb(breakCarb - item.carbon)
                        setBreakPro(breakPro - item.protein)
                        setBreakTgd(breakTgd - item.foodTgd)
                        setBreakCalori(breakCalori - item.calori)
                        setCountTotal(countTotal - 1)

                        const newTotalFood = [...totalCountFood];
                        if (newTotalFood.find((v) => v.food_name === item.food_name)) {
                            const newTotalCountFood = newTotalFood.map(v => v.food_name === item.food_name ?
                                { ...v, count: v.count > 1 ? v.count - 1 : 0 } : v)
                            setTotalCountFood(newTotalCountFood)


                        }

                    },
                    style: 'destructive',
                },
            ],
            { cancelable: false },
        );
    };

    const backButtonWidth = 27;
    const openWidth = backButtonWidth * 2;
    const renderFoodDetail = ({ item, index }) => <FoodDetailCard food={item} styleCollapse={(index === breakfastValue.length - 1) ? styles.collapsedlast : styles.containerFoodDetail} />
    return (
        <>
            <TouchableOpacity style={breakfastValue.length > 0 ? styles.container_foodValue : styles.container} onPress={handleInputToggle}>
                <Text style={styles.title}>{name}</Text>
                <View style={styles.container_right}>
                    <View style={styles.total_cal}>
                        {
                            breakCalori ?
                                <>
                                    <Text style={styles.cal}>{breakCalori.toString()}</Text>
                                    <Text style={styles.cal_title}>Kalori</Text>
                                </>
                                : null
                        }
                    </View>
                    <Icon name="plus" color={colors.darkGreen} size={30} />
                </View>
            </TouchableOpacity>
            {breakfastValue.length > 0 ?
                <TouchableOpacity style={isCollapsed ? styles.foodValue_container : styles.foodValue_collapse} onPress={handleToggleCollapse}>
                    <Text style={styles.foodValue_text}>{breakFat.toString()}</Text>
                    <Text style={styles.foodValue_text}>{breakCarb.toString()}</Text>
                    <Text style={styles.foodValue_text}>{breakPro.toString()}</Text>
                    <Text style={styles.foodValue_text}>%{breakTgd.toString()}</Text>
                    {
                        isCollapsed ? <Icon name="arrow-down" size={20} style={styles.foodValue_icon} />
                            : <Icon name="arrow-up" size={20} style={styles.foodValue_icon} />
                    }

                </TouchableOpacity>
                : null
            }
            {

                <Collapsible collapsed={isCollapsed} duration={400}>
                    <SwipeListView
                        data={breakfastValue}
                        renderItem={renderFoodDetail}
                        keyExtractor={(_, index) => index.toString()}
                        renderHiddenItem={({ item, index }) => (
                            <View style={index === breakfastValue.length - 1 ? styles.lastrowBack : styles.rowBack}>
                                <TouchableOpacity
                                    style={[styles.backRightBtn, index === breakfastValue.length - 1 ? styles.lastdangerBtn : styles.dangerBtn]}
                                    onPress={() => handleDanger(item)}>
                                    <Text style={styles.backTextDanger}>Sil</Text>
                                </TouchableOpacity>
                            </View>
                        )}
                        leftOpenValue={openWidth}
                        rightOpenValue={-openWidth}
                        stopLeftSwipe={1}
                        stopRightSwipe={-openWidth}
                    />

                </Collapsible>

            }
        </>

    )
}

export default BreakfastCard
