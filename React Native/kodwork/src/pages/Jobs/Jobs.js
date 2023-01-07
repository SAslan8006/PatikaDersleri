import React, { useEffect, useState } from 'react'
import { View, FlatList, Text } from 'react-native'
import Config from 'react-native-config'
import useFetch from '../../hooks/useFetch'
import Loading from "../../components/Loading"
import Error from "../../components/Error"
import JobCard from "../../components/JobCard"
import styles from "./Jobs.styles"
import Button from "../../components/Button"

const Jobs = ({ navigation }) => {
    const [page, setPage] = useState(1)
    const { data, error, loading } = useFetch(`${Config.API_JOBS_URL}?page=${page}`)

    const handleJobSelect = (id) => {
        navigation.navigate("JobDetailPage", { id })
    }
    const renderJobs = ({ item }) => (<JobCard job={item} onSelect={() => handleJobSelect(item.id)} />)

    const Footer = () => {
        const increasePage = () => {
            return setPage(page + 1);
        };
        const decreasePage = () => {
            return page === 1 ? setPage(1) : setPage(page - 1);
        };
        return (
            <View style={styles.footer_container}>
                <Button text="Previos" onPress={decreasePage} />
                <Text style={styles.footer_page}>{page} / 99</Text>
                <Button text="Next" onPress={increasePage} />
            </View>)
    }


    if (loading) {
        return <Loading />
    }
    if (error) {
        return <Error />
    }
    return (
        <View style={styles.container}>
            <FlatList
                keyExtractor={(item) => item.id}
                data={data.results}
                renderItem={renderJobs}
                ListFooterComponent={<Footer />}
            />


        </View>
    )
}

export default Jobs
