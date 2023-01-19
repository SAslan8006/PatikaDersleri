import React, { useContext, useState, useEffect } from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import Modal from "react-native-modal";
import Button from '../../Button';
import { BookContext } from '../../../context/BookContext'
import styles from "./BookModalContent.style"
const BookModalContent = ({ visible, onClose, onSend, book, onSelectCategory }) => {
    const { favoriBook, myLibraryBook, readBook, readingBook, willReadBook, newReadBook, setNewReadBook, newReadingBook, setNewReadingBook, newWillReadBook, setNewWillReadBook } = useContext(BookContext)
    const [newFavoriBook, setNewFavoriBook] = useState()
    const [newMyLibraryBook, setNewMyLibraryBook] = useState()

    useEffect(() => {
        const index = favoriBook.findIndex(item => item.book.title === book.title)
        if (index < 0) {
            setNewFavoriBook(book)

        } else {
            const newfavori = favoriBook.find(item => item.book.title === book.title)
            setNewFavoriBook(newfavori)

        }

    }, [favoriBook])

    useEffect(() => {
        const index = myLibraryBook.findIndex(item => item.book.title === book.title)
        if (index < 0) {
            setNewMyLibraryBook(book)

        } else {
            const newLibraryBook = myLibraryBook.find(item => item.book.title === book.title)
            setNewMyLibraryBook(newLibraryBook)

        }

    }, [myLibraryBook])

    useEffect(() => {
        const index = readBook.findIndex(item => item.book.title === book.title)
        if (index < 0) {
            setNewReadBook(book)

        } else {
            const newReadBook = readBook.find(item => item.book.title === book.title)
            setNewReadBook(newReadBook)

        }

    }, [readBook])

    useEffect(() => {
        const index = readingBook.findIndex(item => item.book.title === book.title)
        if (index < 0) {
            setNewReadingBook(book)

        } else {
            const newReadingBook = readingBook.find(item => item.book.title === book.title)
            setNewReadingBook(newReadingBook)

        }

    }, [readingBook])

    useEffect(() => {
        const index = willReadBook.findIndex(item => item.book.title === book.title)
        if (index < 0) {
            setNewWillReadBook(book)

        } else {
            const newReadingBook = willReadBook.find(item => item.book.title === book.title)
            setNewWillReadBook(newReadingBook)

        }

    }, [willReadBook])
    return (
        <Modal style={styles.modal}
            isVisible={visible}
            swipeDirection="down"
            onSwipeComplete={onClose}
            onBackdropPress={onClose}
            onBackButtonPress={onClose}>
            <View style={styles.container}>
                {
                    book.imageLinks ? <Image source={{ uri: book.imageLinks?.thumbnail }} style={styles.image} />
                        : <View style={styles.icon_image}><Icon name="book" size={40} /></View>
                }
                <Text style={styles.title}>{book.title}</Text>
                <View style={styles.button_container}>
                    <Button text="Okuyacağım" theme={newWillReadBook?.book?.isWillRead ? "seclectedCategory" : newReadBook?.book?.isRead ? "falseCategory" : newReadingBook?.book?.isReading ? "falseCategory" : "selectCategory"} onPress={() => onSelectCategory("willread")} />
                    <Button text="Okudum" theme={newReadBook?.book?.isRead ? "seclectedCategory" : newWillReadBook?.book?.isWillRead ? "falseCategory" : newReadingBook?.book?.isReading ? "falseCategory" : "selectCategory"} onPress={() => onSelectCategory("read")} />
                    <Button text="Okuyorum" theme={newReadingBook?.book?.isReading ? "seclectedCategory" : newWillReadBook?.book?.isWillRead ? "falseCategory" : newReadBook?.book?.isRead ? "falseCategory" : "selectCategory"} onPress={() => onSelectCategory("reading")} />
                </View>
                <View style={styles.favori_container} >
                    <Button text={newFavoriBook?.book?.isFavori ? "Beğendin" : "Beğen"} iconName={newFavoriBook?.book?.isFavori ? "cards-heart" : "cards-heart-outline"} theme="icon_button" onPress={() => onSelectCategory("favori")} />
                    <Button text="Kütüphanem" iconName={newMyLibraryBook?.book?.isMyLibrary ? "check-bold" : "plus"} theme="icon_button" onPress={() => onSelectCategory("myLibrary")} />
                </View>
            </View>

        </Modal>
    )
}

export default BookModalContent
