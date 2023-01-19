import React, { useState, useContext } from 'react'
import { View } from 'react-native'
import database from '@react-native-firebase/database'
import { UserInfoContext } from '../../../context/UserInfoContext'
import { BookContext } from '../../../context/BookContext'
import Button from '../../Button'
import BookModalContent from '../../Modal/BookModalContent'

const SelectCategory = ({ book }) => {
    const [inputModalVisible, setInputModalVisible] = useState(false)
    const { userInfo } = useContext(UserInfoContext)

    const { favoriBook, myLibraryBook, readBook, readingBook, willReadBook, newReadBook, setNewReadBook, newReadingBook, setNewReadingBook, newWillReadBook, setNewWillReadBook } = useContext(BookContext)
    const handleInputToggle = () => {
        setInputModalVisible(!inputModalVisible)
    }

    const handlelistWillRead = (title) => {
        const [{ id, userName, fullName, profileImage }] = userInfo
        if (title == "willread") {
            const index = willReadBook.findIndex(item => item.book.title === book.title)
            const indexRead = readBook.findIndex(item => item.book.title === book.title)
            const indexReading = readingBook.findIndex(item => item.book.title === book.title)



            if (index < 0) {
                const newReference = database().ref(`users/${id}/willread`).push();
                newReference
                    .set({ book: { ...book, isFavori: false, favoriCount: 0, isWillRead: true, isReading: false, isRead: false, date: new Date().toISOString(), userName, fullName, profileImage, userid: id } })
                    .then(() => console.log('Data updated.'));

                if (indexRead > -1) {
                    const deleteReadBook = readBook.find(item => item.book.title === book.title)
                    database().ref(`users/${id}/read/${deleteReadBook.id}`).remove();
                }

                if (indexReading > -1) {
                    const deleteReadingBook = readingBook.find(item => item.book.title === book.title)
                    database().ref(`users/${id}/reading/${deleteReadingBook.id}`).remove();
                }


            } else {
                const deleteWillReadBook = willReadBook.find(item => item.book.title === book.title)
                database().ref(`users/${id}/willread/${deleteWillReadBook.id}`).remove();

            }





        }
        if (title == "read") {
            const index = readBook.findIndex(item => item.book.title === book.title)
            const indexWillRead = willReadBook.findIndex(item => item.book.title === book.title)
            const indexReading = readingBook.findIndex(item => item.book.title === book.title)

            if (index < 0) {
                const newReference = database().ref(`users/${id}/read`).push();
                newReference
                    .set({ book: { ...book, isFavori: false, favoriCount: 0, isRead: true, isReading: false, isWillRead: false, date: new Date().toISOString(), userName, fullName, profileImage, userid: id } })
                    .then(() => console.log('Data updated.'));
                if (indexWillRead > -1) {
                    const deleteWillReadBook = willReadBook.find(item => item.book.title === book.title)
                    database().ref(`users/${id}/willread/${deleteWillReadBook.id}`).remove();
                }
                if (indexReading > -1) {
                    const deleteReadingBook = readingBook.find(item => item.book.title === book.title)
                    database().ref(`users/${id}/reading/${deleteReadingBook.id}`).remove();
                }


            } else {
                const deleteReadBook = readBook.find(item => item.book.title === book.title)
                database().ref(`users/${id}/read/${deleteReadBook.id}`).remove();

            }

        }
        if (title == "reading") {

            const index = readingBook.findIndex(item => item.book.title === book.title)
            const indexRead = readBook.findIndex(item => item.book.title === book.title)
            const indexWillRead = willReadBook.findIndex(item => item.book.title === book.title)

            if (index < 0) {
                const newReference = database().ref(`users/${id}/reading`).push();
                newReference
                    .set({ book: { ...book, isFavori: false, favoriCount: 0, isReading: true, isRead: false, isWillRead: false, date: new Date().toISOString(), userName, fullName, profileImage, userid: id } })
                    .then(() => console.log('Data updated.'));

                if (indexWillRead > -1) {
                    const deleteWillReadBook = willReadBook.find(item => item.book.title === book.title)
                    database().ref(`users/${id}/willread/${deleteWillReadBook.id}`).remove();
                }
                if (indexRead > -1) {
                    const deleteReadBook = readBook.find(item => item.book.title === book.title)
                    database().ref(`users/${id}/read/${deleteReadBook.id}`).remove();
                }

            } else {
                const deleteReadingBook = readingBook.find(item => item.book.title === book.title)
                database().ref(`users/${id}/reading/${deleteReadingBook.id}`).remove();

            }


        }
        if (title == "favori") {

            const index = favoriBook.findIndex(item => item.book.title === book.title)

            if (index < 0) {
                const newReference = database().ref(`users/${id}/favori`).push();
                newReference
                    .set({ book: { ...book, isFavori: true, isReading: false, isRead: false, isWillRead: false, date: new Date().toISOString() } })
                    .then(() => console.log('Data updated.'));


            } else {
                const deleteFavori = favoriBook.find(item => item.book.title === book.title)
                database().ref(`users/${id}/favori/${deleteFavori.id}`).remove();

            }

        }
        if (title == "myLibrary") {
            const index = myLibraryBook.findIndex(item => item.book.title === book.title)
            if (index < 0) {
                const newReference = database().ref(`users/${id}/mylibrary`).push();
                newReference
                    .set({ book: { ...book, isMyLibrary: true } })
                    .then(() => console.log('Data updated.'));
            } else {
                const deleteMyLibraryBook = myLibraryBook.find(item => item.book.title === book.title)
                database().ref(`users/${id}/mylibrary/${deleteMyLibraryBook.id}`).remove();

            }

        }
    }


    return (
        <View>
            <Button text={newWillReadBook?.book?.isWillRead ? "Okuyacağım" : newReadBook?.book?.isRead ? "Okudum" : newReadingBook?.book?.isReading ? "Okuyorum" : "Okuyacaklarıma Ekle"} theme="addBook" onPress={handleInputToggle} />
            <BookModalContent
                book={book}
                visible={inputModalVisible}
                onClose={handleInputToggle}
                onSelectCategory={handlelistWillRead}

            />
        </View>
    )
}

export default SelectCategory
