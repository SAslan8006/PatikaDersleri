import React from 'react'
import { View, Image, TextInput } from 'react-native'
import { formatDistance, parseISO } from 'date-fns'
import { tr } from "date-fns/locale"
import Button from '../Button'
import styles from "./CommentInput.style"
const CommentInput = ({ userInfo, handleShare, book, text, setText }) => {

    const [{ profileImage, userName, fullName, id }] = userInfo

    const formattedDate = formatDistance(parseISO(new Date().toISOString()), new Date(), {
        addSuffix: true,
        locale: tr,
    })

    const commentItem = {
        text,
        userName,
        fullName,
        profileImage,
        userid: id,
        date: formattedDate
    }



    return (
        <View style={styles.input_container}>
            <View style={styles.top_container}>
                <Image source={{ uri: profileImage }} style={styles.input_image} />
                <TextInput
                    autoCapitalize="none"
                    style={styles.input}
                    placeholder="Bir yorum yazın..."
                    value={text}
                    onChangeText={setText}
                />
            </View>
            {
                text !== "" ?
                    <View style={styles.bottom_container}>
                        <Button text="Paylaş" theme="send_button" onPress={() => handleShare(book, commentItem)} />
                    </View>
                    : null
            }
        </View>
    )
}

export default CommentInput
