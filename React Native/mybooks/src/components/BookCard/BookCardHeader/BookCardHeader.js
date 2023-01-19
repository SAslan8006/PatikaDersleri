import React from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import styles from "./BookCardHeader.style"
const BookCardHeader = ({ book }) => {

    return (
        <View style={styles.container}>
            {
                book.imageLinks ? <Image source={{ uri: book.imageLinks.thumbnail }} style={styles.image} />
                    :
                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
            }
            <View style={styles.info_title}>
                <Text style={styles.title}>{`${book.title.length > 25 ? book.title.slice(0, 28) + '...' : book.title} `}</Text>
                <Text style={styles.authors}>{`${book.authors.length > 2 ? book.authors.slice(0, 2) + '...' : book.authors}`}</Text>
            </View>

        </View>
    )
}

export default BookCardHeader
