import React, { useState, useEffect, useContext } from 'react';
import { Text, View } from 'react-native';
import { NavigationContainer } from '@react-navigation/native';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import auth from "@react-native-firebase/auth"
import FlashMessage from "react-native-flash-message";
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
import Home from './pages/Home';
import Comment from './pages/Comment';
import UserInfo from './pages/UserInfo';
import Login from './pages/auth/Login';
import Sign from './pages/auth/Sign';
import SearchBook from './pages/SearchBook';
import Book from './pages/Book';
import { UserInfoContext } from './context/UserInfoContext';
import UserValues from './pages/UserInfo/UserValues';
import ShowSelectUser from './pages/UserInfo/ShowSelectUser';
import SendComment from './pages/SendComment';

const Stack = createNativeStackNavigator();
const Tab = createBottomTabNavigator();

export default function App() {
  const [userSession, setUserSession] = useState()
  const { setUserMail } = useContext(UserInfoContext)
  useEffect(() => {
    auth().onAuthStateChanged(user => {
      setUserSession(!!user)
      setUserMail(user?.email)
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

  const HomeStack = () => {
    return (
      <Stack.Navigator screenOptions={{ headerShown: false }}>
        <Stack.Screen name="HomePage" component={Home} />
        <Stack.Screen name="SearchBookPage" component={SearchBook} />
        <Stack.Screen name="SelectedBookPage" component={Book} />
      </Stack.Navigator>
    )
  }

  const UserInfoStack = () => {
    return (
      <Stack.Navigator >
        <Stack.Screen name="UserInfoPage" component={UserInfo} options={{ headerShown: false }} />

        <Stack.Screen name="UserValuesPage" component={UserValues} options={{ headerShown: false }} />

        <Stack.Screen name="ShowSelectUserPage" component={ShowSelectUser} options={{ headerShown: false }} />
      </Stack.Navigator>
    )
  }

  const MainStack = () => {
    return (
      <Tab.Navigator screenOptions={{ headerShown: false }}>
        <Tab.Screen name="HomeStack" component={HomeStack}
          options={{
            tabBarActiveBackgroundColor: "#f5f5f5",
            title: "",
            tabBarIcon: ({ tintColor }) => (
              <Icon name="home-outline" size={30} color="black" />
            )
          }}
        />
        <Tab.Screen name="CommentPage" component={Comment}
          options={{
            tabBarActiveBackgroundColor: "#f5f5f5",
            title: "",
            tabBarIcon: ({ tintColor }) => (
              <Icon name="plus" size={30} color="black" />
            )
          }}
        />
        <Tab.Screen name="UserInfoStack" component={UserInfoStack}
          options={{
            tabBarActiveBackgroundColor: "#f5f5f5",
            title: "",
            tabBarIcon: ({ tintColor }) => (
              <Icon name="account-circle-outline" size={30} color="black" />
            )
          }}
        />
      </Tab.Navigator>
    );
  }
  return (
    <NavigationContainer>
      <Stack.Navigator >
        {!userSession ?
          <Stack.Screen name="AuthStack" component={AuthStack} options={{ headerShown: false }} />
          :
          <>
            <Stack.Screen name="MainStack" component={MainStack} options={{ headerShown: false }} />
            <Stack.Screen name="SendCommentPage" component={SendComment}
              options={{
                title: "Gönderi",
                headerTitleAlign: 'center',

              }}
            />
          </>
        }

      </Stack.Navigator>
      <FlashMessage position="top" />
    </NavigationContainer>

  );


}
