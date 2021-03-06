using ExceptionHandling.Exceptions;
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * By default, when an Exception is thrown, it will "bubble up" through the call stack until
            * it reaches the main method and then will cause the program to exit and print a stacktrace
            * to the standard output
            *
            * By using try/catch blocks, you can stop the Exception from exiting the method and provide
            * code to handle it.
            */
            Console.WriteLine("Give Me Stuff to Break");

            MathIsFun mif = new MathIsFun();

            try
            {
                Console.WriteLine(mif.Multiply(3, 1000000000));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine(mif.Divide(10, 0));
            Console.WriteLine(mif.Divide(10, 1));
        }
    }
}
