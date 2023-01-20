import { Dimensions, StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        marginLeft: 10,
        marginVertical: 5
    },
    image: {
        width: Dimensions.get("window").width / 2.15,
        height: Dimensions.get("window").height / 4,

    },
    name: {
        color: "white",
        fontSize: 20,
        fontWeight: "bold",
        padding: 5
    },
    name_container: {
        backgroundColor: "black",
        position: "absolute",
        width: "100%",
        bottom: 0,
        opacity: 0.7

    }
})