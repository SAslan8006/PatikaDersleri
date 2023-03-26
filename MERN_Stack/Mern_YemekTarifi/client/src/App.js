import "./App.css";

import React, { useMemo, useState } from "react";

import { MealContext } from "./MealContext";
import { Routes } from "./Routes";

function App() {
  const [selectedMeal, setSelectedMeal] = useState(null);
  const value = useMemo(
    () => ({ selectedMeal, setSelectedMeal }),
    [selectedMeal, setSelectedMeal]
  );

  return (
    <div className="App">
      <MealContext.Provider value={value}>
        <Routes />
      </MealContext.Provider>
    </div>
  );
}

export default App;
