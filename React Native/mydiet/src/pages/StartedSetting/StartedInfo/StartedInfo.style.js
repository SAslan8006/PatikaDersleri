import { StyleSheet } from "react-native";
import colors from "../../../styles/colors";
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: colors.darkGreen
    },
    container_title: {
        flex: 1,
        alignItems: "center",
        justifyContent: "center"
    },
    title: {
        fontSize: 25,
        color: "white",
        fontWeight: "bold"
    },
    container_info: {
        flex: 2,

    },
    info: {
        color: "white",
        fontSize: 25,
        textAlign: "center"

    },
    button: {
        flex: 1,
        alignItems: "center",
        justifyContent: "center"
    }

})