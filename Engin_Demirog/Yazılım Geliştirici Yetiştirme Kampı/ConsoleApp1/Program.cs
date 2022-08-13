using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { ProductId=1,ProductName="Elma",Price=20,Description="Amasya Elması"};
            Product product2 = new Product { ProductId=2,ProductName="Armut",Price=30,Description="Taş Armutu"};
            Product product3 = new Product { ProductId =3, ProductName = "Muz", Price = 35, Description = "İthal Muz" };
            Product product4 = new Product { ProductId = 4, ProductName = "Muz", Price = 25, Description = "Yerli Muz" };
            Product[] products = new Product[] { product1, product2, product3, product4 };
            foreach (Product item in products)
            {
                Console.WriteLine($"{item.ProductId,-5} {item.ProductName,-10} {item.Price,-5} {item.Description,-25}");
            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);

            Console.ReadKey();
        }
    }
}
