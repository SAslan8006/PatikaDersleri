import React, { useContext, useEffect } from 'react'
import { View } from 'react-native'
import { BookContext } from '../../../context/BookContext'
import UserWallCard from '../../UserWallCard'


const TotalWall = ({ handlesendComment }) => {
    const { userTotalWall, handleFavoriCount } = useContext(BookContext)

    return (
        <View>
            {
                userTotalWall.map((item, i) => (
                    <UserWallCard wall={item} key={i} handleFavoriCount={handleFavoriCount} handlesendComment={handlesendComment} />
                ))
            }
        </View>
    )
}

export default TotalWall
