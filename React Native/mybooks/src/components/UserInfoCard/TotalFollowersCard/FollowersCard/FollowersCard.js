import React, { useEffect, useState } from 'react'
import { View, Text, TouchableOpacity, Image } from 'react-native'
import Button from '../../../Button'
import styles from "./FollowersCard.style"
const FollowersCard = ({ handlefollowedUser, handleUserPage, user, followedsList }) => {
    const [followed, setFollowed] = useState(false)

    const userFollowedUser = (user) => {
        const [followedUser] = user
        const index = followedsList.findIndex(item => item.followedUser.email === followedUser.followerUser.email)
        if (index < 0) {

            handlefollowedUser([followedUser.followerUser])

        } else {


        }

    }

    useEffect(() => {
        followedsList.forEach(item => {
            if (item?.followedUser?.email === user.followerUser.email) {
                setFollowed(true)
            }

        });

    }, [user])



    return (
        <View style={styles.container}>
            <TouchableOpacity onPress={() => handleUserPage([user?.followerUser])} style={styles.container_touch}>
                <Image source={{ uri: user?.followerUser?.profileImage }} style={styles.image} />
                <View style={styles.info}>
                    <Text style={styles.fullname}>{user?.followerUser?.fullName}</Text>
                    <Text style={styles.username}>@{user?.followerUser?.userName}</Text>
                </View>
            </TouchableOpacity>
            <Button text={followed ? "Takiptesin" : "Takip Et"} theme={followed ? "unfollow" : "follow"} onPress={() => userFollowedUser([user])} />
        </View>
    )
}

export default FollowersCard
