using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1,int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMesage();
            //customerManager.ShowAlert();
            Matematik matematik=new Matematik();
            MyDelegate myDelegate = customerManager.SendMesage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMesage;
            MyDelegate2 myDelegate2 = customerManager.SendMesage2;
            myDelegate2+=customerManager.ShowAlert2;
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            Console.WriteLine(myDelegate3(2, 3));

            myDelegate();
            myDelegate2("Hello");
            Console.ReadKey();
        }
    }
    public class CustomerManager
    {
        public void SendMesage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }
        public void SendMesage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string message)
        {
            Console.WriteLine(message);
        }

    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        { 
        return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
