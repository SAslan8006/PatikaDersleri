import React from 'react'
import { View, Text } from 'react-native'
import Button from '../../../components/Button'
import styles from "./StartedInfo.style"
const StartedInfo = ({ navigation }) => {
    const handleNext = () => {
        navigation.navigate("StartedGender")
    }
    return (
        <View style={styles.container}>
            <View style={styles.container_title}>
                <Text style={styles.title}>Profilinizi Ayarlama</Text>
            </View>

            <View style={styles.container_info}>
                <Text style={styles.info}>
                    Başlangıçta TGD'nizi veya diğer adıyla tavsiye edilen günlük değerinizi hesaplayacağız. Bu, ideal olarak her gün ne kadar besin tüketmeniz gerektiğini ifade etmektedir. Bu, aktivite seviyenizden,yaşınızdan, boyunuzdan ve size özgü diğer özelliklerden etkilenir.
                </Text>
            </View>
            <View style={styles.button}>
                <Button iconName="arrow-right" text={false} onPress={handleNext} theme="started" iconTheme="arrow" />
            </View>

        </View>

    )
}

export default StartedInfo
