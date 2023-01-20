import React from 'react'
import Router from './navigation/Router'
import CharactersContextProvider from './context/CharactersContext'

const Wrapper = () => {
    return (
       <CharactersContextProvider>
              <Router />
       </CharactersContextProvider>
       )
}

export default Wrapper
