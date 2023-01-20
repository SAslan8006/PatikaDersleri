import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container_header: {
        flexDirection: "row",
        backgroundColor: "black",
        paddingVertical: 5,
        paddingHorizontal: 10
    },
    icon: {
        flex: 1,
        color: "white"
    },
    header: {
        flex: 10,
        fontSize: 20,
        color: "white",
        textAlign: "center"

    },
    sectionHeader: {
        fontWeight: "bold",
        color: "red",
        fontSize: 20,
        paddingVertical: 5,
        paddingLeft: 10,

    },
})