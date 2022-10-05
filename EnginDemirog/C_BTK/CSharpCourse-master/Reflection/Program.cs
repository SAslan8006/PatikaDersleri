using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Toplam(3, 4));
            //Console.WriteLine(dortIslem.Toplam2());
            //var type=typeof(DortIslem);
            var tip = typeof(DortIslem);
            //DortIslem dortIslem=(DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Toplam(4,5));
            //Console.WriteLine(dortIslem.Toplam2());
            var instance =Activator.CreateInstance(tip,6,5);
            //Console.WriteLine(instance.GetType().GetMethod("Toplam2").Invoke(instance,null));
            MethodInfo methodInfo = instance.GetType().GetMethod("Toplam2");
            Console.WriteLine(methodInfo.Invoke(instance,null));
            Console.WriteLine();
            var methodlar = tip.GetMethods();
            foreach (var item in methodlar)
            {
                Console.WriteLine($"Methodlar: {item.Name}");
                foreach (var parametreler in item.GetParameters())
                {
                    Console.WriteLine($"{parametreler.Name,-5}");
                }
               
                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine($"Attribute: {attribute.GetType().Name,-5} ");
                }
            }
            Console.ReadKey();
        }
    }
    public class DortIslem
    {
        private int _a;
        private int _b;
        public DortIslem()
        {

        }
        public DortIslem(int a,int b)
        {
            _a = a;
            _b = b;
        }
        public int Toplam(int a, int b)
        {
            return a + b;
        }
        public int Carp(int a, int b)
        {
            return a *b;
        }
        public int Toplam2()
        {
            return _a + _b;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _a * _b;
        }
    
    }
    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
