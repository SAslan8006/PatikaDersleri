import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from '../models/car';
import { ListResponseModel } from '../models/listResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  apiUrl="https://localhost:44396/api/";

  constructor(private httpClient:HttpClient) { } 

  getCars():Observable<ListResponseModel<Car>>{ 
    let newPath=this.apiUrl + "Cars/getcardetails"
    return this.httpClient.get<ListResponseModel<Car>>(newPath);
  }
  getCarsByBrand(brandId:number):Observable<ListResponseModel<Car>>{ 
    let newPath=this.apiUrl + "Cars/carsDetailsByBrandId?brandId=" + brandId
    return this.httpClient.get<ListResponseModel<Car>>(newPath);
  }

  getCarsByColor(colorId:number):Observable<ListResponseModel<Car>>{ 
    let newPath=this.apiUrl + "Cars/getcarsbycolorid?colorId=" + colorId
    return this.httpClient.get<ListResponseModel<Car>>(newPath);
  }

}
