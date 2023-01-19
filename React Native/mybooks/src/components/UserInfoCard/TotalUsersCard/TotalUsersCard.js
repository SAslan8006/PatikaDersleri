import React, { useState, useEffect } from 'react'
import { View, FlatList } from 'react-native'
import database from "@react-native-firebase/database"
import styles from "./TotalUsersCard.style"
import parseContentData from '../../../utils/parseContentData'
import UsersCard from './UsersCard'

const TotalUsersCard = ({ userInfo, handleUserPage, handlefollowedUser, followedsList, followersList }) => {
    const [userList, setUserList] = useState([])


    useEffect(() => {
        database().ref('users/').on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            const newUserList = [...parsedData]
            const index = parsedData.findIndex(item => item.email === userInfo[0].email)
            newUserList.splice(index, 1)
            setUserList(newUserList)
        })

    }, [])

    const renderUsers = ({ item }) => <UsersCard user={item} handleUserPage={handleUserPage} handlefollowedUser={handlefollowedUser} followedsList={followedsList} userInfo={userInfo} followersList={followersList} />
    return (
        <View>
            <FlatList
                data={userList}
                renderItem={renderUsers}
            />
        </View>
    )
}

export default TotalUsersCard
