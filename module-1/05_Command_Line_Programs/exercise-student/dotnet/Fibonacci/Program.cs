using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string endNumber = Console.ReadLine();
            int endNumberInt = int.Parse(endNumber);
            int fibonacciHolder = 0;

            if (endNumberInt <= 0)
            {
                Console.WriteLine("0, 1");
            }
            else
            {
                Console.Write("0, 1");
                for (int i = 1; i < endNumberInt + 1; i += fibonacciHolder)
                {
                    Console.Write(", " + i);
                    fibonacciHolder = i - fibonacciHolder;
                }
            }
        }
    }
}
