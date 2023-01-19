import { Dimensions, StyleSheet } from "react-native";
export default StyleSheet.create({
    container: {
        marginVertical: 10,
    },
    container_read: {
        flexDirection: "row"
    },
    read_title: {
        color: "black",
        fontWeight: "bold",
        fontSize: 17
    },
    read_count: {
        color: "red",
        fontWeight: "bold",
        fontSize: 17
    },
    container_image: {
        flexDirection: "row",
        flexWrap: "wrap",

    },
    image: {
        width: Dimensions.get("window").width / 4.9,
        height: 120,
        marginRight: 10,
        marginTop: 10,
        borderRadius: 5,

    },

    icon_image: {
        width: Dimensions.get("window").width / 4.9,
        height: 120,
        borderRadius: 5,
        marginRight: 10,
        marginTop: 10,
        backgroundColor: "#eeee",
        justifyContent: "center",
        alignItems: "center"
    },


})