import React, { useContext, useState, useEffect } from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialIcons'
import database from "@react-native-firebase/database"
import MenuValueHeader from '../../../components/UserInfoCard/MenuValueHeader/MenuValueHeader'
import TotalUsersCard from '../../../components/UserInfoCard/TotalUsersCard'
import { UserInfoContext } from '../../../context/UserInfoContext'
import styles from "./UserValues.style"
import TotalFollowersCard from '../../../components/UserInfoCard/TotalFollowersCard'
import TotalFollowedsCard from '../../../components/UserInfoCard/TotalFollowedsCard'
import parseContentData from '../../../utils/parseContentData'
const UserValues = ({ navigation, route }) => {
    const [followedsList, setFollowedsList] = useState([])
    const [followersList, setFollowersList] = useState([])

    const { handlefollowedUser } = useContext(UserInfoContext)
    const { select, userInfo, mainUser } = route.params
    console.log(route.params)

    const menus = [
        { name: "Takip Edilen" },
        { name: "Takipçileri" },
        { name: "Öneriler" },
    ]
    const [active, setActive] = useState(select)
    const handleMenuClick = (name) => {
        setActive(name)
    }
    const handleBack = () => {
        navigation.goBack()


    }
    const handleUserPage = (user) => {
        navigation.push("ShowSelectUserPage", { user, select, userInfo, mainUser })


    }
    useEffect(() => {
        const [{ id }] = userInfo
        database().ref(`users/${id}/followeds`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setFollowedsList(parsedData)

        })
    }, [])


    useEffect(() => {
        const [{ id }] = userInfo
        database().ref(`users/${id}/followers`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setFollowersList(parsedData)
            //console.log(parsedData)
        })
    }, [])

    return (
        <View style={styles.container}>
            <View style={styles.container_header}>
                <TouchableOpacity onPress={handleBack} style={styles.arrow_back}>
                    <Icon name="keyboard-arrow-left" size={32} color="black" />
                </TouchableOpacity>
                <TouchableOpacity onPress={handleBack} style={styles.userinfo_container}>
                    <Image source={{ uri: userInfo[0].profileImage }} style={styles.image} />
                    <View style={styles.userinfo}>
                        <Text style={styles.fullName}>{userInfo[0].fullName}</Text>
                        <Text style={styles.userName}>@{userInfo[0].userName}</Text>
                    </View>
                </TouchableOpacity>
            </View>
            <View style={styles.menu_container}>
                {
                    menus.map(({ name }) => (
                        <MenuValueHeader name={name} key={name} active={active} handleMenuClick={handleMenuClick} />
                    ))
                }
            </View>
            {
                active === "Takip Edilen" ? <TotalFollowedsCard userInfo={userInfo} handleUserPage={handleUserPage} followedsList={followedsList} followersList={followersList} />
                    : active === "Takipçileri" ? <TotalFollowersCard handlefollowedUser={handlefollowedUser} userInfo={userInfo} handleUserPage={handleUserPage} followedsList={followedsList} followersList={followersList} />
                        :
                        <TotalUsersCard userInfo={userInfo} handleUserPage={handleUserPage} handlefollowedUser={handlefollowedUser} followedsList={followedsList} followersList={followersList} />
            }



        </View>
    )
}

export default UserValues
