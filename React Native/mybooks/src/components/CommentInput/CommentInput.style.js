import { Dimensions, StyleSheet } from "react-native";
const WIDTH = Dimensions.get('window').width;
const HEIGHT = Dimensions.get('window').height;
export default StyleSheet.create({
    input_container: {
        flexDirection: "column",
        backgroundColor: "#eeeeee",
        paddingBottom: 5,



    },
    top_container: {
        flexDirection: "row"
    },
    bottom_container: {
        alignItems: "flex-end",
    },
    input_image: {
        width: 50,
        height: 50,
        borderRadius: 25,
        marginLeft: 10,
        marginVertical: 10
    },
    input: {
        flex: 1,
        backgroundColor: "white",
        borderRadius: 20,
        marginHorizontal: 15,
        marginVertical: 12,
        paddingLeft: 20,
        paddingVertical: 5,
        backgroundColor: "white"

    }


})