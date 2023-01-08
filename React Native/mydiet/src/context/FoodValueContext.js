import React, { useState } from "react";

export const FoodValueContext = React.createContext();

const FoodValueContextProvider = (props) => {
    const [foodValue, setFoodValue] = useState([])
    const [breakfastValue, setBreakfastValue] = useState([])
    const [lunchValue, setLunchValue] = useState([])
    const [dinnerValue, setDinnerValue] = useState([])
    const [totalCountFood, setTotalCountFood] = useState([])
    const [countTotal, setCountTotal] = useState(0)

    const [breakFat, setBreakFat] = useState(0)
    const [breakPro, setBreakPro] = useState(0)
    const [breakCarb, setBreakCarb] = useState(0)
    const [breakTgd, setBreakTgd] = useState(0)
    const [breakCalori, setBreakCalori] = useState(0)

    const [dinnerFat, setDinnerFat] = useState(0)
    const [dinnerPro, setDinnerPro] = useState(0)
    const [dinnerCarb, setDinnerCarb] = useState(0)
    const [dinnerTgd, setDinnerTgd] = useState(0)
    const [dinnerCalori, setDinnerCalori] = useState(0)

    const [lunchFat, setLunchFat] = useState(0)
    const [lunchPro, setLunchPro] = useState(0)
    const [lunchCarb, setLunchCarb] = useState(0)
    const [lunchTgd, setLunchTgd] = useState(0)
    const [lunchCalori, setLunchCalori] = useState(0)

    const methods = {
        foodValue, setFoodValue, breakFat, setBreakFat, breakPro, setBreakPro, breakCarb,
        setBreakCarb, breakTgd, setBreakTgd, breakCalori, setBreakCalori, breakfastValue,
        dinnerFat, setDinnerFat, dinnerPro, setDinnerPro, dinnerCarb, setDinnerCarb, dinnerTgd,
        setDinnerTgd, dinnerCalori, setDinnerCalori,
        lunchFat, setLunchFat, lunchPro, setLunchPro, lunchCarb, setLunchCarb, lunchTgd,
        setLunchTgd, lunchCalori, setLunchCalori, breakfastValue, lunchValue, dinnerValue, setBreakfastValue,
        setLunchValue, setDinnerValue, totalCountFood, setTotalCountFood, countTotal, setCountTotal
    }

    return (
        <FoodValueContext.Provider value={methods}>
            {props.children}
        </FoodValueContext.Provider>
    )
}

export default FoodValueContextProvider;