﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        { 
            ProductDirector director = new ProductDirector();
            var builder = new OldCustomerProductBuilder();
            director.GenerateProduct(builder);
            var model=builder.GetModel();

            Console.WriteLine(model.Id);
            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.DiscountApplied);
            Console.WriteLine(model.DiscountedPrice);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.UnitPrice);

            Console.ReadKey();
        }
    }
    class ProductViewModel
    { 
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
    }
    abstract class ProductBuilder
    { 
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();

    }
    class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model=new ProductViewModel(); 

        public override void ApplyDiscount()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai"; 
            model.UnitPrice = 20;

        }

        public override ProductViewModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.DiscountedPrice = model.UnitPrice * (decimal)0.90;
            model.DiscountApplied = true;

        }
    }
    class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
        }

        public override ProductViewModel GetModel()
        {
            return model ;
        }

        public override void GetProductData()
        {
            model.DiscountedPrice = model.UnitPrice;
            model.DiscountApplied = false;
        }
    }
    class ProductDirector
    {
        public void GenerateProduct(ProductBuilder productBuilder) 
        {
            productBuilder.ApplyDiscount();
            productBuilder.GetProductData();
        }
    }
}
