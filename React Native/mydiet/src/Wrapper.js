import React from 'react'
import Router from './Router'
import UserInfoContextProvider from './context/UserInfoContext'
import FoodValueContextProvider from './context/FoodValueContext'

export default () => {
    return (
        <UserInfoContextProvider>
            <FoodValueContextProvider>
                <Router />
            </FoodValueContextProvider>
        </UserInfoContextProvider>
    )
}

