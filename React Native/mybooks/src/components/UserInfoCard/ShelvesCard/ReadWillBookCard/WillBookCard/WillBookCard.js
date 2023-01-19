import React from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import Button from '../../../../Button'
import styles from "./WillBookCard.style"
const WillBookCard = ({ willbook, handleBookToggle, bookModalVisible }) => {

    return (
        <View style={styles.container}>
            {
                willbook?.book?.imageLinks ? <Image source={{ uri: willbook?.book.imageLinks.thumbnail }} style={styles.image} />
                    :
                    <View style={styles.icon_image}><Icon name="book" size={40} /></View>
            }
            <View style={styles.info_title}>
                <Text style={styles.title}>{`${willbook?.book.title.length > 25 ? willbook?.book.title.slice(0, 28) + '...' : willbook?.book.title} `}</Text>
                <Text style={styles.authors}>{`${willbook?.book.authors.length > 2 ? willbook?.book.authors.slice(0, 2) + '...' : willbook?.book.authors}`}</Text>
                <Button text="Okuyacağım" theme="wallread" onPress={handleBookToggle} />
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

export default WillBookCard
