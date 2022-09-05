﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer=new MySqlServer();
            mySqlServer.Add();
            Console.ReadKey();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default.");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default.");

        }       

    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }
    class MySqlServer : Database
    {

    }
}
