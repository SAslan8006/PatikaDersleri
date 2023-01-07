import React from 'react'
import { View, Text, FlatList } from 'react-native'
import Config from 'react-native-config'
import Error from '../../components/Error'
import Loading from '../../components/Loading'
import useFetch from '../../hooks/useFetch'
import DetailCard from '../../components/DetailCard'

const JobDetail = ({ route }) => {
    const { id } = route.params
    const { loading, error, data } = useFetch(`${Config.API_JOBS_URL}/${id}`)

    if (loading) {
        return <Loading />
    }
    if (error) {
        return <Error />
    }


    return (
        <View>
            <DetailCard detail={data} />

        </View>
    )
}

export default JobDetail
