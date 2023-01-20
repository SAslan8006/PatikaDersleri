import React, { useContext } from 'react'
import { View, Text, FlatList } from 'react-native'
import MyListCard from '../../components/MyListCard'
import { CharactersContext } from '../../context/CharactersContext'
import styles from "./MyList.style"

const MyList = ({ search }) => {
    const { favoriList } = useContext(CharactersContext)

    const filteredList = favoriList.filter(item => `${item.name}`.toLowerCase().includes(search.toLowerCase()))
    const renderList = ({ item }) => <MyListCard character={item} />
    return (
        <View style={styles.container}>
            {
                favoriList.length > 0 ?
                    <>

                        <FlatList
                            ListHeaderComponent={<Text style={styles.title}>My Favorite List</Text>}
                            data={filteredList}
                            renderItem={renderList}
                            keyExtractor={item => item.id}
                        />
                    </>
                    :
                    <Text style={styles.emptyDesc}>Favorite List is Empty</Text>
            }

        </View>
    )
}

export default MyList
