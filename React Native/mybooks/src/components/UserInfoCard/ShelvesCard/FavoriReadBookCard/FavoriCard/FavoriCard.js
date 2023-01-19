import React from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import styles from "./FavoriCard.style"
const FavoriCard = ({ favoribook }) => {

    return (
        <View style={styles.container}>
            {
                favoribook?.book?.imageLinks ? <Image source={{ uri: favoribook?.book.imageLinks.thumbnail }} style={styles.image} />
                    :
                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
            }
            <View style={styles.info_title}>
                <Text style={styles.title}>{`${favoribook?.book.title.length > 25 ? favoribook?.book.title.slice(0, 28) + '...' : favoribook?.book.title} `}</Text>
                <Text style={styles.authors}>{`${favoribook?.book.authors.length > 2 ? favoribook?.book.authors.slice(0, 2) + '...' : favoribook?.book.authors}`}</Text>
            </View>

        </View>
    )
}

export default FavoriCard
