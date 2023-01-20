import React, { useState, useEffect } from "react";
import auth from "@react-native-firebase/auth"


export function useAuth() {
    const [user, setUser] = useState()

    useEffect(() => {
        auth().onAuthStateChanged(user => {
            if (user) {
                setUser(user)
            } else {
                setUser(undefined)
            }
        })
    }, [])

    return {
        user
    }

}