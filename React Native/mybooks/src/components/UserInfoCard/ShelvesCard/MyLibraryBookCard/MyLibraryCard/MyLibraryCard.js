import React from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import styles from "./MyLibraryCard.style"
const MyLibraryCard = ({ mylibrarybook }) => {

    return (
        <View style={styles.container}>
            {
                mylibrarybook?.book?.imageLinks ? <Image source={{ uri: mylibrarybook?.book.imageLinks.thumbnail }} style={styles.image} />
                    :
                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
            }
            <View style={styles.info_title}>
                <Text style={styles.title}>{`${mylibrarybook?.book.title.length > 25 ? mylibrarybook?.book.title.slice(0, 28) + '...' : mylibrarybook?.book.title} `}</Text>
                <Text style={styles.authors}>{`${mylibrarybook?.book.authors.length > 2 ? mylibrarybook?.book.authors.slice(0, 2) + '...' : mylibrarybook?.book.authors}`}</Text>
            </View>

        </View>
    )
}

export default MyLibraryCard
