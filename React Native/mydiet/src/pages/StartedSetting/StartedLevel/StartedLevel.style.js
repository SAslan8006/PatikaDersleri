import { Dimensions, StyleSheet } from "react-native";
import colors from "../../../styles/colors";
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: colors.darkGreen,
        alignItems: "center"
    },
    title: {
        fontSize: 20,
        color: "white",
        fontWeight: "bold",
        marginVertical: 10
    },
    container_title: {
        borderWidth: 2,
        borderColor: "white",
        width: Dimensions.get("window").width * 0.9,
        height: Dimensions.get("window").height / 10,
        marginVertical: 15,
        justifyContent: "center",
        alignItems: "center",
        borderRadius: 10
    }
})