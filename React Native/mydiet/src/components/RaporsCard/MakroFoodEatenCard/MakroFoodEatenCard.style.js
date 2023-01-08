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
        flex: 3,
        padding: 10,
        fontWeight: "bold",

    },
    carb: {
        flex: 1,
        textAlign: "center",
        padding: 5,


    },
    fat: {
        flex: 1,
        textAlign: "center",
        padding: 5
    },
    prot: {
        flex: 1,
        textAlign: "center",
        padding: 5,

    },
    food_info: {
        flexDirection: "row",
        padding: 15,
        borderBottomWidth: 1,
        borderBottomColor: "#c5e1a5"
    },
    foodName: {
        flex: 2,
        color: "black",
        fontSize: 15
    },
    food_tvalue: {
        flex: 1,
        textAlign: "right",
        color: "black",
        fontSize: 15

    },
    toplam_container: {
        flexDirection: "row",
        borderBottomWidth: 1,
        borderBottomColor: "#c5e1a5",
        paddingVertical: 15
    },
    toplam: {
        flex: 3,
        fontSize: 18,
        fontWeight: "bold",
        color: "black",
        paddingLeft: 15
    },
    toplam_value: {
        flex: 1,
        textAlign: "center",
        color: "black",
        fontSize: 15,
        fontWeight: "bold",
    },

})