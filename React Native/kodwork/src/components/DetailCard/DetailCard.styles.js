import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        paddingHorizontal: 5
    },
    name: {
        fontWeight: "bold",
        fontSize: 25,
        color: "#667278",
        paddingVertical: 5

    },
    location_info: {
        flexDirection: "row",
        paddingVertical: 5,

    },
    level_info: {
        flexDirection: "row",
        paddingVertical: 5
    },
    location_title: {
        color: "#EF5350",
        fontWeight: "bold",
        fontSize: 17,
    },
    level_title: {
        color: "#EF5350",
        fontWeight: "bold",
        fontSize: 17,
    },
    location: {
        color: "black",
        fontWeight: "bold",
        fontSize: 17
    },
    level: {
        color: "black",
        fontWeight: "bold",
        fontSize: 17
    },
    detail_title: {
        color: "#667278",
        fontWeight: "bold",
        fontSize: 22,
        paddingVertical: 5,
        textAlign: "center"
    },
    detail_body: {
        backgroundColor: "white",
        borderWidth: 1,
        borderColor: "gray",
        paddingHorizontal: 5,
    },
    detail_footer: {
        flexDirection: "row",
        alignItems: "center",
        marginVertical: 10
    },

})