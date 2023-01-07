import React from 'react';
import { StyleSheet } from 'react-native';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import { createDrawerNavigator } from '@react-navigation/drawer';
import Jobs from './pages/Jobs/Jobs';
import FavoritedJob from './pages/FavoritedJob';
import JobDetail from './pages/JobDetail';

const Drawer = createDrawerNavigator();

const Stack = createNativeStackNavigator();


const JobsStack = () => {
  return (
    <Stack.Navigator >
      <Stack.Screen name="JobsPage" component={Jobs}
        options={{
          title: "Jobs",
          headerStyle: { backgroundColor: "white" },
          headerTitleStyle: { color: "#EF5350" },
          headerTitleAlign: "center",
          headerTintColor: "#EF5350",

        }} />
      <Stack.Screen name="JobDetailPage" component={JobDetail}
        options={{
          title: "Detail",
          headerStyle: { backgroundColor: "white" },
          headerTitleStyle: { color: "#EF5350" },
          headerTitleAlign: "center",
          headerTintColor: "#EF5350",
        }}
      />
    </Stack.Navigator>
  )
}


const Router = () => {

  return (
    <NavigationContainer>
      <Drawer.Navigator initialRouteName="Jobs" >
        <Drawer.Screen name="Jobs" component={JobsStack}
          options={{
            drawerActiveBackgroundColor: "#FDEAEA",
            drawerActiveTintColor: "#EF5350",
            headerShown: false
          }} />
        <Drawer.Screen name="FavoritedPage" component={FavoritedJob}
          options={{
            drawerActiveBackgroundColor: "#FDEAEA",
            drawerActiveTintColor: "#EF5350",
            drawerLabel: "Favorited Jobs",
            title: "Favorited Jobs",
            headerStyle: { backgroundColor: "white" },
            headerTitleStyle: { color: "#EF5350" },
            headerTitleAlign: "center",
            headerTintColor: "#EF5350",
          }}

        />
      </Drawer.Navigator>
    </NavigationContainer>
  );
};

const styles = StyleSheet.create({

});

export default Router;