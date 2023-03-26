import { BackButton, Dropdown } from "../ui-common";
import React, { useContext, useState } from "react";

import { MealContext } from "../MealContext";
import { useHistory } from "react-router-dom";
import { useLocation } from "react-router-dom";

const unitOptions = ["pounds", "cups", "tablespoon", "teaspoon", "count"];

export const AddIngredientPage = () => {
  const [name, setName] = useState("");
  const [quantity, setQuantity] = useState(0);
  const [unit, setUnit] = useState(unitOptions[0]);
  const history = useHistory();
  const id = new URLSearchParams(useLocation().search).get("mealId");

  const { selectedMeal, setSelectedMeal } = useContext(MealContext);

  const addToIngredients = async () => {
    const newIngredient = { name: name.toLowerCase(), quantity, unit };

    await fetch(`ingredients?id=${id}`, {
      method: "POST",
      body: JSON.stringify(newIngredient),
      headers: {
        "Content-Type": "application/json",
      },
    }).then(()=>{
        selectedMeal.ingredients.push(newIngredient);
        alert("Successfully added ingreditn");
        history.push('/');
    }).catch((error) => {
        console.log(error);
    });
  };

  return (
    <div className="page">
      <BackButton />
      <div className="centered-container">
        <h1>Add Ingredient</h1>
        <input
          type="text"
          placeholder="Add ingredient name here"
          className="space-after space-before full-width"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
        <input
          type="number"
          placeholder="Add ingredient name here"
          className="space-before full-width"
          value={quantity}
          onChange={(e) => setQuantity(e.target.value)}
        />
        <Dropdown
          className="space-before full-width"
          onChange={(e) => setUnit(e.target.value)}
          options={unitOptions}
        />
        <button className="space-before full-width" onClick={addToIngredients}>
          Add
        </button>
      </div>
    </div>
  );
};
