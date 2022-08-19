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
          
            CarManager car=new CarManager (new EfCarDal());

            foreach (var product in car.GetAll())
            {
                Console.WriteLine(product.Description);
            }

            Console.ReadKey();
        }
    }
}
