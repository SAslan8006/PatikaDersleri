import React, { useState, useEffect, useContext } from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import auth from "@react-native-firebase/auth"
import FlashMessage from "react-native-flash-message";
import Login from './pages/auth/Login';
import Sign from './pages/auth/Sign';
import ChatRooms from './pages/ChatRooms';
import colors from './styles/colors';
import ChatRoomDetail from './pages/ChatRoomDetail/ChatRoomDetail';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import { ChatRoomContext } from './context/ChatRoomContext';


const Stack = createNativeStackNavigator();

function Router() {
  const [userSession, setUserSession] = useState()

  const { roomTitle } = useContext(ChatRoomContext)
  useEffect(() => {
    auth().onAuthStateChanged(user => {
      setUserSession(!!user)
    })
  }, [])


  const AuthStack = () => {
    return (
      <Stack.Navigator screenOptions={{ headerShown: false }}>
        <Stack.Screen name="LoginPage" component={Login} />
        <Stack.Screen name="SignPage" component={Sign} />
      </Stack.Navigator>
    )
  }
  const MainStack = () => {
    return (
      <Stack.Navigator>
        <Stack.Screen name="Rooms" component={ChatRooms}
          options={{
            title: "Odalar",
            headerTitleAlign: "center",
            headerTitleStyle: { color: colors.primaryColor },

          }}
        />
        <Stack.Screen name="ChatRoomDetail" component={ChatRoomDetail}
          options={{
            title: roomTitle,
            headerTitleAlign: "center",
            headerTintColor: colors.primaryColor,
            headerTitleStyle: { color: colors.primaryColor },
            headerRight: () => (
              <Icon name="logout" size={30} color={colors.primaryColor} onPress={() => auth().signOut()} />
            )
          }}
        />
      </Stack.Navigator>
    )
  }
  return (
    <NavigationContainer>
      <Stack.Navigator>
        {
          !userSession ? <Stack.Screen name="AuthStack" component={AuthStack} options={{ headerShown: false }} />
            : <Stack.Screen name="MainStack" component={MainStack} options={{ headerShown: false }} />
        }

      </Stack.Navigator>
      <FlashMessage position="top" />
    </NavigationContainer>
  );
}

export default Router;