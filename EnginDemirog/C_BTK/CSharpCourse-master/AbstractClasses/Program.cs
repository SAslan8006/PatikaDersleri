using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Database database = new Oracle();
            database.Delete();
            database.Add();

            Database database2 = new SqlServer();
            database2.Delete();
            database2.Add();

            Console.ReadKey();
        }       

    }
    abstract class Database
    {
        public void Add() 
        {
            Console.WriteLine("Added by Default");
        }
        public abstract void Delete();
    
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");

        }
    }
}
