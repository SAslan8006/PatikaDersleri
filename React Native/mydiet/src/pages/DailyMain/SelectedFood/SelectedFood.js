import React, { useState } from 'react'
import { View, Text, TextInput, FlatList } from 'react-native'
import { format } from 'date-fns'
import { tr } from 'date-fns/locale'
import styles from "./SelectedFood.style"
import Config from 'react-native-config'
import axios from 'axios'
import Error from '../../../components/Error'
import Loading from '../../../components/Loading'
import Icon from 'react-native-vector-icons/MaterialCommunityIcons'
import SearchFoodCard from '../../../components/DailyCard/SearchFoodCard'
const SelectedFood = ({ navigation, route }) => {
    const [data, setData] = useState([]);
    const [loading, setLoading] = useState(true)
    const [error, setError] = useState(null)
    const [search, setSearch] = useState('')



    const { name } = route.params

    const formattedDate = format(new Date(), "eeee d", { locale: tr })

    const handleClose = () => {
        setSearch("")
        setData([])
    }

    const handleBackPage = () => {
        navigation.goBack()
    }
    const fetch = async () => {

        try {

            await axios.get(`${Config.API_URL}?query=${search}&common=true&detailed=true`, {
                headers: {
                    'x-app-id': "909e2c13",
                    'x-app-key': "70e91eacda15bf8d786b2908b46bd087",
                    'x-remote-user-id': "0"
                }
            }).then((response) => {
                setData(response.data)
                setLoading(false)
                return response.data;
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


    const handleNext = (food) => {
        navigation.navigate("FoodInfoPage", { food, name })
    }

    const renderFood = ({ item }) => <SearchFoodCard food={item} onPress={() => handleNext(item)} />

    return (
        <View style={styles.container}>
            <View style={styles.header}>
                <View style={styles.header_left}>
                    <Text style={styles.name}>{name}</Text>
                    <Text style={styles.date}>{formattedDate}</Text>
                </View>

                <View style={styles.close_container}>
                    {

                    }
                    <Text onPress={handleBackPage} style={styles.close}>Geri</Text>
                </View>
            </View>
            <View>
                <TextInput style={styles.input}
                    placeholder="yemek ara..."
                    value={search}
                    onChangeText={setSearch}
                    onSubmitEditing={fetch}
                />
                {search && <Icon name="close" size={30} style={styles.close_icon} onPress={handleClose} />}
            </View>
            <View>
                {
                    loading && <Loading />
                }
                {
                    <FlatList
                        data={data.branded}
                        renderItem={renderFood}
                    />
                }

            </View>
        </View>
    )
}

export default SelectedFood
