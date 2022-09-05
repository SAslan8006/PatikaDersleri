import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Product } from 'src/app/models/product';
import { CartService } from 'src/app/Services/cart.service';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  products:Product[] = []; 
  dataLoaded=false;
  filterText="";
  constructor(private productService:ProductService, private activatedRoute:ActivatedRoute
  ,private toastrService:ToastrService, private cartService:CartService) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params=>{
      if(params["categoryId"]){
        this.getProductsByCategory(params["categoryId"]);
      }else{
        this.getProducts();
      }

    })
  }

  getProducts(){
   this.productService.getProducts().subscribe(response=>{
    this.products=response.data;
    this.dataLoaded=true;
    //console.log(response.data);
    //debugger;
   })
  }
  getProductsByCategory(categoryId:number){
    this.productService.getProductsByCategory(categoryId).subscribe(response=>{
    this.products=response.data;
    this.dataLoaded=true;
    })
   }
   addToCart(product:Product){
    //console.log(product)
    if(product.unitsInStock===0)
    {
      this.toastrService.error("Hata","Bu ürün ekleneme çünkü stok yoktur.")
    } else{
      this.toastrService.success("Sepete eklendi.",product.productName );
      this.cartService.addToCart(product);
    }

   }
}
