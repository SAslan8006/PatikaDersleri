import { StyleSheet } from "react-native";
export default StyleSheet.create({
    container: {
        backgroundColor: "white",
        flex: 1
    },
    header: {
        flexDirection: "row",
        justifyContent: "space-between",
        alignItems: "center",
        padding: 10,
    },
    title: {
        color: "black",
        fontSize: 17,
        fontWeight: "bold"
    },
    menu_container: {
        flexDirection: "row",
        paddingTop: 10,
        paddingHorizontal: 15,
        borderBottomColor: "#bdbdbd",
        borderBottomWidth: 1
    }

})