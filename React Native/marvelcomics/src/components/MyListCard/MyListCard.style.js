import { Dimensions, StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        flexDirection: "row",
        marginHorizontal: 10,
        marginTop: 10,
        height: Dimensions.get("window").height / 4,

    },
    image: {
        height: "100%",
        flex: 1
    },
    title: {
        color: "black",
        fontWeight: "bold",
        fontSize: 20,


    },
    container_right: {
        flex: 1,
        paddingLeft: 10,

    },
    favori_icon: {
        color: "red",
        paddingHorizontal: 15,
        paddingVertical: 5

    },

})