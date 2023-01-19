import React, { useContext, useEffect, useState } from 'react'
import { View, Text, TouchableOpacity } from 'react-native'
import database from "@react-native-firebase/database"
import { BookContext } from '../../../context/BookContext'
import styles from "./InfoValues.style"
import parseContentData from '../../../utils/parseContentData'
const InfoValues = ({ handleSelectValue, userInfo, userComment }) => {
    const { readBook } = useContext(BookContext)
    const [followedsList, setFollowedsList] = useState([])
    const [followersList, setFollowersList] = useState([])
    useEffect(() => {
        const [{ id }] = userInfo
        database().ref(`users/${id}/followeds`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setFollowedsList(parsedData)
            //console.log(parsedData)
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
            <View style={styles.container_info}>
                <Text style={styles.value}>{readBook.length}</Text>
                <Text style={styles.book}> Kitap</Text>
            </View>
            <TouchableOpacity style={styles.container_info} onPress={() => handleSelectValue("Takip Edilen")}>
                <Text style={styles.value}>{followedsList?.length}</Text>
                <Text style={styles.followeds}> Takip edilen</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.container_info} onPress={() => handleSelectValue("Takipçileri")}>
                <Text style={styles.value}>{followersList?.length}</Text>
                <Text style={styles.followers}> Takipçi</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.container_info} onPress={() => { }}>
                <Text style={styles.value}>{userComment?.length}</Text>
                <Text style={styles.comments}> Yorum</Text>
            </TouchableOpacity>




        </View>
    )
}

export default InfoValues
