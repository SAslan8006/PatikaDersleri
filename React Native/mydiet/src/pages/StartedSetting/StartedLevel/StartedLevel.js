import React, { useContext } from 'react'
import { View, Text, TouchableOpacity } from 'react-native'
import { showMessage } from 'react-native-flash-message'
import Button from '../../../components/Button'
import styles from "./StartedLevel.style"
import { UserInfoContext } from "../../../context/UserInfoContext";
const level = {
    noAktif: 1.2,
    lessAktif: 1.375,
    aktif: 1.55,
    moreAktif: 1.725
}

const StartedLevel = ({ navigation, route }) => {

    const { userInfo, setUserInfo } = useContext(UserInfoContext)

    const handleNext = () => {
        if (userInfo.level) {
            navigation.navigate("StartedWeight")
        } else {
            showMessage({
                message: "Aktivite durumunuzu seçiniz",
                type: "danger",
            })
        }

    }
    const handleCreateLevel = (level) => {
        createUserLevel(level)
    }

    const createUserLevel = (level) => {
        try {
            const newContent = level
            setUserInfo({ ...userInfo, level: newContent })
        } catch (error) {
            showMessage({
                message: error,
                type: "danger",
            });
        }


    }

    return (
        <View style={styles.container}>
            <Text style={styles.title}>Etkinlik Düzeyin ne?</Text>
            <TouchableOpacity style={styles.container_title} onPress={() => handleCreateLevel(level.noAktif)}>
                <Text style={styles.title}>Aktivite Yok</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.container_title} onPress={() => handleCreateLevel(level.lessAktif)}>
                <Text style={styles.title}>Az Aktif</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.container_title} onPress={() => handleCreateLevel(level.aktif)}>
                <Text style={styles.title}>Aktif</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.container_title} onPress={() => handleCreateLevel(level.moreAktif)}>
                <Text style={styles.title}>Çok Aktif</Text>
            </TouchableOpacity>
            <View style={styles.button}>
                <Button iconName="arrow-right" onPress={handleNext} theme="started" iconTheme="arrow" />
            </View>
        </View>
    )
}

export default StartedLevel
