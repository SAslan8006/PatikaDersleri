import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        borderWidth: 1,
        margin: 10,
        borderColor: "#bdbdbd",
        backgroundColor: "#e0e0e0",
        flexDirection: "row",
        
    },
    image: {
        width: 100,
        minHeight: 100,
        resizeMode: "contain",
        backgroundColor: "white"
    },
    body_container: {
        flex: 1,
        padding: 5,
    },
    title: {
        fontSize: 18,
        fontWeight: "bold",
        color: "black"
    },
    price: {
        textAlign: "right",
        fontSize: 16,
        fontStyle: "italic",
        color: "black"
    },
    rate: {
        fontWeight: "bold",
        color: "green",
        fontSize: 16
    }
});