
import React, {useState} from 'react';
import {  Button,  SafeAreaView,  ScrollView,  StatusBar, FlatList, Switch,  StyleSheet,  Text,  useColorScheme,  View,} from 'react-native';

const data = [
    {id: 0, name: 'Süleyman', isFavorite: true},
    {id: 1, name: 'John Tom', isFavorite: false},
    {id: 2, name: 'Jane', isFavorite: true},
    {id: 3, name: 'Liam', isFavorite: false},
    {id: 4, name: 'Noah', isFavorite: true},
    {id: 5, name: 'Jack', isFavorite: false},
  ];

  function App () {

    const[showOnlyFavorites,setShowOnlyFaworites]=useState(false);
    const [cafeList,setCafeList]=useState(data);

    function onFavoritesChange(isFavoriteSelected) {
        setShowOnlyFaworites(isFavoriteSelected);
        isFavoriteSelected? setCafeList( cafeList.filter(cafe =>cafe.isFavorite)):setCafeList(data)
    }

  return (
    <SafeAreaView >
        <View style={{margin:10}}>
        <Text>Show Only Favorites</Text>
        <Switch value={showOnlyFavorites} onValueChange={onFavoritesChange} />
    </View>
        <FlatList data={cafeList} renderItem={({item})=><Text>{item.name}</Text>}/>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  sectionContainer: {
    marginTop: 32,
    paddingHorizontal: 24,
    fontSize: 34,
    fontWeight: '600',
  },
  
});

export default App;
