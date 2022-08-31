import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { productResponseModel } from '../models/productResponseModel';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ProductService {

  apiUrl="https://localhost:44330/api/products/getall";
  constructor(private httpClient:HttpClient) { }

  getProducts():Observable<productResponseModel>{ 
    return this.httpClient.get<productResponseModel>(this.apiUrl);
  }

}
