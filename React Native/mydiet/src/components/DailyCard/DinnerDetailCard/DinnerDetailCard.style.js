import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        flexDirection: "row",
        backgroundColor: "white",
        marginHorizontal: 10,
        borderTopWidth: 1,
        borderTopColor: "#c8e6c9",
        paddingLeft: 40,
        borderBottomLeftRadius: 15,
        borderBottomRightRadius: 15, 

    },
    container_left: {
        flex: 4
    },
    title: {
        fontSize: 18,
        fontWeight: "600",
        marginVertical: 5
    },
    food_values: {
        flexDirection: "row"
    },
    value: {
        flex: 1,
        marginVertical: 10
    },
    container_right: {
        flex: 1,
        alignItems: "center",
        justifyContent: "center",


    },
    calori: {
        fontSize: 20,
        fontWeight: "bold"
    },
})