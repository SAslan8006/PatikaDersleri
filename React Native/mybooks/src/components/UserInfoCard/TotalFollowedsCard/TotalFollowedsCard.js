import React from 'react'
import { View, FlatList } from 'react-native'

import FollowedsCard from './FollowedsCard'

const TotalFollowedsCard = ({ handleUserPage, followedsList }) => {


    const renderUsers = ({ item }) => <FollowedsCard user={item} handleUserPage={handleUserPage} />
    return (
        <View>
            <FlatList
                data={followedsList}
                renderItem={renderUsers}
            />
        </View>
    )
}

export default TotalFollowedsCard
