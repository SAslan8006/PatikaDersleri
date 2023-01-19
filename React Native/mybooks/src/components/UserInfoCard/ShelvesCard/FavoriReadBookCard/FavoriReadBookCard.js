import React, { useContext } from 'react'
import { View } from 'react-native'
import { BookContext } from '../../../../context/BookContext'
import FavoriCard from './FavoriCard'

const FavoriReadBookCard = ({ handleBookToggle, bookModalVisible }) => {
    const { favoriBook } = useContext(BookContext)

    return (
        <View>
            {
                favoriBook.map(item => (
                    <FavoriCard favoribook={item} key={item.id} handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} />
                ))
            }
        </View>
    )

}

export default FavoriReadBookCard
