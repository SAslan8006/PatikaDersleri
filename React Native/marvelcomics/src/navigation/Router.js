import React from 'react'
import { useAuth } from '../hooks/useAuth'
import AuthStack from './AuthStack'
import MainStack from './MainStack'

const Router = () => {
  const { user } = useAuth()
  return user ? <MainStack /> : <AuthStack />
}

export default Router
