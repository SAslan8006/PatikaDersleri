import React, { useContext } from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import { CharactersContext } from '../../context/CharactersContext'
import styles from "./MyListCard.style"
const MyListCard = ({ character }) => {
    const { removeFavorite } = useContext(CharactersContext)
    return (

        <View style={styles.container}>
            <Image style={styles.image}
                source={{
                    uri: character?.thumbnail !== null ?
                        `${character?.thumbnail?.path}.${character?.thumbnail?.extension}`
                        :
                        "https://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available.jpg"
                }}

            />
            <View style={styles.container_right}>
                <Text style={styles.title}>{character.title ? character.title : character.name}</Text>
                <Icon name="heart" size={25} style={styles.favori_icon} onPress={() => removeFavorite(character)} />
            </View>


        </View>

    )
}

export default MyListCard
