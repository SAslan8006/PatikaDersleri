import React from 'react'
import { View, Text, useWindowDimensions, ScrollView, Alert } from 'react-native'

import RenderHTML from 'react-native-render-html'
import styles from "./DetailCard.styles"
import Button from "../Button"
import { useDispatch, useSelector } from 'react-redux'

const DetailCard = ({ detail }) => {
    const favJob = useSelector(state => state.favJobList)
    const subJob = useSelector(state => state.submitJobList)
    const dispatch = useDispatch()

    const handleAddFav = () => {
        if (favJob.find(item => item.id === detail.id)) {
            Alert.alert("Error", "Job has already added the favorities")
        } else {

            dispatch({ type: "ADD_FAV_JOB", payload: { detail } })
            Alert.alert("Successfuly", "Job is added the favorities")
        }

    }
    const handleAddSubmit = () => {
        if (subJob.find(item => item.id === detail.id)) {
            Alert.alert("Error", "Job has already added  Submit")
        } else {

            dispatch({ type: "ADD_SUBMIT_JOB", payload: { detail } })
            Alert.alert("Successfuly", "Job is added Submit")
        }
    }
    const { width } = useWindowDimensions();
    return (
        <ScrollView showsVerticalScrollIndicator={false}>
            <View style={styles.container}>
                <Text style={styles.name}>{detail.name.length > 25 ? detail.name.slice(0, 25) + "..." : detail.name}</Text>
                <View style={styles.location_info}>
                    <Text style={styles.location_title}>Locations: </Text><Text style={styles.location}> {detail.locations[0].name}</Text>
                </View>
                <View style={styles.level_info}>
                    <Text style={styles.level_title}>Job Level: </Text><Text style={styles.level}> {detail.levels[0].name}</Text>
                </View>
                <Text style={styles.detail_title}>Job Detail</Text>
            </View>
            <View style={styles.detail_body}>
                <RenderHTML source={{ html: detail.contents }} contentWidth={width} />
            </View>
            <View style={styles.detail_footer}>
                <Button text="Submit" onPress={handleAddSubmit} iconName="logout" />
                <Button text="Favorite Job" onPress={handleAddFav} iconName="heart" />
            </View>
        </ScrollView>
    )
}

export default DetailCard
