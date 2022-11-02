import React from 'react';
import {SafeAreaView, Text, FlatList, StyleSheet} from 'react-native';
import productData from './product-data.json';
import ProductCard from './components/ProductCard';
import SearchBar from './components/SearchBox';


const App = () => {
  const renderItem = ({item}) => <ProductCard product={item} />;

  const keyEx = item => item.id.toString();
  // render
  return (
    <SafeAreaView style={style.container}>
      <Text style={style.headerText}>STORE APP</Text>
      <SearchBar />
      <FlatList
        //ListHeaderComponent={SearchBar}
        data={productData}
        horizontal={false}
        numColumns={2}
        renderItem={renderItem}
        keyExtractor={keyEx}
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