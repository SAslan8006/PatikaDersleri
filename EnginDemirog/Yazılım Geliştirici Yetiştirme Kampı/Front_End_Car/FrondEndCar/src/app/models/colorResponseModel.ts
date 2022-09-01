import { Color } from "./color";
import { ResponseModel } from "./ResponseModel";

export interface ColorResponseModel extends ResponseModel{
    data:Color[];
}