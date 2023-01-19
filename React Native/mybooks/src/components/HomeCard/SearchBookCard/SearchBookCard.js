import React from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import styles from "./SearchBook.style"
const SearchBookCard = ({ book, handleSelectedBook }) => {

    return (
        <TouchableOpacity style={styles.container} onPress={handleSelectedBook}>
            {
                book.volumeInfo?.imageLinks ? <Image style={styles.image} source={{ uri: book.volumeInfo.imageLinks.thumbnail }} />
                    :
                    <Icon name="book" size={30} style={styles.icon_image} />
            }

            <View style={styles.info}>
                <Text style={styles.title}>{book.volumeInfo?.title}</Text>
                <Text style={styles.author}>{book.volumeInfo?.authors}</Text>
            </View>

        </TouchableOpacity>
    )
}

export default SearchBookCard
