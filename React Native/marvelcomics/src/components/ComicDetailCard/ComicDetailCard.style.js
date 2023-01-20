import { StyleSheet,Dimensions } from "react-native";

export default StyleSheet.create({
  container: {
        flex: 1,
        width: Dimensions.get("window").width / 2.2,
       marginLeft:10,
      
    
    },
    title: {
        color: "black",
        paddingTop:5,
        paddingBottom:25,
    },
    image: {
        width: 170,
        height: Dimensions.get("window").height / 3,
       
    
    },
})