import { ObjectID } from "mongodb";
import { db } from "../db.js";

export const deleteMeal = async (mealId) => {
  const connection = await db.getConnection();
  await connection.collection("meals").deleteOne({ _id: ObjectID(mealId) });
};
