import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        borderWidth: 1,
        margin: 10,
        padding: 10,
        borderColor: "#bdbdbd",
        backgroundColor: "#FFFFFF",
        flexDirection: "column",
        borderRadius: 10

    },
    title: {
        color: "black",
        fontWeight: "bold",
        fontSize: 20

    },
    company: {
        color: "black",
        fontSize: 20
    },
    location: {
        flexWrap: "wrap",
        backgroundColor: "#EF5350",
        color: "white",
        fontWeight: "bold",
        fontSize: 22,
        borderRadius: 20,
        paddingVertical: 5,
        paddingHorizontal: 15,
        marginVertical: 5,
        alignSelf: 'baseline',
    },
    level: {
        color: "#EF5350",
        fontWeight: "bold",
        textAlign: "right",
        fontSize: 18,
        marginRight: 5,
        marginVertical: 5
    },
    button: {
        marginVertical: 30
    }
})