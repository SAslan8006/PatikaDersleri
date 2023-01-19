import React from 'react'
import { ScrollView } from 'react-native'
import HomeHeader from '../../components/HomeCard/HomeHeader'
import styles from "./Home.style"
import TotalWall from '../../components/HomeCard/TotalWall'


const Home = ({ navigation }) => {

    const searchbook = () => {
        navigation.navigate("SearchBookPage")
    }
    const handlesendComment = (book) => {

        navigation.navigate("SendCommentPage", { book })
    }
    return (
        <ScrollView style={styles.container}>
            <HomeHeader onPress={searchbook} />
            <TotalWall handlesendComment={handlesendComment} />
        </ScrollView>
    )
}

export default Home
