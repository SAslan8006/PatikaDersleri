import React from 'react'
import { View, Text } from 'react-native'
import styles from "./TodoList.styles"
const TodoList = ({todoList,setList}) => {
const handleChangeIsDone=(id)=>{
const newList=todoList.map(todo=>todo.id===id ? {...todo,isDone : !todo.isDone} : todo )
  setList(newList)
  }
  
  const handleDeleteTodo=(id)=>{
      const newList=todoList.filter(todo=>todo.id!==id  )
  setList(newList)
  }
    return (
        <View style={styles.container}>
        {
            todoList.map((item)=>(
                <View style={item.isDone ? styles.todoItem_true : styles.todo_content} key={item.id}>
                <Text 
                style={item.isDone ? styles.todo_true :  styles.todoItem}
                onPress={() => handleChangeIsDone(item.id)}
                onLongPress={()=>handleDeleteTodo(item.id)}
                >{item.text}</Text>
            </View>
            ))
        }
            
        </View>
    )
}
export default TodoList;