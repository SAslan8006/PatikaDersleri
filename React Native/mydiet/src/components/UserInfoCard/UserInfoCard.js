import React, { useState, useEffect, useContext } from 'react'
import { View, Text } from 'react-native'
import database from "@react-native-firebase/database"
import styles from "./UserInfoCard.style"
import { UserInfoContext } from '../../context/UserInfoContext'
const UserInfoCard = ({ userinfo }) => {
    const [tgd, setTgd] = useState()

    const { setUserInfo } = useContext(UserInfoContext)
    const handleTgd = () => {
        if (userinfo.gender == "male") {
            const bazMH = 10 * userinfo.weight + 6.25 * userinfo.height - 5 * userinfo.age + 5
            const TGD = Math.floor(bazMH * userinfo.level)
            setTgd(TGD)
        }
        if (userinfo.gender == "female") {
            const bazMH = 10 * userinfo.weight + 6.25 * userinfo.height - 5 * userinfo.age - 161
            const TGD = Math.floor(bazMH * userinfo.level)
            setTgd(TGD)
        }
    }
    useEffect(() => {
        handleTgd()
        setUserInfo(userinfo)

    }, [])
    if (tgd) {
        database().ref(`/userinfo/${userinfo.id}`).set({ ...userinfo, TGD: tgd })
    }

    return (
        <View style={styles.container}>
            <View style={styles.info_container}>
                <Text style={styles.user_title}>Gender: </Text>
                <Text style={styles.user_title}>{userinfo.gender}</Text>
            </View>
            <View style={styles.info_container}>
                <Text style={styles.user_title}>Age: </Text>
                <Text style={styles.user_title}>{userinfo.age}</Text>
            </View>
            <View style={styles.info_container}>
                <Text style={styles.user_title}>Weight: </Text>
                <Text style={styles.user_title}>{userinfo.weight} kg</Text>
            </View>
            <View style={styles.info_container}>
                <Text style={styles.user_title}>Height: </Text>
                <Text style={styles.user_title}>{userinfo.height} cm</Text>
            </View>
            <View style={styles.tgd_container}>
                <Text style={styles.tgd_title}>Tavsiye Edilen Günlük Değer</Text>
                <Text style={styles.tgd}>{userinfo.TGD} kaloridir</Text>
            </View>

        </View>
    )
}

export default UserInfoCard
