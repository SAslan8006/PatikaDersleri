import React from 'react'
import { View, Text } from 'react-native'
import styles from "./MenuHeader.style"
const MenuHeader = ({ name, active, handleMenuClick }) => {
    const isActive = active === name;
    return (
        <View style={styles.container}>
            <Text style={isActive ? styles.isActive : styles.myprofile} onPress={() => handleMenuClick(name)}>{name}</Text>

        </View>
    )
}

export default MenuHeader
