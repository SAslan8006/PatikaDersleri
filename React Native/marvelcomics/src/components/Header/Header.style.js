import { Dimensions, StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        height: Dimensions.get("window").height * 0.125,
        backgroundColor: "black"
    },
    title: {
        flex: 1,
        color: "white",
        textAlign: "center",
        fontSize: 22,
        paddingVertical: 5,

    },
    title_container: {
        flexDirection: "row",
        backgroundColor: "#d50000",
        paddingVertical: 5,
        marginHorizontal: 5,
        marginBottom: 7,
        borderRadius: 10

    },
    header_top: {
        flexDirection: "row",
        alignItems: "center",
        marginHorizontal: 5,
    }

})