import React from 'react'
import Router from './Router'
import UserInfoContextProvider from './context/UserInfoContext'
import BookContextProvider from './context/BookContext'



export default () => {
    return (
        <UserInfoContextProvider>
            <BookContextProvider>
                <Router />
            </BookContextProvider>
        </UserInfoContextProvider>
    )
}