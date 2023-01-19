import { StyleSheet } from "react-native";
export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "white",
        padding: 20
    },
    sign_title: {
        color: "black",
        fontWeight: "bold",
        fontSize: 20
    },
    input: {
        borderWidth: 1,
        borderColor: "gray",
        borderRadius: 5,
        paddingLeft: 10,
        marginVertical: 10,
        fontSize: 20,

    },
    input_icon: {
        position: "absolute",
        marginTop: 45,
        marginLeft: 315
    },
    password_icon: {
        position: "absolute",
        marginTop: 50,
        marginLeft: 315
    },
    errors: {
        color: "red",
        fontWeight: "bold",
        fontSize: 14,

    }

})