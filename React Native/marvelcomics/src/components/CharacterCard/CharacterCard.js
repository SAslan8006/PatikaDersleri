import React from 'react'
import { View, Text, Image, TouchableOpacity } from 'react-native'
import styles from "./CharacterCard.style"

const CharacterCard = ({ character, onSelect }) => {

    return (
        <TouchableOpacity style={styles.container} onPress={onSelect}>

            <Image source={{ uri: character?.thumbnail?.path + '.' + character?.thumbnail?.extension }} style={styles.image} />
            <View style={styles.name_container}>
                <Text style={styles.name}>{character?.name?.length > 12 ? character.name.slice(0, 12) + "..." : character.name}</Text>
            </View>

        </TouchableOpacity>
    )
}

export default CharacterCard
