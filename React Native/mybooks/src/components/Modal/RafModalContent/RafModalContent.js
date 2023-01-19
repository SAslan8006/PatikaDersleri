import React, { useContext } from 'react'
import { View, Text, TouchableOpacity } from 'react-native'
import Modal from "react-native-modal";
import { BookContext } from '../../../context/BookContext'
import styles from "./RafModalContent.style"
const RafModalContent = ({ visible, onClose, onSelectRaf }) => {
    const { favoriBook, myLibraryBook, readBook, readingBook, willReadBook } = useContext(BookContext)

    return (
        <Modal style={styles.modal}
            isVisible={visible}
            swipeDirection="down"
            onSwipeComplete={onClose}
            onBackdropPress={onClose}
            onBackButtonPress={onClose}>
            <View style={styles.container}>
                <Text style={styles.header}>Raflar</Text>
                <TouchableOpacity style={styles.button} onPress={() => { onSelectRaf("Şu Anda Okudukları") }}>
                    <Text style={styles.button_title}>Şu Anda Okudukları</Text>
                    <Text style={styles.value}>{readingBook.length} kitap</Text>
                </TouchableOpacity>
                <TouchableOpacity style={styles.button} onPress={() => { onSelectRaf("Okudukları") }}>
                    <Text style={styles.button_title}>Okudukları</Text>
                    <Text style={styles.value}>{readBook.length} kitap</Text>
                </TouchableOpacity>
                <TouchableOpacity style={styles.button} onPress={() => { onSelectRaf("Okuyacakları") }}>
                    <Text style={styles.button_title}>Okuyacakları</Text>
                    <Text style={styles.value}>{willReadBook.length} kitap</Text>
                </TouchableOpacity>
                <TouchableOpacity style={styles.button} onPress={() => { onSelectRaf("Kütüphanesindekiler") }}>
                    <Text style={styles.button_title}>Kütüphanesindekiler</Text>
                    <Text style={styles.value}>{myLibraryBook.length} kitap</Text>
                </TouchableOpacity>
                <TouchableOpacity style={styles.button} onPress={() => { onSelectRaf("Beğendiği Kitaplar") }}>
                    <Text style={styles.button_title}>Beğendiği Kitaplar</Text>
                    <Text style={styles.value}>{favoriBook.length} kitap</Text>
                </TouchableOpacity>
            </View>

        </Modal>
    )
}

export default RafModalContent
