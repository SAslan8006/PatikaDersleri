import React from 'react'
import { View, Text } from 'react-native'
import Modal from "react-native-modal";
import styles from "./CategoryModalContent.style"
import DropdownComponent from './DropdownComponent';
const CategoryModalContent = ({ isVisible, onClose, category, handleStartGame }) => {
    return (
        <Modal style={styles.modal}
            isVisible={isVisible}
            swipeDirection="down"
            onSwipeComplete={onClose}
            onBackdropPress={onClose}
            onBackButtonPress={onClose}
        >
            <View style={[styles.container, { backgroundColor: category.color }]}>
                <Text style={styles.header_title}>{category.name}</Text>
                <DropdownComponent category={category} handleStartGame={handleStartGame} />

            </View>
        </Modal>
    )
}

export default CategoryModalContent
