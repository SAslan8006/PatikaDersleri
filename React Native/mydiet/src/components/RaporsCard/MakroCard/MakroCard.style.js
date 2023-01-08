import { StyleSheet } from "react-native";
import colors from "../../../styles/colors";

export default StyleSheet.create({
    container: {
        backgroundColor: "white",
        margin: 5,
        borderWidth: 1,
        borderColor: "#c5e1a5",
        borderRadius: 5,
        paddingBottom: 15

    },
    container_title: {
        flexDirection: "row",
        borderWidth: 1,
        borderColor: "#c5e1a5",
        paddingVertical: 15
    },
    container_toplam: {
        flex: 4,
        textAlign: "right",
        fontWeight: "bold",
        fontSize: 15
    },
    container_target: {
        flex: 1,
        textAlign: "center",
        fontWeight: "bold",
        fontSize: 15
    },
    cal_title: {
        textAlign: "left",
        borderBottomWidth: 1,
        borderBottomColor: "#c5e1a5",
        alignItems: "flex-end",
        padding: 10
    },
    title: {
        fontWeight: "bold",
        fontSize: 15
    },
    feed_container: {
        flexDirection: "row",
        borderBottomWidth: 1,
        borderBottomColor: "#c5e1a5",
    },
    feed_left: {
        flex: 4,
        flexDirection: "row"
    },
    feed_right: {
        flex: 2,
        flexDirection: "row"
    },
    feed_orange: {
        flex: 1,
        marginVertical: 15,
        marginHorizontal: 12,
        backgroundColor: "orange"
    },
    feed_blue: {
        flex: 1,
        marginVertical: 15,
        marginHorizontal: 12,
        backgroundColor: "#4dd0e1"
    },
    feed_pink: {
        flex: 1,
        marginVertical: 15,
        marginHorizontal: 12,
        backgroundColor: "pink"
    },
    feed_name: {
        flex: 7,
        color: colors.darkGreen,
        fontSize: 20,
        paddingVertical: 12,
    },
    feed_value: {
        flex: 1,
        textAlign: "center",
        paddingVertical: 12,
        fontSize: 15,
        color: "black",

    },
    feed_redValue: {
        flex: 1,
        textAlign: "center",
        paddingVertical: 12,
        fontSize: 15,
        color: "red",
    },
    feed_calori: {
        flex: 1,
        textAlign: "center",
        paddingVertical: 12,
        fontSize: 15,
        color: "black",

    },

})