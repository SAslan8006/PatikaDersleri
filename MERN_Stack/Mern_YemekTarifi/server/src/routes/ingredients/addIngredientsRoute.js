import {addIngredient, getMeals} from "../../db/index.js"

export const addIngredientsRoute = {
  method: "post",
  path: "/ingredients",
  handler: async (req, res) => {
    const ingredient = req.body;
    const mealId = req.query.id;

    await addIngredient(ingredient, mealId);
    
    const updatedMeals = await getMeals();
    res.status(200).json(updatedMeals);
  },
};
