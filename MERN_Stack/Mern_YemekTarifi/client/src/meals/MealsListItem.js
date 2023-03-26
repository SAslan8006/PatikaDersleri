import React, { useContext } from "react";

import { ButtonX } from "../ui-common";
import { MealContext } from "../MealContext";

export const MealsListItem = ({ meal, onDeleteMeal }) => {
  const { setSelectedMeal } = useContext(MealContext);

  return (
    <>
      <div className="list-item">
        {meal ? (
          <>
            <img src={meal.imageURL} height={100} width={100} />
            <h3>{meal.name}</h3>
            <button
              className="arrow-button"
              onClick={() => setSelectedMeal(meal)}
            >
              ->
            </button>
            <div className="right-action">
              <ButtonX
                onClick={() => {
                  onDeleteMeal(meal._id);
                  setSelectedMeal(null);
                }}
              />
            </div>
          </>
        ) : (
          <>
            <h3>No Meal</h3>
          </>
        )}
      </div>
    </>
  );
};
