import React from 'react'
import { View, FlatList } from 'react-native'
import StoriesCard from '../../components/StoriesCard'
import Loading from '../../components/Loading'
import useFetch from '../../hooks/useFetch'
import styles from "./Stories.style"
const Stories = ({ url }) => {

    const { data, loading } = useFetch(url)
    const renderData = ({ item }) => <StoriesCard stories={item} />

    if (loading) {
        return <Loading />;
    }

    return (
        <View style={styles.container}>
            <FlatList
                data={data}
                renderItem={renderData}
                keyExtractor={item => item.id}
                numColumns={2}
            />

        </View>
    )
}

export default Stories
