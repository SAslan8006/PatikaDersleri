import { Dimensions, StyleSheet } from "react-native";
const deviceSize = Dimensions.get("window");
export default StyleSheet.create({
    container: {
        backgroundColor: "white",
        borderTopLeftRadius: 10,
        borderTopRightRadius: 10,
        height: deviceSize.height * 0.55,
        padding: 20
    },
    modal: {
        justifyContent: "flex-end",
        padding: 0,
        margin: 0,
    },
    header: {
        color: "black",
        fontWeight: "bold",
        fontSize: 21
    },
    button: {
        paddingHorizontal: 15,
        paddingVertical: 5

    },
    button_title: {
        color: "black",
        fontWeight: "bold",
        fontSize: 18
    },
    value: {
        fontSize: 15,
        paddingVertical: 5
    },

})