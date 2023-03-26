import { Link } from "react-router-dom";
import { MealsListItem } from "./MealsListItem";
import React from "react";

export const MealsList = ({ isLoading, meals, setMeals }) => {
  const onDeleteMeal = async (id) => {
    const response = await fetch(`/meals?id=${id}`, { method: 'DELETE'});
    const updatedMeals = await response.json();
    setMeals(updatedMeals);
  };

  return (
    <div className="list-container">
      <h1>Meals</h1>
      {isLoading ? (
        <p>Loading...</p>
      ) : (
        meals.map((meal) => {
          return (
            <MealsListItem
              key={meal._id}
              meal={meal}
              onDeleteMeal={onDeleteMeal}
            />
          );
        })
      )}
      <div>
        <Link to={"/add-meal"}>
          <button>Add</button>
        </Link>
      </div>
    </div>
  );
};
