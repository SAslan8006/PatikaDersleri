import { StyleSheet } from "react-native";
import { SIZES } from "../../constants/theme"
export default StyleSheet.create({
container:{
    flex:1,
    backgroundColor: "#3A0CA3",
    alignItems:"center"
},
name:{
    color:"white",
    fontSize:24,
    fontWeight:"bold",
    paddingVertical:10
},
score:{
    color:"white",
    fontSize:30,
    fontWeight:"bold",
    paddingVertical:10
},
score_desc:{
  color:"white",
    fontSize:20,
    fontWeight:"bold",
    paddingVertical:10
},
    banner: {
        height: 300,
        width: 300,
       
    },
    banner_container: {
        justifyContent: "center",
        alignItems: "center",
          height: SIZES.height / 2,
       
    },
    footer_container:{
        width:SIZES.width/1.3,
        height: SIZES.height*0.15,
        flexDirection:"row",
        justifyContent:"center",
        alignItems:"center",

    },
    button:{
        flex:1,
        justifyContent:"center",
        alignItems:"center"
    },
    title:{
        color:"white",
        fontSize:18,
        fontWeight:"600"
    }
})