import { StyleSheet } from "react-native"
import { COLORS } from "../../../constants/theme"
export default StyleSheet.create({
    container: {
        backgroundColor: COLORS.white,
        flex: 1,
        alignItems: "center",
        justifyContent: "flex-start",
        padding: 20,

    },
    title: {
        fontSize: 24,
        color: COLORS.black,
        fontWeight: "bold",
        marginVertical: 32
    },
    footer_container: {
        flexDirection: "row",
        alignItems: "center",
        marginTop: 20
    },
    text_right: {
        marginLeft: 4,
        color: COLORS.primary
    },
})