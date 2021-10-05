using System;

namespace AbstractLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //log is feature 
            LogHelper.Log(LogTypes.File, "Hello, log message");

            LogHelper.Log(LogTypes.Database, "log to the db");

        }
    }
}
