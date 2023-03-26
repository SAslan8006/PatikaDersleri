import {addMeal, getMeals} from '../../db/index.js';

export const addMealRoute = {
    method: 'post',
    path: '/meals',
    handler: async (req, res) => {
        const meal = req.body;
        await addMeal(meal);
        const updatedMeals = await getMeals();
        res.status(200).json(updatedMeals);
    }
};
