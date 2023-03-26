import { MealsList, useMeals } from "../meals";

import { IngredientList } from "../ingredients";
import React from "react";
import { StepList } from "../steps";

export const HomePage = () => {
  const { meals, setMeals, isLoading: isLoadingMeals } = useMeals();

  return (
    <div className="page-container">
      <div className="column">
        <MealsList
          isLoading={isLoadingMeals}
          meals={meals}
          setMeals={setMeals}
        />
      </div>
      <div className="column">
        <IngredientList />
      </div>
      <div className="column">
        <StepList />
      </div>
    </div>
  );
};
