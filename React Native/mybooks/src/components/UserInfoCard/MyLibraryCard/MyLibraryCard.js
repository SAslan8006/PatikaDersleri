import React, { useEffect, useContext } from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import database from "@react-native-firebase/database"
import Icon from 'react-native-vector-icons/FontAwesome'
import parseContentData from '../../../utils/parseContentData'
import { BookContext } from '../../../context/BookContext'
import styles from "./MyLibraryCard.style"
const MyLibraryCard = ({ userInfo, handleSelectedBook }) => {
    const { myLibraryBook, setMyLibrary } = useContext(BookContext)

    useEffect(() => {
        const [{ id }] = userInfo
        database().ref(`users/${id}/mylibrary`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setMyLibrary(parsedData)
            //console.log(parsedData)

        })
    }, [])

    return (
        <View style={styles.container}>
            <View style={styles.container_read}>
                <Text style={styles.read_title}>Kütüphanesindekiler </Text>
                <Text style={styles.read_count}>{myLibraryBook.length} kitap</Text>
            </View>
            <View style={styles.container_image}>
                {
                    myLibraryBook.length < 10 ?
                        myLibraryBook.map(item => (
                            item.book.imageLinks?.thumbnail ?
                                <TouchableOpacity onPress={() => handleSelectedBook(item.book, "UserInfoPage")} key={item.id}>
                                    <Image source={{ uri: item.book.imageLinks.thumbnail }} style={styles.image} />
                                </TouchableOpacity>
                                :
                                <TouchableOpacity onPress={() => handleSelectedBook(item.book, "UserInfoPage")} key={item.id}>
                                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
                                </TouchableOpacity>
                        ))
                        :
                        myLibraryBook.slice(0, 10).map(item => (
                            item.book.imageLinks?.thumbnail ?
                                <TouchableOpacity onPress={() => handleSelectedBook(item.book, "UserInfoPage")} key={item.id}>
                                    <Image source={{ uri: item.book.imageLinks.thumbnail }} style={styles.image} />
                                </TouchableOpacity>
                                :
                                <TouchableOpacity onPress={() => handleSelectedBook(item.book, "UserInfoPage")} key={item.id}>
                                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
                                </TouchableOpacity>
                        ))

                }
            </View>

        </View>
    )
}

export default MyLibraryCard
