import React from "react"
import { TextInput, View } from 'react-native'
import styles from "./SearchBar.styles"

const SearchBar = ({ setText }) => {
    return (
        <View style={styles.container}>
            <TextInput
                placeholder="Ara..."
                style={styles.searchTitle}
                onChangeText={setText}
            />
        </View>
    )
}
export default SearchBar;