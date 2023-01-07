import * as React from 'react';
import Router from './Router'
import ChatRoomContextProvider from './context/ChatRoomContext'

export default () => {
    return (
        <ChatRoomContextProvider>
            <Router />
        </ChatRoomContextProvider>
    )
}