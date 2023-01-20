import { Dimensions, StyleSheet } from "react-native";
import { COLORS } from "../../constants/theme";
const base_style = StyleSheet.create({
    container: {
    },
    title: {
    }

})

export default {
    primary: StyleSheet.create({
        ...base_style,
        container: {
            ...base_style.container,
            backgroundColor: "#4361EE",
            alignItems: "center",
            alignSelf: "center",
            margin: 20,
            paddingVertical: 10,
            paddingHorizontal: 50,
            borderRadius: 20


        },
        title: {
            ...base_style.title,
            color: "white",
            fontSize: 20,
            fontWeight: "bold"



        }
    }),
    secondary: StyleSheet.create({
        container: {
            ...base_style.container,

        },
        title: {
            ...base_style.title,



        }
    }),




}