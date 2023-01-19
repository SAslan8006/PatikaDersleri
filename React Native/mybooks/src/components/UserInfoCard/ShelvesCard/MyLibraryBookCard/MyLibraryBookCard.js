import React, { useContext } from 'react'
import { View } from 'react-native'
import { BookContext } from '../../../../context/BookContext'
import MyLibraryCard from './MyLibraryCard'

const MyLibraryBookCard = () => {
    const { myLibraryBook } = useContext(BookContext)
    return (
        <View>
            {
                myLibraryBook.map(item => (
                    <MyLibraryCard mylibrarybook={item} key={item.id} />
                ))
            }
        </View>
    )
}

export default MyLibraryBookCard
