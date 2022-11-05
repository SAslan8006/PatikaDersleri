import React,{useState} from 'react';
import {  SafeAreaView,  StyleSheet,  View,  Alert} from 'react-native';
import SaveTodo from './components/SaveTodo';
import TodoCounter from './components/TodoCounter';
import TodoList from './components/TodoList';


const App = () => {
const [todo,setTodo]=useState("")
const [list,setList]=useState([])

const handleSaveTodo=()=>{
  if(todo.length>0){
 const newTodo={
    id:(Math.random().toFixed(4)),
    text:todo,
    isDone:false
  }
 setList([newTodo,...list])
setTodo("")
  }else{
    Alert.alert("Boş Bilgi","Boş bir ekleme yapamazsınız...",[], {
      cancelable: true,
      onDismiss: () => Alert.alert("Boş Bilgi", "Todo girmelisiniz. "
        ),});
  }
}

  return (
    <SafeAreaView style={styles.container}>
      <View style={styles.container}>
        <TodoCounter list={list}/>
      <TodoList todoList={list} setList={setList}/>
        <SaveTodo setTodo={setTodo} handleSaveTodo={handleSaveTodo} text={todo}/>
      </View>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#5E3D46"
  }

});

export default App;
