import React from 'react'
import { View, FlatList } from 'react-native'
import FollowersCard from './FollowersCard'

const TotalFollowersCard = ({ handleUserPage, handlefollowedUser, followedsList, followersList }) => {


    const renderUsers = ({ item }) => <FollowersCard user={item} handleUserPage={handleUserPage} handlefollowedUser={handlefollowedUser} followedsList={followedsList} />
    return (
        <View>
            <FlatList
                data={followersList}
                renderItem={renderUsers}
            />
        </View>
    )
}

export default TotalFollowersCard
