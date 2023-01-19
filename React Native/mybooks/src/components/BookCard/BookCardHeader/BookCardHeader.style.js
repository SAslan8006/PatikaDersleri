import { Dimensions, StyleSheet } from "react-native";

export default StyleSheet.create({

    container: {
        flexDirection: "row",
        height: Dimensions.get("window").height / 5.4,
        padding: 10,
    },
    image: {
        width: 85,
        height: 120,
        borderRadius: 8
    },
    icon_image: {
        width: 85,
        height: 120,
        borderRadius: 8,
        backgroundColor: "#eeee",
        justifyContent: "center",
        alignItems: "center"
    },
    info_title: {
        justifyContent: "center",
        paddingLeft: 12,

    },
    title: {
        fontSize: 21,
        fontWeight: "500",
        color: "black",
    },
    authors: {
        fontSize: 15,
    }
})