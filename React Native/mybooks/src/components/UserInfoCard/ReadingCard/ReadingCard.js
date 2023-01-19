import React, { useEffect, useContext } from 'react'
import { View, Text, ScrollView, Image, TouchableOpacity } from 'react-native'
import database from "@react-native-firebase/database"
import Icon from 'react-native-vector-icons/FontAwesome'
import styles from "./ReadingCard.style"
import parseContentData from '../../../utils/parseContentData'
import { BookContext } from '../../../context/BookContext'
const ReadingCard = ({ userInfo, handleSelectedBook }) => {
    const { readingBook, setReadingBook } = useContext(BookContext)
    useEffect(() => {
        const [{ id }] = userInfo
        database().ref(`users/${id}/reading`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setReadingBook(parsedData)
            //console.log(parsedData)

        })
    }, [])


    return (
        <ScrollView horizontal showsHorizontalScrollIndicator={false} style={styles.now_reading_container}>
            {
                readingBook.map(item => (
                    <TouchableOpacity style={styles.now_reading} key={item.id} onPress={() => handleSelectedBook(item.book)}>
                        {
                            item.book.imageLinks?.thumbnail ?

                                <Image style={styles.now_reading_image}
                                    source={{ uri: item.book.imageLinks.thumbnail }} />

                                :

                                <View style={styles.icon_image}><Icon name="book" size={40} /></View>

                        }
                        <View style={styles.now_reading_info}>
                            <Text style={styles.now_reading_name}>{item?.book?.title.length > 20 ? item?.book?.title.slice(0, 20) : item?.book?.title}</Text>
                            <Text style={styles.now_reading_author}>{item?.book?.authors}</Text>
                        </View>
                    </TouchableOpacity>
                ))
            }

        </ScrollView>
    )
}

export default ReadingCard
