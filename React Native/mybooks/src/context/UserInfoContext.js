import React, { useState, useEffect } from 'react'
import database from "@react-native-firebase/database"
import parseContentData from '../utils/parseContentData'
export const UserInfoContext = React.createContext();

const UserInfoContextProvider = (props) => {
    const [userInfo, setUserInfo] = useState([])
    const [userMail, setUserMail] = useState("")
    const [backgroundProfileImageChange, setBackgroundProfileImage] = useState("")
    const [profileImageChange, setProfileImage] = useState("")
    const [totalUserWallBook, setTotalUserWallBook] = useState([])

    useEffect(() => {
        database().ref('users/').on('value', snapshot => {
            const contentData = snapshot.val();
            const parsedData = parseContentData(contentData || {})
            for (var i = 0; i < parsedData.length; i++) {
                if (parsedData[i].email === userMail) {
                    setTotalUserWallBook(parsedData)
                    userInfo[0] = parsedData[i]
                    setBackgroundProfileImage(parsedData[i].backgroundProfileImage)
                    setProfileImage(parsedData[i].profileImage)

                }
            }
        })

    }, [userMail])





    const handlefollowedUser = (followUser) => {

        handleFollow(followUser)
        handlefollower(followUser)
    }

    const handleFollow = (followed) => {
        const [{ id }] = userInfo
        const [followedUser] = followed
        const newReference = database().ref(`users/${id}/followeds`).push();
        newReference
            .set({ followedUser, followed: true })
            .then(() => console.log('Data updated.'));
    }
    const handlefollower = (follower) => {
        const [followerUser] = userInfo
        const newReference = database().ref(`users/${follower[0].id}/followers`).push();
        newReference
            .set({ followerUser })
            .then(() => console.log('Data updated.'));
    }


    const methods = {
        userInfo, handlefollowedUser, setUserInfo, userMail, setUserMail,
        backgroundProfileImageChange, setBackgroundProfileImage, profileImageChange, setProfileImage,
        totalUserWallBook

    }

    return (
        <UserInfoContext.Provider value={methods}>
            {props.children}
        </UserInfoContext.Provider>
    )
}

export default UserInfoContextProvider;