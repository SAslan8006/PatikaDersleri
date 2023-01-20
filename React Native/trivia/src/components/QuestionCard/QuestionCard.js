import React from 'react'
import { View, Text,TouchableHighlight } from 'react-native'
import styles from "./QuestionCard.style"
import {COLORS} from "../../constants/theme";
const QuestionCard = ({ optionbgColor,questions, ques, options,handleSelectOption,item }) => {
    
console.log(questions)
    return (
        <View>
             {questions &&
                <View style={styles.parent}>
                    <View style={styles.top}>
                        <Text style={styles.question}>{decodeURIComponent(questions[ques]?.question)}</Text>
                    </View>
            { questions[ques]?.type=="multiple" ?
                    <View style={styles.options}>
                        <TouchableHighlight underlayColor={optionbgColor} style={styles.optionButtom} onPress={() => handleSelectOption(options[0],questions[ques])}>
                            <Text style={styles.option}>{decodeURIComponent(options[0])}</Text>
                        </TouchableHighlight>
                        <TouchableHighlight underlayColor={optionbgColor} style={styles.optionButtom} onPress={() => handleSelectOption(options[1],questions[ques])}>
                            <Text style={styles.option}>{decodeURIComponent(options[1])}</Text>
                        </TouchableHighlight>
                        <TouchableHighlight underlayColor={optionbgColor} style={styles.optionButtom} onPress={() => handleSelectOption(options[2],questions[ques])}>
                            <Text style={styles.option}>{decodeURIComponent(options[2])}</Text>
                        </TouchableHighlight>
                        <TouchableHighlight underlayColor={optionbgColor} style={styles.optionButtom} onPress={() => handleSelectOption(options[3],questions[ques])}>
                            <Text style={styles.option}>{decodeURIComponent(options[3])}</Text>
                        </TouchableHighlight>
                         </View>
                       
:
                    <View style={styles.options}>
                           <TouchableHighlight underlayColor={optionbgColor} style={styles.optionButtom} onPress={() => handleSelectOption(options[0],questions[ques])}>
                            <Text style={styles.option}>{decodeURIComponent(options[0])}</Text>
                        </TouchableHighlight>
                        <TouchableHighlight underlayColor={optionbgColor} style={styles.optionButtom} onPress={() => handleSelectOption(options[1],questions[ques])}>
                            <Text style={styles.option}>{decodeURIComponent(options[1])}</Text>
                        </TouchableHighlight>
                     </View>
                        }
                    
                   
                </View>}
        </View>

    )
}

export default QuestionCard
