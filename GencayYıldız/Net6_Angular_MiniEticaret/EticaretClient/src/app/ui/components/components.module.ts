import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsModule } from 'src/app/admin/components/products/products.module';
import { HomeModule } from './home/home.module';
import { BasketsModule } from './baskets/baskets.module';
import { RegisterModule } from './register/register.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ProductsModule,
    HomeModule,
    BasketsModule,
    RegisterModule,
    //LoginModule
  ],
  exports: [
    BasketsModule
  ]
})
export class ComponentsModule { }