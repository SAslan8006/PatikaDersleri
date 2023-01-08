import { StyleSheet } from "react-native";
import colors from "../../styles/colors";
const base_style = StyleSheet.create({
    container: {
        padding: 15,
        margin: 10,
        borderRadius: 10,
        alignItems: "center",
        justifyContent: "center"
    },
    title: {
        fontWeight: "bold",
        fontSize: 20,
    }

})

export default {
    started: StyleSheet.create({
        ...base_style,
        container: {
            ...base_style.container,
            backgroundColor: "white",
            width: 60,
            height: 60,
            borderRadius: 30,
            alignItems: "center",
            justifyContent: 'center',
        },
    }),
    arrow: StyleSheet.create({
        ...base_style,
        icon: {
            fontWeight: "bold",
            fontSize: 35,



        },
    }),
    primary: StyleSheet.create({
        ...base_style,
        container: {
            ...base_style.container,
            backgroundColor: "white"
        },
        title: {
            ...base_style.title,
            color: colors.darkGreen

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
            color: colors.darkGreen
        }
    })
}