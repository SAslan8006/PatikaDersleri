import React from 'react'
import { View, FlatList } from 'react-native'
import ComicsCard from '../../components/ComicsCard'
import Loading from '../../components/Loading'
import useFetch from '../../hooks/useFetch'
import styles from "./Comics.style"
const Comics = ({ url, handleComicsSelect }) => {

    const { data, loading } = useFetch(url)
    const renderData = ({ item }) => <ComicsCard comics={item} onSelect={() => handleComicsSelect(item.id)} />

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

export default Comics
