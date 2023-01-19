import { Dimensions, StyleSheet } from "react-native";
export default StyleSheet.create({
    coverImage: {
        width: Dimensions.get("window").width * 1,
        height: Dimensions.get("window").height * 0.25,
        justifyContent: 'center',
        alignItems: "center",
        backgroundColor: "#eeeeee"

    },
    backgroundImage: {
        width: "100%",
        height: "100%",
    },
    profileImage: {
        width: 100,
        height: 100,
        borderRadius: 50,
        backgroundColor: "#eeeeee",
        justifyContent: "center",
        alignItems: "center",
        left: 15,
        marginTop: -50,
    },
    profileImage_value: {
        width: 100,
        height: 100,
        borderRadius: 50,
        borderWidth: 2,
        borderColor: "white"
    },
    info_container: {
        paddingHorizontal: 15,
        paddingTop: 15
    },
    fullname: {
        color: "black",
        fontWeight: "bold",
        fontSize: 20
    },
    username: {
    },
    date: {
        paddingVertical: 5
    },

})