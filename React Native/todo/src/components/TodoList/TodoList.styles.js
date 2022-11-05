import { StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        minHeight: "65%",

    },
    todo_content: {
        margin: 10,
        padding: 15,
        backgroundColor: "#EB98AD",
        borderRadius: 10
    },
    todoItem: {
        color: "white",
        fontSize: 20
    },
    todo_true: {
        backgroundColor: "#AB6F7E",
        margin: 10,
        padding: 15,
        borderRadius: 10,
        color:"#808080",
        fontSize: 20,
        textDecorationLine: "line-through",
    },
    todoItem_true: {
        color: "#6B464F",
        
    }
})