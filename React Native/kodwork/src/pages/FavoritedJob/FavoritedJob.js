import React from 'react'
import { FlatList, View } from 'react-native'
import { useDispatch, useSelector } from 'react-redux'
import DetailCardStyles from '../../components/DetailCard/DetailCard.styles'
import JobCard from '../../components/JobCard'
import styles from "./FavoritedJob.styles"

const FavoritedJob = () => {
    const favJob = useSelector(state => state.favJobList)

    const dispatch = useDispatch()

    const handleJobRemove = (id) => {
        dispatch({ type: "REMOVE_FAV_JOB", payload: { id } })
    }
    const renderJobs = ({ item }) => (<JobCard job={item} onRemove={() => handleJobRemove(item.id)} />)


    return (
        <View style={styles.container}>
            <FlatList
                keyExtractor={(item) => item.id}
                data={favJob}
                renderItem={renderJobs}
            />
        </View>
    )
}

export default FavoritedJob
