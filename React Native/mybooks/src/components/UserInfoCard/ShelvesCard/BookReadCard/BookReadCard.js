import React, { useContext } from 'react'
import { View } from 'react-native'
import { BookContext } from '../../../../context/BookContext'
import ReadCard from './ReadCard'

const BookReadCard = ({ handleBookToggle, bookModalVisible }) => {
    const { readBook } = useContext(BookContext)
    return (
        <View>
            {
                readBook.map(item => (
                    <ReadCard readbook={item} key={item.id} handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} />
                ))
            }
        </View>
    )
}

export default BookReadCard
