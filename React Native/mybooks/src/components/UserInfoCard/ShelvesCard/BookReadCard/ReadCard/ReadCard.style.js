import { Dimensions, StyleSheet } from "react-native";
export default StyleSheet.create({
    container: {
        flexDirection: "row",
        height: Dimensions.get("window").height / 5,
        alignItems: "center",
    },
    image: {
        width: Dimensions.get("window").width / 5,
        height: Dimensions.get("window").height / 6,
        borderRadius: 7,
    },
    icon_image: {
        width: Dimensions.get("window").width / 5,
        height: Dimensions.get("window").height / 6,
        alignItems: "center",
        justifyContent: "center",
        borderRadius: 10,
        backgroundColor: "#eeee",
    },
    info_title: {
        flex: 1,
        paddingHorizontal: 10,


    },
    title: {
        color: "black",
        fontSize: 20,
        fontWeight: "bold",
        paddingVertical: 5
    },
    authors: {
        fontSize: 17,
    },

})