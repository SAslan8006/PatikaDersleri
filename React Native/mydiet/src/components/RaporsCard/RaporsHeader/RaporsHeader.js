import React from 'react'
import { Text } from 'react-native'
import styles from "./RaporsHeader.style"
const RaporsHeader = ({ name, active, handleMenuClick }) => {

    const isActive = active === name;
    return (
        <Text style={isActive ? styles.isActive : styles.kalorimakro} onPress={() => handleMenuClick(name)}>{name}</Text>

    )
}

export default RaporsHeader
