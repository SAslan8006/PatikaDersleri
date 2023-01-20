import { Dimensions, StyleSheet } from "react-native";

export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "white",
    },
    container_header: {
        flexDirection: "row",
        backgroundColor: "black",
        paddingVertical: 5,
        paddingHorizontal: 10
    },
    icon: {
        flex: 1,
        color: "white"
    },
    header: {
        flex: 10,
        fontSize: 20,
        color: "white",
        textAlign: "center"

    },
    sectionHeader_container:{
        flexDirection:"row",
        alignItems: 'center',
        
    },
    sectionHeader:{
        flex:5,
        fontWeight:"bold",
        color:"black",
        fontSize:20,
        paddingVertical:10,
        paddingLeft:10,
      
    },
    seeAll_button:{
        flex:1,
        color:"black",
        paddingVertical:10,
        paddingLeft:10,

    }

})