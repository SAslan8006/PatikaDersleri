import { List_Product_Image } from "./list_products_image";

export class List_Product {
    id: string;
    name: string;
    stock: number;
    price: number;
    createdDate: Date;
    updatedDate: Date;
    productImageFiles?: List_Product_Image[];
    imagePath: string;
  }