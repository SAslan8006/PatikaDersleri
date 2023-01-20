import React, { useState } from 'react'
import { View, Text, FlatList } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialIcons'
import AntDesign from 'react-native-vector-icons/AntDesign'
import CategoriesCard from '../../components/CategoriesCard'
import CategoryModalContent from '../../components/Modal/CategoryModalContent'
import styles from "./Categories.style"
const Categories = ({ navigation }) => {

    const categories = [
        { id: 32, name: "Cartoon & Animations", color: "#168AAD" },
        { id: 29, name: "Comics", color: "#34A0A4" },
        { id: 27, name: "Animals", color: "#52B69A" },
        { id: 24, name: "Politics", color: "#F3722C" },
        { id: 23, name: "History", color: "#F94144" },
        { id: 22, name: "Geography", color: "#941b0c" },
        { id: 21, name: "Sports", color: "#bc3908" },
        { id: 19, name: "Mathematics", color: "#3e8914" },
        { id: 18, name: "Computers", color: "#f20089" },
        { id: 16, name: "Board Games", color: "#c9184a" },
        { id: 15, name: "Video Games", color: "#ca6702" },
        { id: 14, name: "Television", color: "#9f86c0" },
        { id: 13, name: "Musicals & Theatres", color: "#354f52" },
        { id: 12, name: "Music", color: "#b5838d" },
        { id: 11, name: "Film", color: "#fb8500" },
        { id: 10, name: "Books", color: "#ffafcc" },
        { id: 9, name: "General Knowledge", color: "#2a9d8f" },
        { id: 8, name: "Mix category", color: "#a7c957" },
    ]

    const handleStartGame = (item) => {
        navigation.navigate("QuestionsScreen", { item })

    }
    const renderCategories = ({ item }) => <CategoriesCard item={item} handleStartGame={handleStartGame} />
    return (
        <View style={styles.container}>
            <View style={styles.container_header}>
                <Icon name="keyboard-arrow-left" size={30} color="white" style={styles.header_icon} onPress={() => navigation.goBack()} />
                <Text style={styles.header_title}>Categories</Text>
                <AntDesign name="question" size={30} color="white" style={styles.header_icon} />
            </View>

            <FlatList
                keyExtractor={(item) => item.id}
                data={categories}
                renderItem={renderCategories}
                numColumns={2}
            />



        </View>
    )
}

export default Categories
