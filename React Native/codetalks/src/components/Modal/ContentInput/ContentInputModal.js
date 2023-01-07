import React, { useState } from 'react'
import { TextInput, View } from 'react-native'
import Modal from 'react-native-modal'
import styles from "./ContentInputModal.style"
import Button from "../../Button"

const ContentInputModal = ({ visible, onClose, onSend, placeholder, buttonText }) => {
    const [text, setText] = useState(null)

    const handleSend = () => {
        if (!text) {
            return
        } else {
            onSend(text)
            setText(null)
        }

    }

    return (
        <Modal style={styles.modal}
            isVisible={visible}
            swipeDirection="down"
            onSwipeComplete={onClose}
            onBackdropPress={onClose}
            onBackButtonPress={onClose}

        >
            <View style={styles.container}>
                <View style={styles.input_container}>
                    <TextInput placeholder={placeholder} value={text} onChangeText={setText} multiline />
                </View>
                <Button text={buttonText} onPress={handleSend} theme="primary" />
            </View>
        </Modal>
    )
}

export default ContentInputModal
