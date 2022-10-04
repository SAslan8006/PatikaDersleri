import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsModule } from 'src/app/admin/components/products/products.module';
import { HomeModule } from './home/home.module';
import { BasketsModule } from './baskets/baskets.module';
import { RegisterModule } from './register/register.module';
import { PasswordResetModule } from './password-reset/password-reset.module';
import { UpdatePasswordModule } from './update-password/update-password.module';



@NgModule({
  declarations: [
  
  ],
  imports: [
    CommonModule,
    ProductsModule,
    HomeModule,
    BasketsModule,
    RegisterModule,
    //LoginModule,
    PasswordResetModule,
    UpdatePasswordModule,
  ],
  exports: [
    BasketsModule
  ]
})
export class ComponentsModule { }