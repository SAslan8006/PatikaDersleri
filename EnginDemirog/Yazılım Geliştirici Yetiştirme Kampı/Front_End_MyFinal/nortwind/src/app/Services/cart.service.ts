import { Injectable } from '@angular/core';
import { CartItem } from '../models/cardItem';
import { CartItems } from '../models/cardItems';
import { Product } from '../models/product';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  cartItems:CartItem
  constructor() { }

  addToCart(product:Product){
    let item=CartItems.find(c=>c.product.productId===product.productId)
    if(item)
    {
      item.quatity+=1;
    }else{
      let cartItem=new CartItem();
      cartItem.product=product;
      cartItem.quatity=1;
      CartItems.push(cartItem)
    }  
  }
  removeFromCart(product:Product){
    let item:CartItem=CartItems.find(c=>c.product.productId===product.productId)
    CartItems.splice(CartItems.indexOf(item),1);
  }
  list():CartItem[]{
    return CartItems;
  }

}
