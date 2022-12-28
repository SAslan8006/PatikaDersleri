# State yapısı örnekleri
### Sayaç örneği
```JS
import React, { useState } from 'react'
import { Text, TouchableOpacity, View, } from 'react-native'
import { styles } from './styles';


export default SayacIleStateKavramıScreen = () => {

    const [sayi, setSayi] = useState(0);

    return (
        <View style = {{flex: 1, alignItems: 'center', justifyContent: 'center'}}>
            <TouchableOpacity
            onPress = {() => {
                setSayi(sayi + 1);
            }}
              style={{
                  alignItems: 'center',
                  justifyContent: 'center',
                  backgroundColor: '#0f0',
                  padding: 5,
                  width: 50,
                  height: 50,
                  borderRadius: 50,
                  margin: 10,
              }}>
            <Text style={styles.textStyle2}>+</Text>
            </TouchableOpacity>
            <Text style = {styles.textStyle2}>{sayi}</Text>
            <TouchableOpacity
            onPress = {() => {
                setSayi(sayi - 1);
                console.log(sayi);
            }}
              style = {{
                  alignItems: 'center',
                  justifyContent: 'center',
                  backgroundColor: '#0f0',
                  padding: 5,
                  width: 50,
                  height: 50,
                  borderRadius: 50,
                  margin: 10
              }}>
                <Text style = {styles.textStyle2}>-</Text>
            </TouchableOpacity>
        </View>
    );
};
```
### State Cafeler Örneği
```JS

import React, { useState } from 'react';
import { FlatList, SafeAreaView, Switch, Text, View } from 'react-native';



const data = [
    { id: 0, name: 'cafe.exe', isFavorite: 'true' },
    { id: 1, name: 'Cafecafe', isFavorite: 'false' },
    { id: 2, name: 'BugG', isFavorite: 'true' },
    { id: 3, name: 'Rock.code', isFavorite: 'false' },
    { id: 4, name: 'Do.Drink', isFavorite: 'false' },
    { id: 5, name: 'Esc.esc', isFavorite: 'true' },
];

function CafeListWithStateKullanım() {

    const [cafeList, setCafeList] = useState(data);
    const [showOnlyFavorites, setShowOnlyFavorites] = useState(false);


    function onFavoritesChange(isFavoriteSelected) {

        setShowOnlyFavorites(isFavoriteSelected);
        isFavoriteSelected
            ? setCafeList(cafeList.filter(cafe => cafe.isFavorite))
            : setCafeList(data);
    }

    return (
        <SafeAreaView>
            <View style={{ flexDirection: 'row', justifyContent: 'space-between', margin: 20 }}>
                <Text>Show Only Favorites</Text>
                <Switch
                    trackColor={{ false: '#767577', true: '#81b0ff' }}
                    value={showOnlyFavorites}
                    onValueChange={onFavoritesChange}
                ></Switch>
            </View>
            <FlatList
                data={cafeList}
                renderItem={({ item }) => <Text style={{
                    fontSize: 20, backgroundColor: '#81b0ff',
                    margin: 10, borderRadius: 20, textAlign: 'center'
                }}>{item.name}</Text>}
            ></FlatList>

        </SafeAreaView>
    )
}

export default CafeListWithStateKullanım;
```
