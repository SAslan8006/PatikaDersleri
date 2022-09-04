import { Component, OnInit } from '@angular/core';
import { Brand } from 'src/app/models/brand';
import { Color } from 'src/app/models/color';
import { BrandService } from 'src/app/services/brand.service';
import { ColorService } from 'src/app/services/color.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {
  brands:Brand[]=[];
  colors:Color[]=[];
  currentBrand :Brand;
  currentColor:Color;
  dataLoaded=false;
  constructor(private brandService:BrandService,private colorService:ColorService) { }
  ngOnInit(): void {
    this.getBrands();
    this.getColors();
  }

  getBrands(){
  
    this.brandService.getBrands().subscribe(response=>{
      this.brands=response.data
      this.dataLoaded=true;     
     })
  }
  
  getColors(){  
    this.colorService.getColors().subscribe(response=>{
      this.colors=response.data
      this.dataLoaded=true;
    })     
  }

  setCurrentBrand(brand:Brand){
    this.currentBrand=brand;
  }
  setCurrentColor(color:Color){
    this.currentColor=color;
  }

  getCurrentColorClass(color:Color){
    if(color==this.currentColor){
      return "list-group-item active";
    }else
    {
      return "list-group-item";
    }
  }

  getCurrentBrandClass(brand:Brand){
    if(brand==this.currentBrand){
      return "list-group-item active";
    }else
    {
      return "list-group-item";
    }
  }

  
  getAllCategoryClass(){
    if(!this.currentBrand){
      return "list-group-item active";
    }else
    {
      return "list-group-item";
    }
  }

}

