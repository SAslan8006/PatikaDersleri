import React, { useEffect } from 'react'
import database from "@react-native-firebase/database"
import { View, Image, Text } from 'react-native'
import parseContentData from '../../utils/parseContentData'
import styles from "./CommentList.style"
const CommentList = ({ book, readingCommentBook, setReadingCommentBook, readCommentBook, setReadCommentBook, willreadCommentBook, setWillReadCommentBook }) => {

  useEffect(() => {
    if (book.book.isReading) {
      database().ref(`users/${book.book.userid}/reading/${book.id}/book/comment`).on('value', snapshot => {
        const contentData = snapshot.val();
        const parsedData = parseContentData(contentData || {})
        setReadingCommentBook(parsedData)

      })
    }
    if (book.book.isRead) {
      database().ref(`users/${book.book.userid}/read/${book.id}/book/comment`).on('value', snapshot => {
        const contentData = snapshot.val();
        const parsedData = parseContentData(contentData || {})
        setReadCommentBook(parsedData)

      })
    }
    if (book.book.isWillRead) {
      database().ref(`users/${book.book.userid}/willread/${book.id}/book/comment`).on('value', snapshot => {
        const contentData = snapshot.val();
        const parsedData = parseContentData(contentData || {})
        setWillReadCommentBook(parsedData)

      })
    }

  }, [])





  return (
    <>
      {
        book.book.isReading ?
          readingCommentBook.map(item => (
            <View style={styles.container} key={item.id}>
              <Image source={{ uri: item.comment.profileImage }} style={styles.image} />
              <View style={styles.right_container}>
                <View style={styles.user_container}>
                  <Text style={styles.fullName}>{item.comment.fullName}</Text>
                  <Text style={styles.userName}>@{item.comment.userName}</Text>
                </View>
                <View>
                  <Text style={styles.date}>{item.comment.date}</Text>
                  <Text style={styles.comment}>{item.comment.text}</Text>
                </View>
              </View>
            </View>

          ))
          :
          book.book.isRead ?
            readCommentBook.map(item => (
              <View style={styles.container} key={item.id}>
                <Image source={{ uri: item.comment.profileImage }} style={styles.image} />
                <View style={styles.right_container}>
                  <View style={styles.user_container}>
                    <Text style={styles.fullName}>{item.comment.fullName}</Text>
                    <Text style={styles.userName}>@{item.comment.userName}</Text>
                  </View>
                  <View>
                    <Text style={styles.date}>{item.comment.date}</Text>
                    <Text style={styles.comment}>{item.comment.text}</Text>
                  </View>
                </View>
              </View>

            ))
            :
            book.book.isWillRead ?
              willreadCommentBook.map(item => (
                <View style={styles.container} key={item.id}>
                  <Image source={{ uri: item.comment.profileImage }} style={styles.image} />
                  <View style={styles.right_container}>
                    <View style={styles.user_container}>
                      <Text style={styles.fullName}>{item.comment.fullName}</Text>
                      <Text style={styles.userName}>@{item.comment.userName}</Text>
                    </View>
                    <View>
                      <Text style={styles.date}>{item.comment.date}</Text>
                      <Text style={styles.comment}>{item.comment.text}</Text>
                    </View>
                  </View>
                </View>

              ))
              : null

      }
    </>
  )
}

export default CommentList
