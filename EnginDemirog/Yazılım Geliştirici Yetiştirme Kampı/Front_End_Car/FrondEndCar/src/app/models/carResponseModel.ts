import { Car } from "./car";
import { ResponseModel } from "./ResponseModel";

export interface CarResponseModel extends ResponseModel{
    data:Car[];
}