import { ObjectID } from "mongodb";
import { db } from "../db.js";

export const deleteIngredient = async (ingredientName, mealId) => {
  const connection = await db.getConnection();
  const collection = await connection.collection("meals");

  const query = { _id: ObjectID(mealId) };
  await collection.updateOne(query, {
    $pull: { ingredients: { name: ingredientName } },
  });
};
