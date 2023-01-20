import { Dimensions, StyleSheet } from "react-native";

export default StyleSheet.create({
   container:{
       flexDirection:"row",
       marginHorizontal:10,
       marginTop:10,
     height: Dimensions.get("window").height / 4,
      
   },
image:{
height:"100%",
flex:1
},
title:{
    flex:1,
color:"black",
fontWeight:"bold",
fontSize:20,
paddingLeft:10
},
})