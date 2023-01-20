import { Dimensions, StyleSheet } from "react-native"
import { COLORS } from "../../../constants/theme"
import { SIZES } from "../../constants/theme"
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "#3A0CA3"
    },
    container_header: {
        flexDirection: "row",
        justifyContent: "space-between"
    },
    settings_icon: {
        paddingVertical: 10,
        paddingHorizontal: 5,
    },
    signout_icon: {
        paddingVertical: 10,
        paddingHorizontal: 5,

    },
    image: {
        height: SIZES.height / 5,
        width: SIZES.width / 1.5,
        alignSelf: "center",


    },

})