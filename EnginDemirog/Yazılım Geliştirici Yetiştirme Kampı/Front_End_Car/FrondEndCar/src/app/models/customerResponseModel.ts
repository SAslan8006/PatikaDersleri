import { Customer } from "./customer";
import { ResponseModel } from "./ResponseModel";

export interface CustomerResponseModel extends ResponseModel{
    data:Customer[];
}