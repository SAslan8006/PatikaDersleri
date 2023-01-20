import React from 'react'
import { View, FlatList } from 'react-native'
import SeriesCard from '../../components/SeriesCard'
import Loading from '../../components/Loading'
import useFetch from '../../hooks/useFetch'
import styles from "./Series.style"
const Series = ({ url }) => {

    const { data, loading } = useFetch(url)
    const renderData = ({ item }) => <SeriesCard series={item} />

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

export default Series
