import React from "react"
import { createStackNavigator } from '@react-navigation/stack';
import SignIn from '../screens/auth/SignIn/SignIn'
import SignUp from '../screens/auth/SignUp/SignUp'

const Stack = createStackNavigator();

const AuthStack = () => {
  return (
    <Stack.Navigator screenOptions={{
      headerShown: false
    }}>
      <Stack.Screen name="SignInScreen" component={SignIn} />
      <Stack.Screen name="SignUpScreen" component={SignUp} />
    </Stack.Navigator>
  );
}
export default AuthStack