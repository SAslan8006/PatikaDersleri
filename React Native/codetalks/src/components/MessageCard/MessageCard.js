import React, { useEffect, useState } from 'react'
import { View, Text } from 'react-native'
import auth from "@react-native-firebase/auth"
import { formatDistance, parseISO } from 'date-fns'
import { tr } from "date-fns/locale"
import styles from "./MessageCard.style"
const MessageCard = ({ message }) => {
    const [user, setUser] = useState()
    useEffect(() => {
        auth().onAuthStateChanged(user => {
            if (user) {
                setUser(user.email.split('@')[0])

            }

        })
    }, [])


    const formattedDate = formatDistance(parseISO(message.date), new Date(), {
        addSuffix: true,
        locale: tr,
    })

    return (
        <View style={user !== message.username ? styles.container : styles.otherContainer}>
            <View style={styles.title_container}>
                <Text style={styles.username}>{user === message.username ? "you" : message.username}</Text>
                <Text style={styles.date}>{formattedDate}</Text>
            </View>
            <Text style={styles.message}>{message.text}</Text>
        </View>
    )
}

export default MessageCard
