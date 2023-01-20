import { StyleSheet } from "react-native";
import { COLORS } from "../../constants/theme";

export default StyleSheet.create({
    container: {
        width: "100%",
        marginBottom: 20,
    },
    input: {
        padding: 10,
        borderColor: COLORS.black + '20',
        borderWidth: 1,
        width: "100%",
        borderRadius: 5,
        marginTop: 10
    }
})