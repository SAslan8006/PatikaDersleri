import React, { useContext } from 'react'
import { View } from 'react-native'
import { BookContext } from '../../../../context/BookContext'
import NowBookCard from './NowBookCard'

const NowReadBookCard = ({ handleBookToggle, bookModalVisible }) => {
    const { readingBook } = useContext(BookContext)
    return (
        <View>
            {
                readingBook.map(item => (
                    <NowBookCard readingbook={item} key={item.id} handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} />
                ))
            }
        </View>
    )
}

export default NowReadBookCard
