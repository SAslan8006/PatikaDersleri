using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(10);
            Console.WriteLine(getRandomNumber2());

            //Console.WriteLine(Topla(2,3));
            Console.ReadKey();

        }
        static int Topla(int x, int y) 
        { 
            return x + y;
        }
        private static void TryCatch()
        {
            //ExceptionIntro();
            //Find();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadKey();
        }
        private static void HandleException(Action action) 
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);             
            }
        }

        private static void Find()
        {
            List<string> student = new List<string> { "Süleyman", "Pamuk", "Minnoş" };
            if (!student.Contains("Minnos"))
            {
                throw new RecordNotFoundException ( "Record not Found.");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] student = new string[3] { "Engin", "Süleyman", "Pamuk" };
                student[3] = "mamut";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
                //Console.WriteLine("Exception...");
                //throw new Exception("Deger değeri Fazlası girilmiştir");
            }
        }
    }
}
