import { Product } from "./product";
import { ResponseModel } from "./responseModel";

export interface productResponseModel extends ResponseModel {
    data:Product[]
}