import React, { useContext } from "react";

import { Link } from "react-router-dom";
import { MealContext } from "../MealContext";
import { StepListItem } from "./StepListItem";

export const StepList = () => {
  const { selectedMeal } = useContext(MealContext);

  return (
    <div className="list-container">
      <h1>Steps</h1>

      {selectedMeal && selectedMeal.steps ? (
        selectedMeal.steps.map((step) => {
          return <StepListItem key={Math.random()} stepItem={step} />;
        })
      ) : (
        <p>No Step Found</p>
      )}

      {selectedMeal && selectedMeal.steps ? (
        <div>
          <Link to={`/add-step`}>
            <button>Add</button>
          </Link>
        </div>
      ) : (
        <></>
      )}
    </div>
  );
};
