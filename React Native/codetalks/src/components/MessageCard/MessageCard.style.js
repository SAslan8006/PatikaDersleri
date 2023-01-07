import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        backgroundColor: "white",
        margin: 10,
        padding: 10,
        borderRadius: 10
    },
    otherContainer: {
        backgroundColor: "#ce93d8",
        margin: 10,
        padding: 10,
        borderRadius: 10
    },
    title_container: {
        flexDirection: "row",
        justifyContent: "space-between",
        marginBottom: 10,
    },
    username: {
        fontSize: 15,
        fontWeight: "bold"

    },
    date: {
        fontSize: 15,
        fontStyle: "italic",
    },
    message: {
        fontSize: 20,
        fontWeight: "bold",
        color: "black"
    },
})