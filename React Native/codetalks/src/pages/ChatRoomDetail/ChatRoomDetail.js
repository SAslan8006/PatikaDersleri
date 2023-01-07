import React, { useState, useEffect } from 'react'
import { View, Text, FlatList } from 'react-native'
import auth from "@react-native-firebase/auth"
import database from "@react-native-firebase/database"
import FloatingButton from '../../components/FloatingButton'
import MessageCard from '../../components/MessageCard'
import ContentInputModal from '../../components/Modal/ContentInput'
import styles from "./ChatRoomDetail.style"
import parseContentData from '../../utils/parseContentData'


const ChatRoomDetail = ({ route }) => {
    const [inputModalVisible, setInputModalVisible] = useState(false)
    const [contentList, setContentList] = useState([]);
    const { room } = route.params


    useEffect(() => {
        database().ref(`rooms/${room.id}/${room.text}`).on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setContentList(parsedData)

        })
    }, [])

    const handleInputToggle = () => {
        setInputModalVisible(!inputModalVisible)

    }
    const handleCreateMessage = (message) => {
        createMessage(message)
        setInputModalVisible(false)
    }
    const createMessage = (message) => {
        const userMail = auth().currentUser.email
        const contentObject = {
            text: message,
            username: userMail.split('@')[0],
            date: new Date().toISOString(),
        }
        database().ref(`rooms/${room.id}/${room.text}`).push(contentObject)

    }
    const renderMessages = ({ item }) => <MessageCard message={item} />
    return (
        <View style={styles.container}>

            <FlatList
                ListHeaderComponent={() => (
                    <Text style={styles.room_title}>{`${room.text} odası kuruldu!`}</Text>
                )}
                data={contentList}
                renderItem={renderMessages}
            />
            <FloatingButton icon="plus" onPress={handleInputToggle} />
            <ContentInputModal
                visible={inputModalVisible}
                onClose={handleInputToggle}
                placeholder="Mesajın..."
                buttonText="Gönder"
                onSend={handleCreateMessage}
            />
        </View>
    )
}

export default ChatRoomDetail
