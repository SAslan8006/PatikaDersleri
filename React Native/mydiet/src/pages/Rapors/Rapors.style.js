import { StyleSheet } from "react-native";
import colors from "../../styles/colors";
export default StyleSheet.create({
    header: {
        color: "white",
        fontSize: 20,
        fontWeight: "bold",
        textAlign: "center",
        paddingVertical: 10,
        backgroundColor: colors.darkGreen
    },
    menu_container: {
        flexDirection: "row",
        backgroundColor: colors.darkGreen
    }
})