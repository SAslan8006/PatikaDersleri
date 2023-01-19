import React, { useContext } from 'react'
import { ScrollView } from 'react-native'
import styles from "./SendComment.style"

import UserWallCard from '../../components/UserWallCard'
import CommentList from '../../components/CommentList'
import { UserInfoContext } from '../../context/UserInfoContext'
import CommentInput from '../../components/CommentInput'
import { BookContext } from '../../context/BookContext'
const SendComment = ({ navigation, route }) => {
    const { userInfo } = useContext(UserInfoContext)
    const { handleShare, text, setText, handleFavoriCount, readingCommentBook, setReadingCommentBook, readCommentBook, setReadCommentBook, willreadCommentBook, setWillReadCommentBook } = useContext(BookContext)
    const { book } = route.params

    const handlesendComment = (book) => {
        navigation.navigate("SendCommentPage", { book })
    }


    return (
        <>
            <ScrollView style={styles.container}>
                <UserWallCard wall={book} handleFavoriCount={handleFavoriCount} handlesendComment={handlesendComment} />
                <CommentList book={book} readingCommentBook={readingCommentBook} setReadingCommentBook={setReadingCommentBook} readCommentBook={readCommentBook} setReadCommentBook={setReadCommentBook} willreadCommentBook={willreadCommentBook} setWillReadCommentBook={setWillReadCommentBook} />
            </ScrollView>
            <CommentInput userInfo={userInfo} handleShare={handleShare} book={book} text={text} setText={setText} />
        </>
    )
}

export default SendComment
