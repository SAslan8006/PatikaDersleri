import { StyleSheet } from "react-native";

export default StyleSheet.create({
   container:{
       flexDirection: "row",
       justifyContent: 'space-between',
       marginVertical:10
   },
   item:{
       flex:1,
        justifyContent: 'center',
        alignItems: 'center',
   },
   item_title:{
    fontSize:16,
    marginBottom:10
       },
       item_value:{
           fontSize:16,
           color:"black"
       },
       item_cal:{
           fontSize:16,
           fontWeight:"bold",
           color:"black",
            fontSize:16,
    marginBottom:10
       },
       item_value_cal:{
           fontSize:16,
           fontWeight:"bold",
           color:"black"
       }
  
})