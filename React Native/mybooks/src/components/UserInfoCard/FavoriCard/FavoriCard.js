import React, { useEffect, useContext } from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import database from "@react-native-firebase/database"
import Icon from 'react-native-vector-icons/FontAwesome'
import parseContentData from '../../../utils/parseContentData'
import styles from "./FavoriCard.style"
import { BookContext } from '../../../context/BookContext'
const FavoriCard = ({ userInfo, handleSelectedBook }) => {
    const { favoriBook, setFavoriBook } = useContext(BookContext)
    useEffect(() => {
        const [{ id }] = userInfo
        database().ref(`users/${id}/favori`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setFavoriBook(parsedData)
            //console.log(parsedData)

        })
    }, [])

    return (
        <View style={styles.container}>
            <View style={styles.container_read}>
                <Text style={styles.read_title}>Beğendiği kitaplar </Text>
                <Text style={styles.read_count}>{favoriBook.length} kitap</Text>
            </View>
            <View style={styles.container_image}>
                {
                    favoriBook.length < 10 ?
                        favoriBook.map(item => (
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
                        favoriBook.slice(0, 10).map(item => (
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

export default FavoriCard
