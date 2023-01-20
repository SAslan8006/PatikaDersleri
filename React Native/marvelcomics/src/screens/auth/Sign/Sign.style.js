import { Dimensions, StyleSheet } from "react-native"
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "white",

    },
    image_container: {
        height: Dimensions.get("window").height * 0.2,
        flexDirection: "row",
        justifyContent: "center",
        alignItems: "center",



    },
    left_logo: {
        width: 200,
        height: 100
    },
    right_logo: {
        alignItems: "center"
    },
    top_logo: {
        width: 50,
        height: 50
    },
    bottom_logo: {
        width: 100,
        height: 50
    },
    title: {
        textAlign: "center",
        color: "red",
        fontSize: 20,
    },
    input_container: {
        height: Dimensions.get("window").height * 0.4,

    },
    input: {
        borderWidth: 1,
        marginHorizontal: 30,
        marginTop: 10,
        borderRadius: 7,
        paddingLeft: 15,
        borderColor: "#bdbdbd"
    },
    errors: {
        color: "red",
        fontWeight: "bold",
        fontSize: 14,
        marginLeft: 30

    },
    input_erros: {
        borderWidth: 1,
        marginHorizontal: 30,
        marginTop: 10,
        borderRadius: 7,
        paddingLeft: 15,
        borderColor: "red"
    },
    show_container: {
        flexDirection: "row",
        alignItems: "center",
        marginHorizontal: 30,
        marginTop: 10
    },
    footer_container: {
        flexDirection: "row",
        justifyContent: "center",
    },
    already_text: {
        fontSize: 18,
        paddingHorizontal: 5
    }

})