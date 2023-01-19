import { Dimensions, StyleSheet } from "react-native";
export default StyleSheet.create({
    container: {
        height: 100,
        flexDirection: "row",
        marginHorizontal: 5,
        justifyContent: "center",
        alignItems: "center",
    },
    container_touch: {
        flex: 1,
        flexDirection: "row",
        justifyContent: "center",
        alignItems: "center",
    },
    image: {
        width: 80,
        height: 80,
        borderRadius: 40,
        resizeMode: "contain",
        marginVertical: 5

    },
    info: {
        flex: 2,
        paddingHorizontal: 10

    },
    fullname: {
        fontWeight: "bold",
        color: "black",
        fontSize: 17
    },
    username: {},
    button: {
        backgroundColor: "blue",
        flex: 1,
        color: "white",
        paddingVertical: 10,
        paddingHorizontal: 20,
        fontWeight: "bold",
        fontSize: 17

    },
})