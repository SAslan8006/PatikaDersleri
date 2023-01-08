import React from "react"
import { View, ActivityIndicator } from 'react-native'
import styles from "./Loading.style"
const Loading = () => {
    return (
        <View style={styles.container}>
        <ActivityIndicator color="blue" />
    </View>
    )
}
export default Loading;
