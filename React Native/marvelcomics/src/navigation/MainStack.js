import React from 'react'
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import Home from '../screens/Home/Home';
import ShowAllItem from '../screens/ShowAllItem/ShowAllItem';
import CharacterDetail from '../screens/Characters/CharacterDetail/CharacterDetail';
import ComicsDetail from '../screens/Comics/ComicsDetail/ComicsDetail';

const Stack = createNativeStackNavigator();
export default function MainStack() {
    return (
        <NavigationContainer>
            <Stack.Navigator screenOptions={{ headerShown: false }}>
                <Stack.Screen name="Home" component={Home} />
                <Stack.Screen name="CharactersDetail" component={CharacterDetail} />
                <Stack.Screen name="ComicsDetail" component={ComicsDetail} />
                <Stack.Screen name="ShowAllItemPage" component={ShowAllItem} />
            </Stack.Navigator>
        </NavigationContainer>
    )
}
