import React from 'react'
import Router from './Router'
import FavProvider from './context/FavProvider'

export default () => {
    return (
        <FavProvider>
            <Router />
        </FavProvider>
    )
}