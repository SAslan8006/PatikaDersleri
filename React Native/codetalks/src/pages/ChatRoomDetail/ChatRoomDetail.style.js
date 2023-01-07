import { StyleSheet } from "react-native";
import colors from "../../styles/colors";

export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: colors.primaryColor
    },
    room_title: {
        borderWidth: 2,
        borderStyle: "dashed",
        borderColor: "white",
        textAlign: "center",
        color: "white",
        margin: 10,
        padding: 10,
        borderRadius: 10,
        fontSize: 20
    }
})