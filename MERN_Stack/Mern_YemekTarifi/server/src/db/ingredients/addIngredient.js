import { ObjectID } from "mongodb";
import { db } from "../db.js";

export const addIngredient = async (ingredient, mealId) => {
  const connection = await db.getConnection();
  const collection = await connection.collection("meals");
  const query = { _id: ObjectID(mealId) };

  const updateDocument = {
    $push: {
      ingredients: ingredient,
    },
  };

  await collection.updateOne(query, updateDocument, (err, res) => {
    if (err) {
      console.log(err);
    } else {
      console.log(res);
    }
  });
};
