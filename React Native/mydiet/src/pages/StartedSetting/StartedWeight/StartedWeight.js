import React, { useState, useContext } from 'react'
import { View, Text, TextInput } from 'react-native'
import Button from '../../../components/Button'
import { UserInfoContext } from '../../../context/UserInfoContext'
import { showMessage } from 'react-native-flash-message'
import styles from "./StartedWeight.style"
const StartedWeight = ({ navigation }) => {
    const [text, userText] = useState()
    const { userInfo, setUserInfo } = useContext(UserInfoContext)

    const handleNext = () => {
        if (text) {
            createUserWeight(text)
        } else {
            showMessage({
                message: "Kilonuzu giriniz",
                type: "danger",
            })
        }

    }

    const createUserWeight = (text) => {
        try {
            setUserInfo({ ...userInfo, weight: text })
        } catch (error) {
            showMessage({
                message: error,
                type: "danger",
            });
        }

        navigation.navigate("StartedHeight")
    }

    return (
        <View style={styles.container}>
            <Text style={styles.title}>Şu andaki kilon ne?</Text>
            <View style={styles.input_info}>
                <TextInput
                    placeholder="kilonuzu giriniz"
                    placeholderTextColor="white"
                    style={styles.input}
                    value={text}
                    onChangeText={userText}
                />
                <Text style={styles.kg_title}>kg</Text>
            </View>
            <View style={styles.button}>
                <Button iconName="arrow-right" onPress={handleNext} theme="started" iconTheme="arrow" />
            </View>
        </View>
    )
}

export default StartedWeight
