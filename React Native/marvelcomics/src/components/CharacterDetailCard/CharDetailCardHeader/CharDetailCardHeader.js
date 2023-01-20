import React, { useContext, useState, useEffect } from 'react'
import { View, Text, Image } from 'react-native'
import Icon from 'react-native-vector-icons/FontAwesome'
import styles from "./CharDetailCardHeader.style"
import { CharactersContext } from "../../../context/CharactersContext"
const CharDetailCardHeader = ({ item }) => {
    const [favori, setFavori] = useState(false)
    const { addFavorite, removeFavorite, favoriList } = useContext(CharactersContext)
    console.log(favori
    )
    useEffect(() => {
        const character = favoriList.find(char => char.id === item.id)
        if (character) {
            setFavori(true)
        } else {
            setFavori(false)
        }
    }, [favoriList])
    return (
        <View style={styles.character_container}>
            <Image style={styles.character_image} source={{ uri: item?.thumbnail?.path + "." + item?.thumbnail?.extension }} />
            <View style={styles.character_info}>

                <Text style={styles.name}>{item?.name}</Text>

                <Text style={styles.description}>{item?.description}</Text>
                <View style={styles.favori_container}>
                    {
                        favori ?
                            <Icon name="heart" size={25} style={styles.favori_icon} onPress={() => removeFavorite(item)} />
                            :
                            <Icon name="heart-o" size={25} style={styles.icon} onPress={() => addFavorite(item)} />
                    }
                </View>
            </View>

        </View>
    )
}

export default CharDetailCardHeader
