import React, { useContext } from 'react'
import { View } from 'react-native'
import { BookContext } from '../../../../context/BookContext'
import WillBookCard from './WillBookCard'

const ReadWillBookCard = ({ handleBookToggle, bookModalVisible }) => {
    const { willReadBook } = useContext(BookContext)
    return (
        <View>
            {
                willReadBook.map(item => (
                    <WillBookCard willbook={item} key={item.id} handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} />
                ))
            }
        </View>
    )
}

export default ReadWillBookCard
