import { Component, OnInit } from '@angular/core';
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

  constructor(private carService:CarService) { }
  ngOnInit(): void {
    this.getBrands();
  }

  getBrands(){
    this.carService.getCars().subscribe(response=>{
      this.cars=response.data
      this.dataLoaded=true;
     })
  }
}
