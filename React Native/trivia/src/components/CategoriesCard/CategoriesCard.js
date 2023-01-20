import React, { useState } from 'react'
import { Text, TouchableOpacity } from 'react-native'
import CategoryModalContent from '../Modal/CategoryModalContent'
import styles from "./CategoriesCard.styles"
const CategoriesCard = ({ item, handleStartGame }) => {
    const [selectModalContent, setSelectModalContent] = useState(false)
    const handleSelectToggle = () => {
        setSelectModalContent(!selectModalContent)
    }
    return (
        <>
            <TouchableOpacity
                style={[styles.container, { backgroundColor: item.color }]}
                onPress={handleSelectToggle}
            >
                <Text style={styles.title}>{item.name}</Text>
            </TouchableOpacity>
            <CategoryModalContent
                isVisible={selectModalContent}
                onClose={handleSelectToggle}
                category={item}
                handleStartGame={handleStartGame}

            />
        </>
    )
}

export default CategoriesCard
