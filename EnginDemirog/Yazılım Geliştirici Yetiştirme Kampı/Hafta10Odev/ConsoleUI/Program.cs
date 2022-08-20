using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.Memory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {            
            CarTest();
            ProductTest();
            Console.ReadKey();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.CarName + " / " + product.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
