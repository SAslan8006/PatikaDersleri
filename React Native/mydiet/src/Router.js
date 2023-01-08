import React, { useState, useEffect, useContext } from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import auth from "@react-native-firebase/auth"
import database from "@react-native-firebase/database"
import FlashMessage from "react-native-flash-message";
import UserInfo from './pages/UserInfo';
import StartedInfo from './pages/StartedSetting/StartedInfo';
import StartedGender from './pages/StartedSetting/StartedGender';
import StartedLevel from './pages/StartedSetting/StartedLevel';
import StartedWeight from './pages/StartedSetting/StartedWeight';
import StartedHeight from './pages/StartedSetting/StartedHeight';
import StartedAge from './pages/StartedSetting/StartedAge';
import colors from './styles/colors';
import Login from './pages/auth/Login';
import Sign from './pages/auth/Sign/Sign';
import parseContentData from './utils/parseContentData';
import Daily from './pages/DailyMain/Daily';
import Icon from 'react-native-vector-icons/MaterialIcons';
import FoodInfo from './pages/DailyMain/FoodInfo/FoodInfo';
import SelectedFood from './pages/DailyMain/SelectedFood/SelectedFood';
import Rapors from './pages/Rapors';


const Stack = createNativeStackNavigator();
const Tab = createBottomTabNavigator();


export default function App() {
  const [userSession, setUserSession] = useState()
  const [userInfo, setUserInfo] = useState()


  useEffect(() => {
    auth().onAuthStateChanged(user => {
      setUserSession(!!user)

    })
  }, [])

  useEffect(() => {
    database()
      .ref('/userinfo')
      .on('value', snapshot => {
        const userInfoData = snapshot.val();
        const parsedInfoData = parseContentData(userInfoData || {})
        setUserInfo(parsedInfoData)

      });
  }, [])

  const AuthStack = () => {
    return (
      <Stack.Navigator screenOptions={{ headerShown: false }}>
        <Stack.Screen name="LoginPage" component={Login} />
        <Stack.Screen name="SignPage" component={Sign} />
      </Stack.Navigator>
    )
  }

  function StartedPage() {
    return (
      <Stack.Navigator >
        <Stack.Screen name="StartedInfo" component={StartedInfo} options={{ headerShown: false }} />
        <Stack.Screen name="StartedGender" component={StartedGender}
          options={{
            headerTintColor: "white",
            headerStyle: { backgroundColor: colors.darkGreen },
            headerTitle: "",
          }} />
        <Stack.Screen name="StartedLevel" component={StartedLevel}
          options={{
            headerTintColor: "white",
            headerStyle: { backgroundColor: colors.darkGreen },
            headerTitle: "",
          }}
        />
        <Stack.Screen name="StartedWeight" component={StartedWeight}
          options={{
            headerTintColor: "white",
            headerStyle: { backgroundColor: colors.darkGreen },
            headerTitle: "",
          }}
        />
        <Stack.Screen name="StartedHeight" component={StartedHeight}
          options={{
            headerTintColor: "white",
            headerStyle: { backgroundColor: colors.darkGreen },
            headerTitle: "",
          }}
        />
        <Stack.Screen name="StartedAge" component={StartedAge}
          options={{
            headerTintColor: "white",
            headerStyle: { backgroundColor: colors.darkGreen },
            headerTitle: "",
          }}
        />
      </Stack.Navigator>
    );
  }

  const DailyStack = () => {
    return (
      <Stack.Navigator >
        <Stack.Screen name="DailyMain" component={Daily} options={{ headerShown: false }} />
        <Stack.Screen name="selectFoodPage" component={SelectedFood} options={{ headerShown: false }} />
        <Stack.Screen name="FoodInfoPage" component={FoodInfo}
          options={{
            headerTintColor: colors.darkGreen,
            headerTitle: ""
          }}
        />
      </Stack.Navigator>
    )
  }


  function HomePage() {
    return (

      <Tab.Navigator screenOptions={{ headerShown: false }}>
        <Tab.Screen name="Ben" component={UserInfo}
          options={{
            tabBarActiveBackgroundColor: colors.tabColor,
            tabBarActiveTintColor: colors.darkGreen,
            tabBarIcon: ({ tintColor }) => (
              <Icon name="supervised-user-circle" size={30} color="gray" />
            )
          }} />
        <Tab.Screen name="Daily" component={DailyStack}
          options={{
            tabBarActiveBackgroundColor: colors.tabColor,
            tabBarActiveTintColor: colors.darkGreen,
            tabBarIcon: ({ tintColor }) => (
              <Icon name="food-bank" size={30} color="gray" />
            )
          }}

        />
        <Tab.Screen name="Raporlar" component={Rapors}
          options={{
            tabBarActiveBackgroundColor: colors.tabColor,
            tabBarActiveTintColor: colors.darkGreen,
            tabBarIcon: ({ tintColor }) => (
              <Icon name="insert-chart-outlined" size={30} color="gray" />
            )
          }}
        />
      </Tab.Navigator>
    )
  }

  const MainStack = () => {
    return (
      <Stack.Navigator screenOptions={{ headerShown: false }}>

        {
          userInfo && userInfo.length == 0 ? (<Stack.Screen name="StartedPage" component={StartedPage} />)
            : (<Stack.Screen name="HomePage" component={HomePage} />)
        }

      </Stack.Navigator>
    )
  }


  return (
    <NavigationContainer>
      <Stack.Navigator screenOptions={{ headerShown: false }}>
        {!userSession ?
          <Stack.Screen name="AuthStack" component={AuthStack} /> : (
            <Stack.Screen name="MainStack" component={MainStack} />)
        }
      </Stack.Navigator>
      <FlashMessage position="top" />
    </NavigationContainer>

  );
}
