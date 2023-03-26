import { ButtonX } from "../ui-common";
import React from "react";

export const IngredientsListItem = ({ ingredientItem, onDeleteIngredient }) => {
  return (
    <>
      <div className="list-item">
        {ingredientItem ? (
          <>
            <h3>{ingredientItem.name}</h3>

            <h5>{ingredientItem.quantity}</h5>
            <div className="right-action">
              <ButtonX
                onClick={() => onDeleteIngredient(ingredientItem.name)}
              />
            </div>
          </>
        ) : (
          <>
            <h3>No Ingredient Found</h3>
          </>
        )}
      </div>
    </>
  );
};
