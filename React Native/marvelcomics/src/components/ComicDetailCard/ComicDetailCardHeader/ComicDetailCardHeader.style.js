import { StyleSheet,Dimensions } from "react-native";

export default StyleSheet.create({
 character_image: {
        width: Dimensions.get("window").width,
        height: Dimensions.get("window").height / 3,
        resizeMode: "cover"
    },
    character_info: {
        backgroundColor: "black"
    },
    name: {
        color: "white",
        paddingLeft: 20,
        fontWeight: "bold",
        fontSize: 20,
        paddingTop: 10,

    },
    description: {
        flex: 1,
        color: "white",
        paddingHorizontal: 20,
        paddingVertical: 10,
        textAlign: "justify",

    },
})