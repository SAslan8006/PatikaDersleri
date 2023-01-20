import React, { useState } from 'react'

export const CharactersContext = React.createContext();

const CharactersContextProvider = (props) => {
    const [favoriList, setFavoriList] = useState([])


    const addFavorite = (item) => {
        setFavoriList((prev) => [...prev, item])

    }
    const removeFavorite = (item) => {
        const newFavori = [...favoriList]
        const index = favoriList.findIndex(char => char.id === item.id)
        newFavori.splice(index, 1);
        setFavoriList(newFavori)

    }

    const methods = {
        addFavorite, removeFavorite, favoriList
    }

    return (
        <CharactersContext.Provider value={methods}>
            {props.children}
        </CharactersContext.Provider>
    )
}

export default CharactersContextProvider;