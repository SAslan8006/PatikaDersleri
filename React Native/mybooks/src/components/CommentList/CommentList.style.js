import { Dimensions, StyleSheet } from "react-native";
const deviceSize = Dimensions.get("window");
export default StyleSheet.create({
    container: {
        flexDirection: "row",
        padding: 15,
        borderBottomWidth: 1,
        borderBottomColor: "#eeee"

    },
    user_container: {
        flexDirection: "row"
    },
    image: {
        width: 50,
        height: 50,
        borderRadius: 25
    },
    right_container: {
        paddingLeft: 10
    },
    fullName: {
        color: "black",
        fontWeight: "bold",
        backgroundColor: "#e0e0e0",
        paddingHorizontal: 10,
        borderRadius: 10
    },
    userName: {
        paddingLeft: 5
    },
    date: {

    },
    comment: {
        color: "black",
        fontSize: 16,
        paddingTop: 5
    }
})