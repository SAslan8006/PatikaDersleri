import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "white"
    },
    input_container: {
        flexDirection: "row"
    },
    input: {
        flex: 5,
        borderWidth: 1,
        margin: 10,
        paddingHorizontal: 10,
        borderRadius: 20,
        fontSize: 15
    },
    input_close: {
        flex: 1,
        fontSize: 20,
        paddingVertical: 20,
        color: "black",
    }
})