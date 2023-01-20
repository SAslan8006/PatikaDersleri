import { StyleSheet } from "react-native";
import { SIZES } from "../../constants/theme";

export default StyleSheet.create({
    container: {
        width: SIZES.width / 2.1,
        height: 100,
        justifyContent: "center",
        alignItems: "center",
        margin: 5,
        borderRadius: 15

    },
    title: {
        color: "white",
        fontSize: 20,
        fontWeight: "600"

    }
})