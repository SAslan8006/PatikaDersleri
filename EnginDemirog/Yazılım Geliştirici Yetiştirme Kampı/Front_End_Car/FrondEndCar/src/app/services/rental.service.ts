import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ListResponseModel } from '../models/listResponseModel';
import { Rental } from '../models/rental';

@Injectable({
  providedIn: 'root'
})
export class RentalService {
  
  apiUrl="https://localhost:44396/api"
  constructor(private httpClient:HttpClient) { }

 
  
  getRentals():Observable<ListResponseModel<Rental>>{ 
    let newPath=this.apiUrl + "/Rentals/details"
    return this.httpClient.get<ListResponseModel<Rental>>(newPath);
  }
  getRentalsByCategory(userId:number):Observable<ListResponseModel<Rental>>{ 
    let newPath=this.apiUrl + "/Rentals/getrentaldetailbyuserid?userId=" + userId
    return this.httpClient.get<ListResponseModel<Rental>>(newPath);
  }

}
