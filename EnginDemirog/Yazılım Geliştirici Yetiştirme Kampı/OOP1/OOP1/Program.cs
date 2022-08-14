using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id = 1, ProductName = "Elma", CategoryId = 1, UnitPrice = 20, UnitInStock = 20 };
            Product product2 = new Product { Id = 2, ProductName = "Gofret", CategoryId = 2, UnitPrice = 12, UnitInStock = 20 };
            Product product3 = new Product { Id = 3, ProductName = "Muz", CategoryId = 1, UnitPrice = 30, UnitInStock = 20 };
            Product product4 = new Product { Id = 4, ProductName = "Cikolata", CategoryId = 2, UnitPrice = 10, UnitInStock = 20};

            Product[] productlar = new Product[] { product1, product2, product3, product4 };

            foreach (var product in productlar)
            {
                Console.WriteLine($"{product.Id,-5} {product.ProductName,-15} {product.CategoryId,-4} {product.UnitPrice,-8} {product.UnitInStock,-10}  ");
            }
            Console.ReadKey();
        }
    }
}
