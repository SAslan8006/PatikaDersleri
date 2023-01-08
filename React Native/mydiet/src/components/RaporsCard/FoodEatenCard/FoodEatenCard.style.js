import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        backgroundColor: "white",
        margin: 5,
        borderWidth: 1,
        borderColor: "#c5e1a5",
        borderRadius: 5,
    },
    container_title: {
        fontSize: 20,
        color: "black",
        paddingLeft: 10,
        paddingVertical: 10
    },
    header: {
        flexDirection: "row",
        borderBottomWidth: 1,
        borderBottomColor: "#c5e1a5"
    },
    left_title: {
        flex: 4,
        padding: 10,
        fontWeight: "bold",
    },
    count: {
        flex: 1,
        textAlign: "right",
        padding: 7

    },
    calori: {
        flex: 1,
        textAlign: "right",
        padding: 7
    },
    food_info: {
        flexDirection: "row",
        padding: 15,
        borderBottomWidth: 1,
        borderBottomColor: "#c5e1a5"
    },
    foodName: {
        flex: 5,
        color: "black",
        fontSize: 15
    },
    food_count: {
        flex: 1,
        textAlign: "center",
        color: "black",
        fontSize: 15

    },
    food_calori: {
        flex: 1,
        textAlign: "right",
        color: "black",
        fontSize: 15

    },
    toplam_container: {
        flexDirection: "row",
        padding: 15,
        borderBottomWidth: 1,
        borderBottomColor: "#c5e1a5"
    },
    toplam: {
        flex: 5,
        fontSize: 18,
        fontWeight: "bold",
        color: "black",
    },
    food_tcount: {
        flex: 1,
        textAlign: "center",
        color: "black",
        fontSize: 15,
        fontWeight: "bold",
    },
    food_tcalori: {
        flex: 1,
        textAlign: "right",
        color: "black",
        fontSize: 15,
        fontWeight: "bold",
    },
})