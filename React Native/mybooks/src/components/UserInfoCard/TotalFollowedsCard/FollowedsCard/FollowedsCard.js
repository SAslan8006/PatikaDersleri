import React, { useState } from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import styles from "./FollowedsCard.style"
import Button from "../../../Button"
const FollowedsCard = ({ user, handleUserPage }) => {

    return (
        <View style={styles.container}>
            <TouchableOpacity onPress={() => handleUserPage([user?.followedUser])} style={styles.container_touch}>
                <Image source={{ uri: user?.followedUser?.profileImage }} style={styles.image} />
                <View style={styles.info}>
                    <Text style={styles.fullname}>{user?.followedUser?.fullName}</Text>
                    <Text style={styles.username}>@{user?.followedUser?.userName}</Text>
                </View>
            </TouchableOpacity>
            <Button text="Takiptesin" theme={user?.followed ? "unfollow" : "follow"} onPress={() => { }} />
        </View>
    )
}

export default FollowedsCard
