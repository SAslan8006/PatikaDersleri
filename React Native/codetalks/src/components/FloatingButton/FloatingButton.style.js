import { StyleSheet } from "react-native";
import colors from "../../styles/colors";

export default StyleSheet.create({
    container: {
        position: "absolute",
        backgroundColor: colors.secondaryColor,
        borderWidth: 1,
        borderColor: colors.darkOrange,
        top: 590,
        bottom: 20,
        right: 20,
        width: 70,
        height: 70,
        borderRadius: 35,
        alignItems: "center",
        justifyContent: "center",

    },
})