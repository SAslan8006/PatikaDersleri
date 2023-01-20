import React, { useState,useEffect } from 'react'
import { View, Text } from 'react-native'
import auth from "@react-native-firebase/auth"
import database from "@react-native-firebase/database"
import Config from 'react-native-config'
import Icon from 'react-native-vector-icons/MaterialIcons'
import Loading from '../../components/Loading/Loading'
import QuestionCard from '../../components/QuestionCard'
import styles from "./QuestionsScreen.style"

const shuffleArray = (array) => {
    for (let i = array.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }
}

const QuestionsScreen = ({ navigation, route }) => {
    const [questions, setQuestions] = useState()
     const [isLoading, setIsLoading] = useState(false)
    const [ques, setQues] = useState(0)
    const [options, setOptions] = useState([])
    const [score, setScore] = useState(0)
    const [seconds, setSeconds] = useState(12);
    const [optionbgColor, setOptionBgColor] = useState("")
    const [optionTextColor, setOptionTextColor] = useState("")


   

    const { item } = route.params
   

    const useFetch = async () => {
        setIsLoading(true)
        const res = await fetch(
        (item.id != 8 && item.type != null && item.difficulty != null)
            ? `${Config.API_URL}&category=${item.id}&difficulty=${item.difficulty}&type=${item.type}&encode=url3986`
            : (item.id != 8 && item.type == null && item.difficulty != null)
                ? `${Config.API_URL}&category=${item.id}&difficulty=${item.difficulty}&encode=url3986`
                : (item.id != 8 && item.type != null && item.difficulty == null)
                    ? `${Config.API_URL}&category=${item.id}&type=${item.type}&encode=url3986`
                    : (item.id != 8 && item.type == null && item.difficulty == null)
                        ? `${Config.API_URL}&category=${item.id}&encode=url3986`
                        : (item.id == 8 && item.type == null && item.difficulty == null)
                            ? `${Config.API_URL}&encode=url3986`
                            : (item.id == 8 && item.type != null && item.difficulty == null)
                                ? `${Config.API_URL}&type=${item.type}&encode=url3986`
                                : (item.id == 8 && item.type == null && item.difficulty != null)
                                    ? `${Config.API_URL}&difficulty=${item.difficulty}&encode=url3986`
                                    : (item.id == 8 && item.type != null && item.difficulty != null)
                                        ? `${Config.API_URL}&difficulty=${item.difficulty}&type=${item.type}&encode=url3986`
                                        : null
    )
        const data = await res.json()
        setQuestions(data.results)
        setOptions(generateOptionsAndShuffle(data.results[0]))
        setIsLoading(false)
    }
    useEffect(() => {
        useFetch()
    }, [])

    
     const generateOptionsAndShuffle = (_question) => {
        const options = [..._question.incorrect_answers]
        options.push(_question.correct_answer)
        shuffleArray(options)
        return options
    }

      const handleSelectOption = (_option,question) => {
      
             
        if (_option === questions[ques].correct_answer) {
            setScore(score + 10)
             setOptionBgColor("green")
             setOptionTextColor("white")
        }else {
            setOptionBgColor("red")
             setOptionTextColor("white")
        }
           if (ques !== 9) {
            setQues(ques + 1)
            setOptions(generateOptionsAndShuffle(questions[ques + 1]))
            setSeconds(12)
        }  
        if (ques === 9) {
            handleShowResults()
        }

    }
        const handleShowResults = () => {
            const randomNumber=Math.floor(Math.random() * 100+1)
       const userMail = auth().currentUser.email
        const contentObject = {
            category:item.name,
            score,
            username: userMail.split('@')[0]+randomNumber,
            date: new Date().toISOString(),
        }
        database().ref('gamers/').push(contentObject)


        navigation.navigate("ResultsScreen", {
            score,
            item
        })
    }

     useEffect(() => {
    const interval = setInterval(() => {
      setSeconds(seconds => seconds - 1);
    }, 1000);
     if (seconds === 0) {
      clearTimeout(interval);
      if(ques!==9){
           setQues(ques + 1)
            setOptions(generateOptionsAndShuffle(questions[ques + 1]))
            setSeconds(12)
            }
             if (ques === 9) {
            handleShowResults()
        }
    }
    
    return () => clearInterval(interval);
  }, [seconds]);
    
    if (isLoading) {
        <Loading />
    }
    return (
        <View style={styles.container}>
            <View style={styles.header_container}>
                <Text style={styles.ques_count}>{ques+1}.</Text>
                <Text style={styles.category}>{item.name}</Text>
                <View style={styles.header_right}>
                    <Text style={styles.time}>{questions && seconds}</Text>
                    <Icon name="watch-later" size={30} color="white" />
                </View>
            </View>
            <QuestionCard optionTextColor={optionTextColor} optionbgColor={optionbgColor}  item={item} questions={questions} ques={ques} options={options} handleSelectOption={handleSelectOption}/>



        </View>
    )
}

export default QuestionsScreen
