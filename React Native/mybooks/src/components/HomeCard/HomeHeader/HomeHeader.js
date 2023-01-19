import React from 'react'
import { View, TouchableOpacity } from 'react-native'
import Icon from 'react-native-vector-icons/Octicons'
import styles from "./HomeHeader.style"
const HomeHeader = ({ onPress }) => {

    return (
        <View style={styles.container}>
            <TouchableOpacity onPress={onPress}>
                <Icon name="search" size={30} />
            </TouchableOpacity>
        </View>
    )
}

export default HomeHeader
