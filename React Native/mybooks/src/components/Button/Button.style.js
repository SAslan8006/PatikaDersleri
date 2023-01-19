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
            backgroundColor: "#eeeeee",
            paddingVertical: 5,
            paddingHorizontal: 10,
            width: Dimensions.get("window").width * 0.3,
            alignItems: "center",
            borderRadius: 20,
            alignSelf: "flex-end",
            marginVertical: 10
        },
        title: {
            ...base_style.title,
            fontWeight: "bold",
            color: "black",
            fontSize: 20
        }
    }),
    secondary: StyleSheet.create({
        container: {
            ...base_style.container,
            alignItems: "center",
            marginVertical: 10,
        },
        title: {
            ...base_style.title,
            color: "#039be5",
            fontWeight: "bold",
            fontSize: 20,


        }
    }),
    addBook: StyleSheet.create({
        container: {
            ...base_style.container,
            alignItems: "center",
            paddingVertical: 10,
            paddingHorizontal: 20,
            backgroundColor: "#039be5",
            width: Dimensions.get("window").width * 0.8,
            alignSelf: "center",
            borderRadius: 20
        },
        title: {
            ...base_style.title,
            color: "white",
            fontWeight: "bold",
            fontSize: 20,


        }
    }),

    selectCategory: StyleSheet.create({
        container: {
            ...base_style.container,
            alignItems: "center",
            paddingVertical: 10,
            paddingHorizontal: 20,
            borderColor: "#039be5",
            alignSelf: "center",
            borderRadius: 20,
            borderWidth: 1
        },
        title: {
            ...base_style.title,
            color: "#039be5",
            fontSize: 15,


        }
    }),
    seclectedCategory: StyleSheet.create({
        container: {
            ...base_style.container,
            alignItems: "center",
            paddingVertical: 10,
            paddingHorizontal: 20,
            backgroundColor: "#039be5",
            alignSelf: "center",
            borderRadius: 20,

        },
        title: {
            ...base_style.title,
            color: "white",
            fontSize: 16,
            fontWeight: "bold"


        }
    }),
    falseCategory: StyleSheet.create({
        container: {
            ...base_style.container,
            alignItems: "center",
            paddingVertical: 10,
            paddingHorizontal: 20,
            backgroundColor: "#e0e0e0",
            alignSelf: "center",
            borderRadius: 20,
            borderWidth: 1,
            borderColor: "#e0e0e0",
        },
        title: {
            ...base_style.title,
            color: "#eeee",
            fontSize: 15,


        }
    }),
    icon_button: StyleSheet.create({
        container: {
            ...base_style.container,
            flex: 1,
            alignItems: "center",
            paddingVertical: 10,
            paddingHorizontal: 35,
            alignSelf: "center",




        },
        title: {
            ...base_style.title,
            fontSize: 15,
            color: "black",

        }
    }),
    follow: StyleSheet.create({
        container: {
            ...base_style.container,
            paddingVertical: 10,
            marginRight: 10,
            paddingHorizontal: 20,
            backgroundColor: "#039be5",
            borderRadius: 30

        },
        title: {
            ...base_style.title,
            fontSize: 17,
            color: "white",
            fontWeight: "bold"

        }
    }),
    unfollow: StyleSheet.create({
        container: {
            ...base_style.container,
            paddingVertical: 10,
            marginRight: 10,
            paddingHorizontal: 20,
            backgroundColor: "#e0e0e0",
            borderRadius: 30

        },
        title: {
            ...base_style.title,
            fontSize: 17,
            color: "black",
            fontWeight: "bold"

        }
    }),

    bookInfo: StyleSheet.create({
        container: {
            ...base_style.container,
            paddingVertical: 10,
            marginRight: 10,
            paddingHorizontal: 20,
            backgroundColor: "#e0e0e0",
            borderRadius: 30

        },
        title: {
            ...base_style.title,
            fontSize: 17,
            fontWeight: "bold"

        }
    }),
    darkbookInfo: StyleSheet.create({
        container: {
            ...base_style.container,
            paddingVertical: 10,
            marginRight: 10,
            paddingHorizontal: 20,
            backgroundColor: "black",
            borderRadius: 30

        },
        title: {
            ...base_style.title,
            fontSize: 17,
            color: "white",
            fontWeight: "bold"

        }
    }),
    bookRaf: StyleSheet.create({
        container: {
            ...base_style.container,
            paddingVertical: 10,
            marginRight: 10,
            paddingHorizontal: 20,
            backgroundColor: "#e0e0e0",
            borderRadius: 30

        },
        title: {
            ...base_style.title,
            fontSize: 17,

            fontWeight: "bold"

        }
    }),

    darkbookRaf: StyleSheet.create({
        container: {
            ...base_style.container,
            paddingVertical: 10,
            marginRight: 10,
            paddingHorizontal: 20,
            backgroundColor: "black",
            borderRadius: 30

        },
        title: {
            ...base_style.title,
            fontSize: 17,
            color: "white",
            fontWeight: "bold"

        }
    }),
    wallread: StyleSheet.create({
        container: {
            ...base_style.container,
            paddingVertical: 5,
            marginRight: 10,
            paddingHorizontal: 20,
            backgroundColor: "#e0e0e0",
            borderRadius: 30,
            marginTop: 10,
            width: Dimensions.get("window").width / 2.5,
            alignItems: "center"

        },
        title: {
            ...base_style.title,
            fontSize: 17,
            fontWeight: "bold"

        }
    }),
    wallfavori: StyleSheet.create({
        container: {
            ...base_style.container,
            backgroundColor: "#f5f5f5",
            borderRadius: 20,
            width: 60,
            height: 35,
            alignItems: "center",
            marginRight: 10

        },
        title: {
            ...base_style.title,


        }
    }),
    wallcommon: StyleSheet.create({
        container: {
            ...base_style.container,
            backgroundColor: "#f5f5f5",
            borderRadius: 20,
            width: 60,
            height: 35,
            alignItems: "center"
        },
        title: {
            ...base_style.title,


        }
    }),
    send_button: StyleSheet.create({
        container: {
            ...base_style.container,
            backgroundColor: "#1976d2",
            borderRadius: 20,
            width: 80,
            height: 35,
            alignItems: "center",
            justifyContent: "center",
            marginRight: 15
        },
        title: {
            ...base_style.title,
            color: "white",
            fontWeight: "bold"

        }
    }),


}

