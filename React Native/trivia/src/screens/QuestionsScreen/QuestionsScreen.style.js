import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "#3A0CA3"
    },
    header_container: {
        flexDirection: "row",
        alignItems: "center",
        height: 100,
        paddingHorizontal: 10

    },
    ques_count: {
        flex: 1,
        color: "white",
        textAlign: "center",
        fontSize: 24,
        borderWidth: 2,
        borderColor: "white",
        borderRadius: 10
    },
    category: {
        flex: 4,
        color: "white",
        textAlign: "center",
        fontSize: 24
    },
    header_right: {
        flex: 1,
        flexDirection: "row",
        alignItems: "center",

    },
    time: {
        color: "white",
        textAlign: "center",
        fontSize: 24,
        paddingRight: 5,
        
    },
})