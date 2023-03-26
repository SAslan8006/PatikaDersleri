import { db } from '../db.js';

export const addMeal = async (meal) => {
    const connection = await db.getConnection();
    const meals = await connection.collection('meals').insertOne(meal);
    return meals;
};
