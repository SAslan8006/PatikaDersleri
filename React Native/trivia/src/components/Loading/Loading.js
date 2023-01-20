import React from 'react'
import { StyleSheet, Text, View } from 'react-native'

const Loading = () => {
    return (
        <View style={styles.container}>
            <Text style={styles.text}>LOADING...</Text>
        </View>
    )
}

export default Loading

const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: "center",
        alignItems: "center"
    },
    text: {
        fontSize: 32,
        fontWeight: "700"
    }
})