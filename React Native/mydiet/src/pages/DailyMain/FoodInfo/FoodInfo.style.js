import { Dimensions, StyleSheet } from "react-native";
import colors from "../../../styles/colors";
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "white"
    },
    title: {
        color: "black",
        fontSize: 23,
        fontWeight: "bold",
        marginVertical: 10,
        marginHorizontal: 20
    },
    value_container: {
        flexDirection: "row",
        flexWrap: "wrap"
    },
    value: {
        backgroundColor: "gray",
        width: Dimensions.get("window").width / 2,
        borderWidth: 1,
        borderColor: "white",
        padding: 10,
        alignItems: "center",
        justifyContent: "center"
    },
    value_title: {
        color: "white",
        fontSize: 20
    },
    value_count: {
        color: "white",
        fontSize: 22,
        fontWeight: "bold"
    },
    button: {
        margin: 20,
        backgroundColor: colors.darkGreen,
        alignItems: "center",
        justifyContent: "center",
        padding: 10,
        borderRadius: 12
    },
    button_text: {
        color: "white",
        fontSize: 20,
        fontWeight: "bold"
    }
})