import { Dimensions, StyleSheet } from "react-native";
const deviceSize = Dimensions.get("window");
export default StyleSheet.create({
    container: {
        backgroundColor: "white",
        borderTopLeftRadius: 10,
        borderTopRightRadius: 10,
        height: deviceSize.height * 0.5,
        padding: 10
    },
    modal: {
        justifyContent: "flex-end",
        padding: 0,
        margin: 0,
    },
    image: {
        width: 70,
        height: 100,
        borderRadius: 10,

    },
    icon_image: {
        width: 70,
        height: 100,
        borderRadius: 10,
        backgroundColor: "#eeee",
        justifyContent: "center",
        alignItems: "center"
    },
    title: {
        paddingVertical: 10,
        color: "black",
        fontSize: 17,
        fontWeight: "bold"

    },
    button_container: {
        paddingVertical: 10,
        flexDirection: "row",
        justifyContent: "space-evenly"
    },
    favori_container: {
        flexDirection: "row",
        justifyContent: "center",
        paddingVertical: 10,
        
       
    }

})