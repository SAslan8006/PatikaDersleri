import React from 'react'
import { View } from 'react-native'
import MakroFoodEatenCard from '../../../components/RaporsCard/MakroFoodEatenCard'
import MakroCard from '../../../components/RaporsCard/MakroCard'

import styles from "./Makro.style"
const Makro = () => {

    return (
        <View>
            <MakroCard />
            <MakroFoodEatenCard />
        </View>
    )
}

export default Makro
