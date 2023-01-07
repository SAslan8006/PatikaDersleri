import { Dimensions, StyleSheet } from "react-native";
import colors from "../../styles/colors";
const deviceSize = Dimensions.get("window")
export default StyleSheet.create({
    container: {
        width: deviceSize.width * 0.45,
        height: deviceSize.height / 4,
        borderWidth: 2,
        borderColor: "#d6d7d8",
        borderRadius: 10,
        margin: 10,
        justifyContent: "center",
        alignItems: "center"
    },
    room_name: {
        color: colors.primaryColor,
        fontSize: 30,

    }

})