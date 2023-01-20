import React,{useState,useEffect} from 'react'
import { View, Text, Image } from 'react-native'
import database from "@react-native-firebase/database"
import Icon from 'react-native-vector-icons/MaterialIcons'
import BestScoreList from '../../components/BestScoreList'
import Button from '../../components/Button/Button'
import { signOut } from '../../utils/auth'
import ParseContentData from '../../utils/ParseContentData'
import styles from "./Home.style"
const Home = ({ navigation }) => {
 const [contentList, setContentList] = useState([])

   useEffect(() => {
        database().ref('gamers/')
            .on('value', snapshot => {
                const contentData = snapshot.val();
                const parsedData = ParseContentData(contentData || {})
                setContentList(parsedData)
            })
    }, [])

    return (
        <View style={styles.container}>
            <View style={styles.container_header}>
                <Icon name="settings" size={30} color="white" style={styles.settings_icon} />
                <Icon name="logout" size={30} color="white" onPress={signOut} style={styles.signout_icon} />
            </View>
            <Image resizeMode="contain" source={require("../../assets/trivia.png")} style={styles.image} />
            <BestScoreList  contentList={contentList}/>
            <Button labelText="Game Start" theme="primary" onPress={() => navigation.navigate("CategoriesScreen")} />

        </View>
    )
}

export default Home
