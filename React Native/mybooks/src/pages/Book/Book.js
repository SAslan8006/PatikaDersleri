import React from 'react'
import { ScrollView, TouchableOpacity } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialIcons'
import BookCardHeader from '../../components/BookCard/BookCardHeader'
import BookInfo from '../../components/BookCard/BookInfo'
import SelectCategory from '../../components/BookCard/SelectCategory'
import styles from "./Book.style"
const Book = ({ route, navigation }) => {
    const { book, page } = route.params

    const handleBack = () => {
        if (page) {
            navigation.navigate(page)
        }
        navigation.goBack()
    }
    return (
        <ScrollView style={styles.container}>
            <TouchableOpacity style={styles.arrow_back} onPress={handleBack}>
                <Icon name="keyboard-arrow-left" size={30} color="black" />
            </TouchableOpacity>
            <BookCardHeader book={book} />
            <SelectCategory book={book} />
            <BookInfo book={book} />
        </ScrollView>
    )
}

export default Book
