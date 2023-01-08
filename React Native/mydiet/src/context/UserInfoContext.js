import React, { useState } from "react";

export const UserInfoContext = React.createContext();

const UserInfoContextProvider = (props) => {
    const [userInfo, setUserInfo] = useState([])

    const feedData = {
        breakfast: {},
        lunch: {},
        dinner: {}
    }
    const methods = {
        userInfo, setUserInfo
    }

    return (
        <UserInfoContext.Provider value={methods}>
            {props.children}
        </UserInfoContext.Provider>
    )
}

export default UserInfoContextProvider;