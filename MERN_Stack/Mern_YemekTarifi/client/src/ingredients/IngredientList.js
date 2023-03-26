import React, { useContext } from "react";

import { IngredientsListItem } from "./IngredientsListItem";
import { Link } from "react-router-dom";
import { MealContext } from "../MealContext";

export const IngredientList = () => {
  const { selectedMeal, setSelectedMeal } = useContext(MealContext);

  const onDeleteIngredient = async (name) => {
    const response = await fetch(
      `/ingredients?id=${selectedMeal._id}&name=${name}`,
      { method: "DELETE" }
    );
    const updatedMeals = await response.json();
    const updatedMeal = updatedMeals.filter(
      (meal) => meal._id === selectedMeal._id
    );

    setSelectedMeal(updatedMeal[0]);
  };

  console.log(selectedMeal);

  return (
    <div className="list-container">
      <h1>Ingredients</h1>
      {selectedMeal ? (
        selectedMeal.ingredients.map((ingredient) => {
          return (
            <IngredientsListItem
              key={Math.random()}
              ingredientItem={ingredient}
              onDeleteIngredient={onDeleteIngredient}
            />
          );
        })
      ) : (
        <p>No Ingredients Found or No Meal Selected</p>
      )}
      {selectedMeal ? (
        <div>
          <Link to={`/add-ingredient?mealId=${selectedMeal._id}`}>
            <button>Add</button>
          </Link>
        </div>
      ) : (
        <></>
      )}
    </div>
  );
};
