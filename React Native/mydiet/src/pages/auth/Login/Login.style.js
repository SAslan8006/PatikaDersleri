import { Dimensions, StyleSheet } from "react-native";
import colors from "../../../styles/colors";

export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: colors.darkGreen
    },
    logo_container: {
        flex: 1,
        justifyContent: "center",
        alignItems: "center",
    },
    logo: {
        width: Dimensions.get("window").width * 0.9,
        height: Dimensions.get("window").height / 4,
        resizeMode: "contain",
        tintColor: "white",
    },
    form: {
        flex: 2,
    },

})