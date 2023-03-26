import { deleteMeal, getMeals } from '../../db/index.js';

export const deleteMealRoute = {
    method: 'delete',
    path: '/meals',
    handler: async (req, res) => {
        const mealId = req.query.id;
        await deleteMeal(mealId);
        const updatedMeals = await getMeals();
        res.status(200).json(updatedMeals);
    },
};