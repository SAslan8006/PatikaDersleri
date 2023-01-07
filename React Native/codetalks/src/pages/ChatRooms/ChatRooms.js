import React, { useEffect, useState, useContext } from 'react'
import { View, FlatList } from 'react-native'
import auth from "@react-native-firebase/auth"
import database from "@react-native-firebase/database"
import FloatingButton from '../../components/FloatingButton'
import ContentInputModal from '../../components/Modal/ContentInput'
import styles from "./ChatRooms.style"
import parseContentData from '../../utils/parseContentData'
import RoomCard from '../../components/RoomCard'
import { showMessage } from 'react-native-flash-message'
import { ChatRoomContext } from '../../context/ChatRoomContext'




const ChatRooms = ({ navigation }) => {
    const [inputModalVisible, setInputModalVisible] = useState(false)
    const [rooms, setRooms] = useState([])
    const { setRoomTitle } = useContext(ChatRoomContext)

    useEffect(() => {
        database().ref('rooms/').on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            setRooms(parsedData)
        })
    }, [])


    const handleInputToggle = () => {
        setInputModalVisible(!inputModalVisible)
    }
    const handleCreateRoom = (content) => {
        createRoom(content)
        setInputModalVisible(false)
    }
    const createRoom = (content) => {
        const userMail = auth().currentUser.email
        const newRoom = rooms.findIndex((room) => room.text.toLowerCase() === content.toLowerCase())
        if (newRoom > 0) {
            showMessage({
                message: "Bu oda daha önce oluşturuldu.",
                type: "danger"
            })
            return
        }
        try {
            const contentObject = {
                text: content,
                username: userMail.split('@')[0],
                date: new Date().toISOString(),
            }
            database().ref('rooms/').push(contentObject)
            handleRoomSelect(contentObject)
        } catch (error) {
            showMessage({
                message: error,
                type: "danger",
            });
        }



    }

    const handleRoomSelect = (room) => {
        navigation.navigate("ChatRoomDetail", { room })
        setRoomTitle(room.text)
    }

    const renderRooms = ({ item }) => <RoomCard roomName={item} onSelect={() => handleRoomSelect(item)} />

    return (
        <View style={styles.container}>
            <FlatList
                numColumns={2}
                data={rooms}
                renderItem={renderRooms}
            />
            <FloatingButton icon="plus" onPress={handleInputToggle} />
            <ContentInputModal
                visible={inputModalVisible}
                onClose={handleInputToggle}
                onSend={handleCreateRoom}
                placeholder="Oda ekle..."
                buttonText="Ekle"
            />
        </View>
    )
}

export default ChatRooms
