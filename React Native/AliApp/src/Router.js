import React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

import Register from './pages/Register'
import Login from './pages/Login'
import Welcome from './pages/Welcome';
import Shop from './pages/shop';

const Stack = createNativeStackNavigator();
const App  = () => {
  

  return (
    <NavigationContainer>
         <Stack.Navigator screenOptions={{ headerShown:false }}>
           <Stack.Screen name="Welcome" component={Welcome} />
           <Stack.Screen name="Register" component={Register} />
           <Stack.Screen name="Login" component={Login} />
           <Stack.Screen name="Shop" component={Shop} />
        </Stack.Navigator>
    </NavigationContainer>
  );
};


export default App;
