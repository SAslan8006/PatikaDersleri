import { addIngredientsRoute } from './ingredients/addIngredientsRoute.js';
import { addMealRoute } from './meals/addMealRoute.js';
import { deleteIngredientRoute } from './ingredients/deleteIngredientRoute.js';
import { deleteMealRoute } from './meals/deleteMealRoute.js';
import { getMealsRoute } from './meals/getMealsRoute.js';

export const routes = [
    getMealsRoute,
    addMealRoute,
    deleteMealRoute,
    addIngredientsRoute,
    deleteIngredientRoute
]