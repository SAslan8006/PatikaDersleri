import { Dimensions, StyleSheet } from "react-native";
import colors from "../../styles/colors";
export default StyleSheet.create({
    container: {
        flex: 1
    },
    top_container: {
        flex: 1,
    },
    bottom_container: {
        flex: 2,
    },
    logo_container: {
        flex: 1,
        backgroundColor: colors.darkGreen,
        alignItems: "center",

    },
    logo: {
        width: Dimensions.get("window").width / 2,
        height: 50,
        tintColor: "white",
        resizeMode: "contain",
        marginVertical: 10
    },
    icon_container: {
        flex: 1,
        backgroundColor: "white",
        alignItems: "center"
    },
    icon: {
        width: 100,
        height: 100,
        borderRadius: 50,
        backgroundColor: colors.darkGreen,
        marginTop: -45

    },
    username: {
        fontSize: 20,
        fontStyle: "italic",
        fontWeight: "bold",
        marginTop: 10

    }

})