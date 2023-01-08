import React, { useState, useEffect } from 'react'
import { View, Text, Image, FlatList } from 'react-native'
import styles from "./UserInfo.style"
import database from '@react-native-firebase/database';
import parseContentData from '../../utils/parseContentData';
import Icon from 'react-native-vector-icons/FontAwesome';
import UserInfoCard from '../../components/UserInfoCard';
const UserInfo = () => {
    const [userInfo, setUserInfo] = useState()

    useEffect(() => {
        database()
            .ref('/userinfo')
            .once('value')
            .then(snapshot => {
                const userInfoData = snapshot.val();
                const parsedInfoData = parseContentData(userInfoData || {})
                setUserInfo(parsedInfoData)
            });
    }, [])

    const renderUser = ({ item }) => <UserInfoCard userinfo={item} />

    return (
        <View style={styles.container}>
            <View style={styles.top_container}>
                <View style={styles.logo_container}>
                    <Image source={require('../../assets/alodiyet.png')} style={styles.logo} />
                </View>
                <View style={styles.icon_container}>
                    <Icon name="user-circle-o" size={100} style={styles.icon} />
                    <Text style={styles.username}>{userInfo && userInfo.map(item => item.username)}</Text>
                </View>
            </View>
            <View style={styles.bottom_container}>
                <FlatList
                    data={userInfo}
                    renderItem={renderUser}
                />
            </View>



        </View>
    )
}

export default UserInfo
