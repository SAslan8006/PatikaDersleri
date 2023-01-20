import React, { useState } from 'react';
import { StatusBar, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { Dropdown } from 'react-native-element-dropdown';


const dataDifficulty = [
  { label: 'Any Difficulty', value: 'any' },
  { label: 'Easy', value: 'easy' },
  { label: 'Medium', value: 'medium' },
  { label: 'Hard', value: 'hard' },
];
const dataType = [
  { label: 'Any Difficulty', value: 'any' },
  { label: 'Multiple Choicce', value: 'multiple' },
  { label: 'True/False', value: 'boolean' },
];

const DropdownComponent = ({ category, handleStartGame }) => {
  const [difficulty, setDifficulty] = useState(null)
  const [type, setType] = useState(null)
  const [isFocus, setIsFocus] = useState(false);


  const handleStart = (category) => {
    const newCategory = { ...category, difficulty, type }
    handleStartGame(newCategory)

  }
  return (
    <View style={[styles.container, { backgroundColor: category.color, }]}>
      <StatusBar barStyle="light-content" />
      <View style={{ backgroundColor: "white", borderRadius: 20, padding: 20 }}>
        <Dropdown
          style={[styles.dropdown, isFocus && { borderColor: 'blue' }]}
          placeholderStyle={styles.placeholderStyle}
          selectedTextStyle={styles.selectedTextStyle}
          inputSearchStyle={styles.inputSearchStyle}
          iconStyle={styles.iconStyle}
          data={dataDifficulty}
          maxHeight={300}
          labelField="label"
          valueField="value"
          placeholder={!isFocus ? 'Select Difficulty' : '...'}
          searchPlaceholder="Search..."
          value={difficulty}
          onFocus={() => setIsFocus(true)}
          onBlur={() => setIsFocus(false)}
          onChange={item => {
            setDifficulty(item.value);
            setIsFocus(false);
          }}
        />
        <Dropdown
          style={[styles.dropdown, isFocus && { borderColor: 'blue' }]}
          placeholderStyle={styles.placeholderStyle}
          selectedTextStyle={styles.selectedTextStyle}
          inputSearchStyle={styles.inputSearchStyle}
          iconStyle={styles.iconStyle}
          data={dataType}
          maxHeight={300}
          labelField="label"
          valueField="value"
          placeholder={!isFocus ? 'Select Type' : '...'}
          searchPlaceholder="Search..."
          value={type}
          onFocus={() => setIsFocus(true)}
          onBlur={() => setIsFocus(false)}
          onChange={item => {
            setType(item.value);
            setIsFocus(false);
          }}
        />
        <TouchableOpacity
          onPress={() => handleStart(category)}
          style={[styles.button, { backgroundColor: category.color }]}>
          <Text style={styles.button_title}>Start</Text>
        </TouchableOpacity>
      </View>
    </View>
  );
};

export default DropdownComponent;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 16,
    justifyContent: "center",
    alignContent: "center",
    borderRadius: 20
  },
  dropdown: {
    height: 50,
    borderColor: 'gray',
    borderWidth: 0.5,
    borderRadius: 8,
    paddingHorizontal: 8,
    marginBottom: 50
  },
  icon: {
    marginRight: 5,
  },
  label: {
    position: 'absolute',
    backgroundColor: 'white',
    left: 22,
    top: 8,
    zIndex: 999,
    paddingHorizontal: 8,
    fontSize: 14,
  },
  placeholderStyle: {
    fontSize: 16,
  },
  selectedTextStyle: {
    fontSize: 16,
  },
  iconStyle: {
    width: 20,
    height: 20,
  },
  inputSearchStyle: {
    height: 40,
    fontSize: 16,
  },
  button: {
    paddingVertical: 20,
    borderRadius: 10
  },
  button_title: {
    color: "white",
    textAlign: "center",
    fontSize: 20,
    fontWeight: "bold"
  }
});