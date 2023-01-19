import { Dimensions, StyleSheet } from "react-native";
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "white"
    },
    container_header: {
        flexDirection: "row",
        alignItems: "center",
        margin: 10
    },
    arrow_back: {
        width: 30,
        height: 30,
        borderRadius: 20,
        marginRight: 10,
        justifyContent: "center",
        alignItems: "center",
    },
    userinfo_container: {
        flexDirection: "row",
    },
    image: {
        width: 50,
        height: 50,
        borderRadius: 30,
        marginRight: 10,
        resizeMode: "contain"
    },
    fullName: {
        color: "black",
        fontWeight: "bold",
        fontSize: 20
    },
    menu_container: {
        flexDirection: "row",
        borderBottomWidth: 1,
        borderBottomColor: "#e0e0e0",


    }

})