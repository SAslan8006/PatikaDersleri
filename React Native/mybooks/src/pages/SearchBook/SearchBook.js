import React, { useState, useEffect } from 'react'
import { View, Text, TextInput, FlatList } from 'react-native'
import axios from "axios"
import SearchBookCard from '../../components/HomeCard/SearchBookCard'
import styles from "./SearchBook.style"
const SearchBook = ({ navigation }) => {
    const [loading, setLoading] = useState(true)
    const [text, setText] = useState("")
    const [searchBook, setSearchBook] = useState([])

    const handleSelectedBook = (book) => {
        navigation.navigate("SelectedBookPage", { book })
    }
    const handleBack = () => {
        navigation.goBack()
    }
 
    const fetch = async () => {
        try {
            await axios.get(`https://www.googleapis.com/books/v1/volumes?q=${text}&key=AIzaSyB5pmLZMauoUp5FBABaBYyerzG8o_YufB8&maxResults=15`)
                .then((response) => {
                    setSearchBook(response.data.items)
                    setLoading(false)
                    //return response.data;
                })

        } catch (error) {
            if (error.response) {

                console.log(error.response)

            } else if (error.request) {

                console.log(error.request)

            } else if (error.message) {

                console.log(error.message)
            }
        }
    }
    useEffect(() => {
        fetch()

    }, [text])
    const renderSearch = ({ item }) => <SearchBookCard book={item} handleSelectedBook={() => handleSelectedBook(item.volumeInfo)} />
    return (
        <View style={styles.container}>
            <View style={styles.input_container}>
                <TextInput
                    style={styles.input}
                    placeholder="MyBooks'ta Ara"
                    value={text}
                    onChangeText={setText}
                />
                <Text style={styles.input_close} onPress={handleBack}>İptal</Text>
            </View>
            {
                text ? <FlatList
                    data={searchBook}
                    renderItem={renderSearch}
                />
                    :
                    <Text style={{ color: "black", textAlign: "center", fontSize: 16 }}>Yakınlarda aramanız yok</Text>
            }


        </View>
    )
}

export default SearchBook
