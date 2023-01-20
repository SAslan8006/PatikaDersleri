import React from 'react'
import { View, Text, ScrollView } from 'react-native'
import auth from "@react-native-firebase/auth"
import Icon from 'react-native-vector-icons/MaterialCommunityIcons'
import styles from "./Header.style"
import HeaderCard from './HeaderCard'
const Header = ({ menus, handleMenuClick, active }) => {

    return (
        <View style={styles.container}>
            <View style={styles.header_top}>
                <Text style={styles.title}>{active}</Text>
                <Icon name="logout" size={23} color="white" onPress={() => auth().signOut()} />
            </View>
            <ScrollView horizontal showsHorizontalScrollIndicator={false} style={styles.title_container}>
                {
                    menus.map(({ name }) => (
                        <HeaderCard name={name} key={name} active={active} handleMenuClick={handleMenuClick} />
                    ))
                }
            </ScrollView>
        </View>
    )
}

export default Header
