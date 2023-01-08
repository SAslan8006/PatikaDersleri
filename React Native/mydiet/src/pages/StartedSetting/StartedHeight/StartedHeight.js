import React, { useState, useContext } from 'react'
import { View, Text, TextInput } from 'react-native'
import Button from '../../../components/Button'
import { UserInfoContext } from '../../../context/UserInfoContext'
import { showMessage } from 'react-native-flash-message'
import styles from "./StartedHeight.style"
const StartedHeight = ({ navigation }) => {
    const [text, userText] = useState()
    const { userInfo, setUserInfo } = useContext(UserInfoContext)

    const handleNext = () => {
        if (text) {
            createUserHeight(text)

        } else {
            showMessage({
                message: "Boyunuzu giriniz",
                type: "danger",
            })
        }
    }

    const createUserHeight = (text) => {
        try {
            setUserInfo({ ...userInfo, height: text })
        } catch (error) {
            showMessage({
                message: error,
                type: "danger",
            });
        }

        navigation.navigate("StartedAge")
    }
    return (
        <View style={styles.container}>
            <Text style={styles.title}>Boyun kaç?</Text>
            <View style={styles.input_info}>
                <TextInput
                    placeholder="boyunu gir"
                    placeholderTextColor="white"
                    style={styles.input}
                    value={text}
                    onChangeText={userText}
                />
                <Text style={styles.cm_title}>cm</Text>
            </View>
            <View style={styles.button}>
                <Button iconName="arrow-right" onPress={handleNext} theme="started" iconTheme="arrow" />
            </View>
        </View>
    )
}

export default StartedHeight
