import React, { useContext } from 'react'
import { View, Text, TouchableOpacity } from 'react-native'
import auth from "@react-native-firebase/auth"
import { showMessage } from 'react-native-flash-message'
import Icon from 'react-native-vector-icons/MaterialCommunityIcons'
import Button from '../../../components/Button'
import styles from "./StartedGender.style"
import { UserInfoContext } from "../../../context/UserInfoContext";

const StartedInfo = ({ navigation }) => {
    const { userInfo, setUserInfo } = useContext(UserInfoContext)

    const handleNext = () => {
        if (userInfo.gender) {
            navigation.navigate("StartedLevel")
        } else {
            showMessage({
                message: "Cinsiyetinizi seçiniz",
                type: "danger",
            })
        }

    }

    const handleCreateUser = (gender) => {
        createUser(gender)
    }

    const createUser = (gender) => {
        const userMail = auth().currentUser.email

        try {
            const contentObject = {
                gender,
                username: userMail.split('@')[0],
                date: new Date().toISOString()
            }
            setUserInfo(contentObject)
        } catch (error) {
            showMessage({
                message: error,
                type: "danger",
            });
        }


    }

    return (
        <View style={styles.container}>
            <Text style={styles.title}>Cinsiyetin ne?</Text>
            <TouchableOpacity style={styles.gender_male} onPress={() => handleCreateUser("male")}>
                <Icon name="face-man-outline" size={170} testID="male" color="blue" />
            </TouchableOpacity>
            <TouchableOpacity style={styles.gender_female} onPress={() => handleCreateUser("female")} >
                <Icon name="face-woman-outline" size={170} color="red" />
            </TouchableOpacity>
            <View style={styles.button}>
                <Button iconName="arrow-right" onPress={handleNext} theme="started" iconTheme="arrow" />
            </View>
        </View>
    )
}

export default StartedInfo
