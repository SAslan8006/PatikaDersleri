import { StyleSheet } from "react-native";
import { SIZES } from "../../constants/theme";
export default StyleSheet.create({
top:{
    backgroundColor:"white",
    marginHorizontal:20,
    height:SIZES.height/4,
    borderRadius:20,
    justifyContent:"center",
    alignItems:"center",
    marginBottom:10
},
question:{
   color:"#1d3557",
   fontSize:20,
   fontWeight:"600",
   paddingHorizontal:3,
   textAlign:"justify"
},
optionButtom:{
    backgroundColor:"white",
    marginVertical:10,
    paddingVertical:20,
    marginHorizontal:25,
    borderRadius:30
},
option:{
 color:"#1d3557",
 fontSize:18,
   fontWeight:"600",
   paddingHorizontal:10
},

})