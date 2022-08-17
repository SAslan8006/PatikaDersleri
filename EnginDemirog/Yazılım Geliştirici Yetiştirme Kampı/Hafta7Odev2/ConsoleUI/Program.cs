using Business.Concrete;
using DataAccess.Concrete.Memory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager car = new CarManager(new InMemoryCarDal());
            foreach (var item in car.GetAll())
            {
                Console.WriteLine($"{item.CarId,-3} {item.ModelYear,-6} {item.DailyPrice,-5} {item.BrandId,-5} {item.ColorId,-8} {item.Description,-10} " );
            }

            Console.ReadKey();
        }
    }
}
