import React,{useState} from 'react';
import {SafeAreaView, Text, FlatList, StyleSheet} from 'react-native';
import product_data from './product-data.json';
import ProductCard from './components/ProductCard';
import SearchBar from './components/SearchBar';


const App = () => {
  const [list,setList]=useState(product_data);
  const renderProduct= ({item})=> <ProductCard product={item} />;
  const renderSeperator= ()=> <View style={styles.seperator} />;
  const handleSearch=text =>{
    const filteredList=product_data.filter(product=>{
      const searchedText=text.toLowerCase();
      const currentTitle=product.title.toLowerCase();

      return currentTitle.indexOf(searchedText)>-1;
    });
    setList(filteredList);
  };

  return (
    <SafeAreaView style={style.container}>
      <Text style={style.headerText}>STORE APP</Text>
      <SearchBar onSearch={handleSearch} />
      <FlatList
        keyExtractor={item => item.id}
        data={list}
        horizontal={false}
        numColumns={2}
        renderItem={renderProduct}
        
      />
    </SafeAreaView>
  );
};

const style = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    padding: 10,
  },
  headerText: {
    fontSize: 40,
    color: 'purple',
    fontWeight: 'bold',
    margin: 5,
  },
});

export default App;