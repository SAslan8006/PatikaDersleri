import React from 'react'
import { View, ScrollView } from 'react-native'
import DailyHeader from "../../../components/DailyCard/DailyHeader"

import BreakfastCard from '../../../components/DailyCard/FeedCard/BreakfastCard'
import DinnerCard from '../../../components/DailyCard/FeedCard/DinnerCard'
import LunchCard from '../../../components/DailyCard/FeedCard/LunchCard'
import styles from "./Daily.style"

const Daily = ({ navigation }) => {


    const handleNext = (name) => {
        navigation.navigate("selectFoodPage", { name })
    }



    return (
        <>
            <DailyHeader />
            <ScrollView nestedScrollEnabled={true} >
                <BreakfastCard name="Kahvaltı" onNext={() => handleNext("Kahvaltı")} />
                <LunchCard name="Öğle Yemeği" onNext={() => handleNext("Öğle Yemeği")} />
                <DinnerCard name="Akşam Yemeği" onNext={() => handleNext("Akşam Yemeği")} />
            </ScrollView>
        </>

    )
}

export default Daily
