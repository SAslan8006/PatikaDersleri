import { StyleSheet } from "react-native";
import { SIZES } from "../../constants/theme";

export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "#3A0CA3"
    },
    container_header: {
        flexDirection: "row",
        justifyContent: "center",
        alignItems: "center"
    },
    header_icon: {
        width: SIZES.width * 0.1,
        height: SIZES.height * 0.04,
        borderRadius: 20,
        margin: 5,
        textAlign: "center"

    },
    header_title: {
        flex: 1,
        textAlign: "center",
        color: "white",
        fontSize: 24,
        fontWeight: "600",
    },

})