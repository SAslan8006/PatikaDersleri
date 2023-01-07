import React, { useState } from "react";

export const ChatRoomContext = React.createContext();

const ChatRoomContextProvider = (props) => {
    const [roomTitle, setRoomTitle] = useState("");

    const methods = {
        roomTitle, setRoomTitle
    }

    return (
        <ChatRoomContext.Provider value={methods}>
            {props.children}
        </ChatRoomContext.Provider>
    )
}

export default ChatRoomContextProvider;