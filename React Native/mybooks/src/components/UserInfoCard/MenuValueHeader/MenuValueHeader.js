import React from 'react'
import { View, Text } from 'react-native'
import styles from "./MenuValueHeader.style"
const MenuValueHeader = ({ name, active, handleMenuClick }) => {
    const isActive = active === name;
    return (
        <View style={styles.container}>
            <Text style={isActive ? styles.isActive : styles.title} onPress={() => handleMenuClick(name)}>{name}</Text>

        </View>
    )
}

export default MenuValueHeader
