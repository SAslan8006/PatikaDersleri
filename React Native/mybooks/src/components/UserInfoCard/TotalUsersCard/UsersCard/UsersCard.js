import React, { useState, useEffect } from 'react'
import { View, Text, Image, TouchableOpacity, Alert } from 'react-native'

import styles from "./UsersCard.style"
import Button from "../../../Button"

const UsersCard = ({ user, handleUserPage, handlefollowedUser, followedsList }) => {
    const [followed, setFollowed] = useState(false)
    const [follower, setFollower] = useState()



    const userFollowedUser = (user) => {
        const [followedUser] = user
        const index = followedsList.findIndex(item => item.followedUser.email === followedUser.email)
        if (index < 0) {
            handlefollowedUser(user)


        } else {
            handleDeleteFollowed(followedUser)
        }


    }


    const handleDeleteFollowed = (item) => {
        Alert.alert(
            `Devam et`,
            "Takibi bırakmak istediğinize emin misiniz?",
            [
                {
                    text: "Evet",
                    onPress: () => {
                        /*      const [{ id }] = userInfo
                             const followedsUser = followedsList.find((v) => v.followedUser.email === item.email);
                     
                             await database().ref(`users/${id}/followeds/${followedsUser.id}`).remove(); */
                        Alert.alert("daha yapım aşamasında")

                    },
                    style: "destructive",
                },
                {
                    text: "Hayır",
                    onPress: () => console.log('Cancel Pressed'),
                    style: 'cancel',
                },

            ],
            {
                cancelable: true,

            }
        );


    }

    useEffect(() => {
        followedsList.forEach(item => {
            if (item?.followedUser?.email === user.email) {
                setFollowed(true)
            }
        });

    }, [user])



    return (
        <View style={styles.container}>
            <TouchableOpacity onPress={() => handleUserPage([user])} style={styles.container_touch}>
                <Image source={{ uri: user.profileImage }} style={styles.image} />
                <View style={styles.info}>
                    <Text style={styles.fullname}>{user.fullName}</Text>
                    <Text style={styles.username}>@{user.userName}</Text>
                </View>
            </TouchableOpacity>
            <Button text={followed ? "Takiptesin" : "Takip Et"} theme={followed ? "unfollow" : "follow"} onPress={() => userFollowedUser([user])} />
        </View>
    )
}

export default UsersCard
