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
