import { Dimensions, StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        flex: 1,
        margin: 10
    },
    container_title: {
        color: "black",
        fontWeight: "bold",
        fontSize: 20,
        borderBottomWidth: 1,
        paddingVertical: 10,
        borderBottomColor: "#eeee"
    },
    container_info: {
        flexDirection: "row",
        paddingVertical: 5
    },
    info_title: {
        color: "black",
        fontWeight: "bold",
        fontSize: 15
    },
    info_value: {
        fontSize: 15
    },
    desc_container: {

    },
    description: {
        textAlign: "justify",
        fontSize: 15
    }
})