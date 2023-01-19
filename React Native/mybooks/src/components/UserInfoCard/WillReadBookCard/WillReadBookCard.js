import React, { useEffect, useContext } from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import database from "@react-native-firebase/database"
import Icon from 'react-native-vector-icons/FontAwesome'
import parseContentData from '../../../utils/parseContentData'
import { BookContext } from '../../../context/BookContext'
import styles from "./WillReadBookCard.style"
const WillReadBookCard = ({ userInfo, handleSelectedBook }) => {
    const { willReadBook, setWillReadBook } = useContext(BookContext)
    useEffect(() => {
        const [{ id }] = userInfo
        database().ref(`users/${id}/willread`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setWillReadBook(parsedData)

        })
    }, [])

    return (
        <View style={styles.container}>
            <View style={styles.container_read}>
                <Text style={styles.read_title}>Okuyacağı kitaplar </Text>
                <Text style={styles.read_count}>{willReadBook.length} kitap</Text>
            </View>
            <View style={styles.container_image}>
                {
                    willReadBook.length < 10 ?
                        willReadBook.map(item => (
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
                        willReadBook.slice(0, 10).map(item => (
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

export default WillReadBookCard
