import React from 'react'
import { View, Text,Image,TouchableOpacity} from 'react-native'
import Icon from 'react-native-vector-icons/MaterialCommunityIcons'
import styles from "./Results.style"
const Results = ({navigation,route}) => {
    const {score,item}=route.params
const scoreBanner = score > 30 ? 'https://cdni.iconscout.com/illustration/premium/thumb/men-celebrating-victory-4587301-3856211.png' : "https://cdni.iconscout.com/illustration/premium/thumb/businessman-dealing-with-business-failure-5623858-4678583.png"

const handleHomeBack=()=>{
    navigation.navigate("HomeScreen")
}
const handleCategoriesBack=()=>{
    navigation.navigate("CategoriesScreen")
}
const handleGameBack=()=>{ 
    navigation.push("QuestionsScreen",{item})
}

    return (
        <View style={styles.container}>
        <Text style={styles.name}>{item.name}</Text>
            <Text style={styles.score}>{score} points</Text>
            <Text style={styles.score_desc}>you gave {score/10} correct answers</Text>
            <View style={styles.banner_container}>
                <Image
                    source={{ uri: scoreBanner }}
                    style={styles.banner}
                    resizeMode="contain"
                />
            </View>
            <View style={styles.footer_container}>
           <TouchableOpacity onPress={handleHomeBack} style={styles.button}>
           <Icon name="home-circle" size={40} color="white"/>
           <Text style={styles.title}>Home</Text>
           </TouchableOpacity>
           <TouchableOpacity onPress={handleCategoriesBack} style={styles.button}>
           <Icon name="format-list-bulleted" size={40} color="white"/>
           <Text style={styles.title}>Categories</Text>
           </TouchableOpacity>
           <TouchableOpacity onPress={handleGameBack} style={styles.button}>
           <Icon name="repeat" size={40} color="white"/>
           <Text style={styles.title}>Play Again</Text>
           </TouchableOpacity>
            </View>
            
            
        </View>
    )
}

export default Results
