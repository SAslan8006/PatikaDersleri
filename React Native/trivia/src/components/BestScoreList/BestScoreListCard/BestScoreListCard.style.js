import { StyleSheet } from "react-native";

export default StyleSheet.create({
container:{
    flex:1,
    backgroundColor: "white",
     flexDirection: "row",
     alignItems:"center",
     borderRadius:20,
     marginHorizontal:10,
     marginVertical:8,
     paddingVertical:17,
     paddingHorizontal:10
},
image:{
    width:30,
    height:30,
    color:"#3A0CA3",

},
username:{
    flex:1,
    color:"#3A0CA3",
    fontSize:16,
    fontWeight:"600",
    paddingLeft:5,
   
},
category:{
     flex:1.5,
    color:"#3A0CA3",
      fontSize:16,
    fontWeight:"600",
},
score:{
    color:"#3A0CA3",
      fontSize:18,
      textAlign:"center",
    fontWeight:"800",
    width:40,
    
},
})