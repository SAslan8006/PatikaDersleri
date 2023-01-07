import React from 'react'
import { View, Text, SafeAreaView } from 'react-native'
import Modal from "react-native-modal"
import styles from "./InfoCard.style"
const InfoCard = ({ visibile, onClose, user }) => {
    return (
        <Modal
            style={styles.modal}
            isVisible={visibile}
            swipeDirection="down"
            onSwipeComplete={onClose}
            onBackdropPress={onClose}
            onBackButtonPress={onClose}
            backdropOpacity={0.2}
        >
            <View style={styles.container}>
                <Text style={styles.username}>{user.username}</Text>
                <Text style={styles.fullname}>{user.first_name} {user.last_name}</Text>


            </View>
        </Modal>

    )
}

export default InfoCard
