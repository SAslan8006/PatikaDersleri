import { StyleSheet, Dimensions } from "react-native";

export default StyleSheet.create({
    character_image: {
        width: Dimensions.get("window").width,
        height: Dimensions.get("window").height / 3,
        resizeMode: "cover"
    },
    character_info: {
        backgroundColor: "black"
    },
    favori_container: {
        flexDirection: "row",
        alignItems: "center",
        paddingVertical: 5,
        paddingHorizontal: 20
    },
    favori_icon: {
        color: "white"
    },
    icon: {
        color: "white"
    },
    name: {
        color: "white",
        paddingLeft: 20,
        fontWeight: "bold",
        fontSize: 20,


    },
    description: {
        flex: 1,
        color: "white",
        paddingHorizontal: 20,
        paddingVertical: 10,
        textAlign: "justify",

    },
})