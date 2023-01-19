import React, { useState, useContext } from 'react'
import { View } from 'react-native'
import FavoriCard from '../../../components/UserInfoCard/FavoriCard'
import MyLibraryCard from '../../../components/UserInfoCard/MyLibraryCard/MyLibraryCard'
import ReadBookCard from '../../../components/UserInfoCard/ReadBookCard'
import WillReadBookCard from '../../../components/UserInfoCard/WillReadBookCard'
import RafModalContent from '../../../components/Modal/RafModalContent'
import Button from '../../../components/Button'
import styles from "./MyLibrary.style"
import NowReadBookCard from '../../../components/UserInfoCard/ShelvesCard/NowReadBookCard'
import ReadWillBookCard from '../../../components/UserInfoCard/ShelvesCard/ReadWillBookCard'
import BookReadCard from '../../../components/UserInfoCard/ShelvesCard/BookReadCard'
import MyLibraryBookCard from '../../../components/UserInfoCard/ShelvesCard/MyLibraryBookCard'
import FavoriReadBookCard from '../../../components/UserInfoCard/ShelvesCard/FavoriReadBookCard'
import { BookContext } from '../../../context/BookContext'
const MyLibrary = ({ userInfo, handleSelectedBook }) => {
    const [inputModalVisible, setInputModalVisible] = useState(false)
    const [bookModalVisible, setBookModalVisible] = useState(false)
    const [book, setBook] = useState()
    const { favoriBook, myLibraryBook, readBook, readingBook, willReadBook } = useContext(BookContext)

    const [selectedRaf, setSelectedRaf] = useState("Raflar")
    const handleInputToggle = () => {
        setInputModalVisible(!inputModalVisible)

    }
    const handlelistRaf = (item) => {
        setSelectedRaf(item)
        setInputModalVisible(false)
    }

    const selectTotalInfo = () => {
        setSelectedRaf("Raflar")
    }

    const handleBookToggle = () => {
        setBookModalVisible(!bookModalVisible)
    }


    return (
        <>
            <View style={styles.container}>
                <View style={styles.container_button}>
                    <Button text="Genel Bakış" theme={selectedRaf == "Raflar" ? "darkbookInfo" : "bookInfo"} onPress={selectTotalInfo} />
                    <Button text={selectedRaf} theme={selectedRaf == "Raflar" ? "bookRaf" : "darkbookRaf"} onPress={handleInputToggle} />
                </View>
                {
                    selectedRaf == "Şu Anda Okudukları" ? <NowReadBookCard handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} /> :
                        selectedRaf == "Okudukları" ? <BookReadCard handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} /> :
                            selectedRaf == "Okuyacakları" ? <ReadWillBookCard handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} /> :
                                selectedRaf == "Kütüphanesindekiler" ? <MyLibraryBookCard handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} /> :
                                    selectedRaf == "Beğendiği Kitaplar" ? <FavoriReadBookCard handleBookToggle={handleBookToggle} bookModalVisible={bookModalVisible} /> :

                                        (
                                            <>
                                                <ReadBookCard userInfo={userInfo} handleSelectedBook={handleSelectedBook} />
                                                <WillReadBookCard userInfo={userInfo} handleSelectedBook={handleSelectedBook} />
                                                <MyLibraryCard userInfo={userInfo} handleSelectedBook={handleSelectedBook} />
                                                <FavoriCard userInfo={userInfo} handleSelectedBook={handleSelectedBook} />
                                            </>
                                        )
                }

            </View>
            <RafModalContent
                visible={inputModalVisible}
                onClose={handleInputToggle}
                onSelectRaf={handlelistRaf}
            />
        </>
    )
}

export default MyLibrary
