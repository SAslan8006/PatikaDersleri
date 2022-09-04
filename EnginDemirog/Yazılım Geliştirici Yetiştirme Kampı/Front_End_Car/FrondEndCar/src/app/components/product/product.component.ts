import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  cars:Car[]=[];  
  dataLoaded=false;

  constructor(private carService:CarService,private activatedRoute:ActivatedRoute) { }
  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params=>{      
      if(params["brandId"]){
      this.getCarsByBrand(params["brandId"]);
      }
      if(params["colorId"]){
        this.getCarsByColor(params["colorId"]);
      }
      else{
        this.getCars();
      }     
    })
  }

  getCars(){
    this.carService.getCars().subscribe(response=>{
      this.cars=response.data
      this.dataLoaded=true;
     })
  }
   getCarsByBrand(brandId:number){
    this.carService.getCarsByBrand(brandId).subscribe(response=>{
    this.cars=response.data;
    //console.log(response.data);
    //debugger;
     this.dataLoaded=true;
    })
   }
   getCarsByColor(colorId:number){
    this.carService.getCarsByColor(colorId).subscribe(response=>{
    this.cars=response.data;
     this.dataLoaded=true;
    })
   }

}
