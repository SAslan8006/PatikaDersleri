import React, { useEffect, useContext } from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import database from "@react-native-firebase/database"
import Icon from 'react-native-vector-icons/FontAwesome'
import parseContentData from '../../../utils/parseContentData'
import styles from "./ReadBookCard.style"
import { BookContext } from '../../../context/BookContext'
const ReadBookCard = ({ userInfo, handleSelectedBook }) => {
    const { readBook, setReadBook } = useContext(BookContext)
    useEffect(() => {
        const [{ id }] = userInfo
        database().ref(`users/${id}/read`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setReadBook(parsedData)
            //console.log(parsedData)

        })
    }, [])

    return (
        <View style={styles.container}>
            <View style={styles.container_read}>
                <Text style={styles.read_title}>Okuduğu kitaplar </Text>
                <Text style={styles.read_count}>{readBook.length} kitap</Text>
            </View>
            <View style={styles.container_image}>
                {
                    readBook.length < 10 ?
                        readBook.map(item => (
                            item.book.imageLinks?.thumbnail ?
                                <TouchableOpacity onPress={() => handleSelectedBook(item.book)} key={item.id}>
                                    <Image source={{ uri: item.book.imageLinks.thumbnail }} style={styles.image} />
                                </TouchableOpacity>
                                :
                                <TouchableOpacity onPress={() => handleSelectedBook(item.book)} key={item.id}>
                                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
                                </TouchableOpacity>
                        ))
                        :
                        readBook.slice(0, 10).map(item => (
                            item.book.imageLinks?.thumbnail ?
                                <TouchableOpacity onPress={() => handleSelectedBook(item.book)} key={item.id}>
                                    <Image source={{ uri: item.book.imageLinks.thumbnail }} style={styles.image} />
                                </TouchableOpacity>
                                :
                                <TouchableOpacity onPress={() => handleSelectedBook(item.book)} key={item.id}>
                                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
                                </TouchableOpacity>
                        ))

                }
            </View>

        </View>
    )
}

export default ReadBookCard
