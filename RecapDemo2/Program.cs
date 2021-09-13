﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustumerMAnager custumerMAnager = new CustumerMAnager();
            custumerMAnager.Logger = new FileLogger();
            custumerMAnager.Add();
            Console.ReadLine();

        }
    }

    class CustumerMAnager
    {
        public ILogger Logger  { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added !");
        }
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
