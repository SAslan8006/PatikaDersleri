using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { ProdcutId=1,ProductName="Elma",ProductCategoryId="1",ProductPrice=20,ProductStock=20,ProductDiscountPrice=10};
            Product product2 = new Product { ProdcutId = 2, ProductName = "Gofret", ProductCategoryId = "2", ProductPrice = 12, ProductStock = 20, ProductDiscountPrice = 10 };
            Product product3 = new Product { ProdcutId = 3, ProductName = "Muz", ProductCategoryId = "1", ProductPrice = 30, ProductStock = 20, ProductDiscountPrice = 5 };
            Product product4 = new Product { ProdcutId = 4, ProductName = "Cikolata", ProductCategoryId ="2", ProductPrice = 10, ProductStock = 20, ProductDiscountPrice = 10 };

            Product[] productlar = new Product[] { product1, product2, product3,product4 };

            foreach (var product in productlar)
            {
                Console.WriteLine($"{product.ProdcutId,-5} {product.ProductName,-15} {product.ProductPrice,-8} {product.ProductStock,-8} {product.ProductCategoryId,-10} {product.ProductDiscountPrice,-5} ");
            }
            Console.ReadKey();
        }
    }
    class Product
    {
        public string ad;
        public int ProdcutId { get; set; }
        public double ProductPrice { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public string ProductCategoryId 
        {
            get { return ad; }
            set
            {
                if (value == "1")
                    ad = "Meyve";
                if (value == "2")
                    ad = "Abur-Cubur";
            }
        }
        public int ProductDiscountPrice { get; set;}


    }
}
      
