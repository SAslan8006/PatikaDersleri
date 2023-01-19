import React from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import Button from '../../../../Button'
import styles from "./ReadCard.style"
const ReadCard = ({ readbook, handleBookToggle }) => {

    return (
        <View style={styles.container}>
            {
                readbook?.book?.imageLinks ? <Image source={{ uri: readbook?.book.imageLinks.thumbnail }} style={styles.image} />
                    :
                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
            }
            <View style={styles.info_title}>
                <Text style={styles.title}>{`${readbook?.book.title.length > 25 ? readbook?.book.title.slice(0, 28) + '...' : readbook?.book.title} `}</Text>
                <Text style={styles.authors}>{`${readbook?.book.authors.length > 2 ? readbook?.book.authors.slice(0, 2) + '...' : readbook?.book.authors}`}</Text>
                <Button text="Okudum" theme="wallread" onPress={handleBookToggle} />
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

export default ReadCard
