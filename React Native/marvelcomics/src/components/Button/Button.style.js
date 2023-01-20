import { Dimensions, StyleSheet } from "react-native";
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
            backgroundColor: "red",
            paddingVertical: 12,
            paddingHorizontal: 10,
            alignItems: "center",
            marginVertical: 15,
            marginHorizontal: 30
        },
        title: {
            ...base_style.title,
            fontWeight: "bold",
            color: "white",
            fontSize: 20
        }
    }),
    secondary: StyleSheet.create({
        container: {
            ...base_style.container,
            borderWidth: 1,
            borderColor: "#1c313a",
            alignItems: "center",
            paddingVertical: 10,
            marginHorizontal: 50
        },
        title: {
            ...base_style.title,
            color: "#1c313a",
            fontSize: 20,


        }
    }),
        tertiary: StyleSheet.create({
        container: {
            ...base_style.container,
        },
        title: {
            ...base_style.title,
            color: "red",
            fontSize: 18,
            textDecorationLine:"underline"


        }
    }),



}