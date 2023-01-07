import { StyleSheet } from "react-native";
import colors from "../../styles/colors";


const base_style = StyleSheet.create({
    container: {
        padding: 15,
        margin: 10,
        borderRadius: 10,
        alignItems: "center"
    },
    title: {
        fontWeight: "bold",
        fontSize: 20
    }
})

export default {
    primary: StyleSheet.create({
        ...base_style,
        container: {
            ...base_style.container,
            backgroundColor: colors.secondaryColor
        },
        title: {
            ...base_style.title,
            color: "white"

        }
    }),
    secondary: StyleSheet.create({
        ...base_style,
        container: {
            ...base_style.container,
            backgroundColor: "white",
        },
        title: {
            ...base_style.title,
            color: colors.secondaryColor
        }
    })
}