import { deleteIngredient, getMeals } from "../../db/index.js";

export const deleteIngredientRoute = {
    method: 'delete',
    path: '/ingredients',
    handler: async (req, res) => {
        const ingredientName = req.query.name;
        const mealId = req.query.id;

        await deleteIngredient(ingredientName, mealId);
        
        const updatedMeals = await getMeals();
        res.status(200).json(updatedMeals);
    },

};
