import { Dimensions, StyleSheet } from "react-native";
import colors from "../../../styles/colors";
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: colors.darkGreen,
        alignItems: "center"
    },
    title: {
        fontSize: 20,
        color: "white",
        fontWeight: "bold",
        marginVertical: 20
    },
    input_info: {
        flexDirection: "row",
        alignItems: "center",
        justifyContent: "center",
        width: Dimensions.get("window").width * 0.9,
        marginVertical: 20
    },
    input: {
        width: "40%",
        backgroundColor: "#255d00",
        color: "white",
        fontSize: 20,
        textAlign: "center"
    },
    kg_title: {
        fontSize: 25,
        fontWeight: "bold",
        color: "white",
        marginHorizontal: 10
    },
    button: {
        marginTop: 350,
    }

})