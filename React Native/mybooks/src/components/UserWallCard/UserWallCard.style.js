import { Dimensions, StyleSheet } from "react-native";
const deviceSize = Dimensions.get("window");
export default StyleSheet.create({
    container: {
        borderBottomWidth: 1,
        borderBottomColor: "#bdbdbd",
        height: deviceSize.height / 2.1,
        marginHorizontal: 10,
        paddingTop: 15,

    },
    image: {
        width: 70,
        height: 70,
        borderRadius: 35,
    },
    userinfo_contianer: {
        flexDirection: "row",
        height: 80,
        alignItems: "center",

    },
    user_container_title: {
        paddingLeft: 10
    },
    user_title: {
        flexDirection: "row",

    },
    fullName: {
        color: "black",
        fontWeight: "bold",
        fontSize: 16
    },
    username: {
        fontSize: 16,
        paddingLeft: 10,
        paddingRight: 5

    },
    date: {
        fontSize: 16,

    },

    desc: {

    },
    container_book: {
        borderWidth: 1,
        borderColor: "#bdbdbd",
        flexDirection: "row",
        borderRadius: 10,
        marginTop: 10
    },
    image_book: {
        width: 100,
        height: 150,
        borderRadius: 10
    },
    icon_image: {
        width: 100,
        height: 150,
        alignItems: "center",
        justifyContent: "center",
        borderRadius: 10,
        backgroundColor: "#eeee",
    },
    info_title: {
        justifyContent: "center",
        paddingLeft: 10
    },
    title: {
        color: "black",
        fontWeight: "bold",
        fontSize: 16,
        paddingBottom: 5
    },
    authors: {
        fontSize: 15,
        paddingBottom: 5
    },
    button_container: {
        flex: 1,
        flexDirection: "column",
        paddingTop: 5,
        paddingLeft: 5,
    },
    button_container_button: {
        flexDirection: "row"
    },
    button_favori_title: {
        fontWeight: "bold",
        paddingVertical: 5
    }

})