import React, { useState } from 'react'
import { View, ScrollView, TouchableOpacity } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialIcons'
import UserProfileInfoCard from "../../../components/UserInfoCard/UserProfileInfoCard"
import InfoValues from "../../../components/UserInfoCard/InfoValues"
import styles from "./ShowSelectUser.style"
import MyLibrary from '../MyLibrary'
import Mypage from '../Mypage'
import MyComments from '../MyComments'
import MenuHeader from '../../../components/UserInfoCard/MenuHeader'
import { UserInfoContext } from '../../../context/UserInfoContext'

const ShowSelectUser = ({ navigation, route }) => {
    const { user, userInfo, mainUser } = route.params

    console.log(route.params)
    const menus = [
        { name: "Kitaplık" },
        { name: "Duvar" },
        { name: "Yorumlar" },
    ]
    const [active, setActive] = useState("Kitaplık")
    const handleMenuClick = (name) => {
        setActive(name)
    }

    const handleSelectedBook = (book) => {
        navigation.navigate("SelectedBookPage", { book, page: "ShowSelectUserPage" })
    }
    const handleSelectValue = (select) => {

        navigation.push("UserValuesPage", { select, userInfo: user, mainUser: !mainUser ? userInfo : mainUser })

    }
    const handleBackPage = () => {
        navigation.goBack()
    }
    return (
        <ScrollView style={styles.container} >
            <TouchableOpacity style={styles.header} onPress={handleBackPage}>
                <Icon name="keyboard-arrow-left" size={30} color="black" />
            </TouchableOpacity>
            <UserProfileInfoCard userInfo={user} />
            <InfoValues handleSelectValue={handleSelectValue} userInfo={user} />
            <View style={styles.menu_container}>
                {
                    menus.map(({ name }) => (
                        <MenuHeader name={name} key={name} active={active} handleMenuClick={handleMenuClick} />
                    ))
                }
            </View>
            {
                active === "Kitaplık" ? <MyLibrary userInfo={user} handleSelectedBook={handleSelectedBook} />
                    : active === "Duvar" ? <Mypage />
                        : <MyComments />

            }

        </ScrollView>
    )
}

export default ShowSelectUser
