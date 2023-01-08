import { Dimensions, StyleSheet } from "react-native";
import colors from "../../../styles/colors";
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: colors.darkGreen,
        alignItems: "center"
    },
    title: {
        fontSize: 25,
        color: "white",
        fontWeight: "bold",
        textAlign: "center"
    },
    gender_male: {
        width: Dimensions.get("window").width / 2,
        marginVertical: 20,
        backgroundColor: "white",
        alignItems: "center"
    },
    gender_female: {
        width: Dimensions.get("window").width / 2,
        marginVertical: 20,
        alignItems: "center",
        backgroundColor: "yellow"
    },
    button: {
        alignItems: "center",
        justifyContent: "center",
        marginTop: 50
    }
})