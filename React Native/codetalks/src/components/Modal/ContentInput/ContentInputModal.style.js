import { Dimensions, StyleSheet } from "react-native";

const deviceSize = Dimensions.get("window")
export default StyleSheet.create({
    container: {
        backgroundColor: "white",
        height: deviceSize.height / 3,
        borderTopLeftRadius: 10,
        borderTopRightRadius: 10,
        padding: 15,


    },
    modal: {
        justifyContent: "flex-end",
        padding: 0,
        margin: 0,
        marginHorizontal: 10
    },
    input_container: {
        flex: 1
    }
})