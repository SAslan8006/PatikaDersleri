import { BackButton, Dropdown } from "../ui-common";
import React, { useState } from "react";

import { generate } from "shortid";
import { produce } from "immer";
import { useHistory } from "react-router-dom";

const unitOptions = ["pounds", "cups", "tablespoon", "teaspoon", "count"];

export const AddMealPage = () => {
  const [name, setName] = useState("");
  const [imageURL, setImageURL] = useState("");
  const history = useHistory();
  const [ingredients, setIngredients] = useState([]);

  const addMeal = async () => {
    const newMeal = { name: name.toLowerCase(), ingredients, imageURL };
    await fetch(`/meals`, {
      method: "POST",
      body: JSON.stringify(newMeal),
      headers: { "Content-Type": "application/json" },
    })
      .then(() => {
        alert("Meal Successfully Added!");
        history.push("/");
      })
      .catch((err) => {
        console.log(err);
      });
  };

  return (
    <div className="page">
      <BackButton />
      <div className="centered-container">
        <h1>Add Meal</h1>
        <input
          type="text"
          placeholder="Add Meal Name Here"
          className="space-after space-before full-width"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
        <input
          type="text"
          placeholder="Add Meal Image URL Here"
          className="space-after space-before full-width"
          value={imageURL}
          onChange={(e) => setImageURL(e.target.value)}
        />

        <button
          className="space-before full-width"
          onClick={(e) => {
            setIngredients((currentIngredient) => [
              ...currentIngredient,
              {
                id: generate(),
                name: "",
                type: "",
                quantity: 0,
              },
            ]);
          }}
        >
          Add new ingredient
        </button>
        {ingredients.map((ingredient, index) => {
          return (
            <div key={ingredient.id}>
              <input
                className="space-before full-width"
                placeholder="Ingredient Name"
                value={ingredient.name}
                onChange={(e) => {
                  const name = e.target.value;
                  setIngredients((ingredients) =>
                    produce(ingredients, (v) => {
                      v[index].name = name;
                    })
                  );
                }}
              />
              <input
                className="space-before full-width"
                type="number"
                placeholder="Amount"
                value={ingredient.quantity}
                onChange={(e) => {
                  const quantity = e.target.value;
                  setIngredients((ingredients) =>
                    produce(ingredients, (v) => {
                      v[index].quantity = quantity;
                    })
                  );
                }}
              />
              <Dropdown
                className="space-before full-width"
                options={unitOptions}
                onChange={(e) => {
                  const type = e.target.value;
                  setIngredients((ingredients) =>
                    produce(ingredients, (v) => {
                      v[index].type = type;
                    })
                  );
                }}
              />
              <button
                onClick={() => {
                  setIngredients((currentIngredient) =>
                    currentIngredient.filter((x) => x.id !== ingredient.id)
                  );
                }}
              >
                Remove
              </button>
            </div>
          );
        })}
        <button className="space-before full-width" onClick={addMeal}>
          Save Meal
        </button>
      </div>
    </div>
  );
};
