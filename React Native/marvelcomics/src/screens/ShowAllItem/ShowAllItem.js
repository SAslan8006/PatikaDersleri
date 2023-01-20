import React from 'react'
import { View, Text, FlatList } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialIcons'
import ShowAllItemCard from '../../components/ShowAllItemCard'
import styles from "./ShowAllItem.style"
const ShowAllItem = ({ navigation, route }) => {
    const { data, name, title } = route.params
    const handleBack = () => {
        navigation.goBack()
    }
    const renderData = ({ item }) => <ShowAllItemCard data={item} />
    return (
        <View>
            <View style={styles.container_header}>
                <Icon name="arrow-back-ios" size={25} style={styles.icon} onPress={handleBack} />
                <Text style={styles.header}>{name}</Text>
            </View>
            <Text style={styles.sectionHeader}>{title}</Text>
            <FlatList
                data={data}
                renderItem={renderData}
            />
        </View>
    )
}

export default ShowAllItem
