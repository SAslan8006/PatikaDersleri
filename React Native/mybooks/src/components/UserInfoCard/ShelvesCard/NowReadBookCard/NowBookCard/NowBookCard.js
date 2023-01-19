import React from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import Button from '../../../../Button'
import styles from "./NowBookCard.style"
const NowBookCard = ({ readingbook, handleBookToggle, bookModalVisible }) => {

    return (
        <View style={styles.container}>
            {
                readingbook?.book?.imageLinks ? <Image source={{ uri: readingbook?.book.imageLinks.thumbnail }} style={styles.image} />
                    :
                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
            }
            <View style={styles.info_title}>
                <Text style={styles.title}>{`${readingbook?.book.title.length > 25 ? readingbook?.book.title.slice(0, 28) + '...' : readingbook?.book.title} `}</Text>
                <Text style={styles.authors}>{`${readingbook?.book.authors.length > 2 ? readingbook?.book.authors.slice(0, 2) + '...' : readingbook?.book.authors}`}</Text>
                <Button text="Okuyorum" theme="wallread" onPress={handleBookToggle} />
            </View>
            {/*  <BookModalContent
                book={readbook.book}
                visible={bookModalVisible}
                onClose={handleBookToggle}
            onSelectCategory={handlelistWillRead}

            /> */}
        </View>
    )
}

export default NowBookCard
