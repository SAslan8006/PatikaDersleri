import React from 'react'
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import FlashMessage from "react-native-flash-message";
import Login from '../screens/auth/Login'
import Sign from '../screens/auth/Sign'

const Stack = createNativeStackNavigator();
export default function AuthStack() {
    return (
        <NavigationContainer>
            <Stack.Navigator screenOptions={{ headerShown: false }}>
                <Stack.Screen name="LoginPage" component={Login} />
                <Stack.Screen name="SignPage" component={Sign} />
            </Stack.Navigator>
            <FlashMessage position="top" />
        </NavigationContainer>
    )
}


