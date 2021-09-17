using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");
            string length = Console.ReadLine();
            double lengthNumber = double.Parse(length);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Is the measurement in (m)eter, or (f)eet? ");
            string meterOrFoot = Console.ReadLine();
            string meterOrFootLower = meterOrFoot.ToLower();

            if (meterOrFootLower == "m")
            {
                Console.WriteLine(lengthNumber + "m is " + (int)(lengthNumber * 3.2808399) + "f.");
            } else
            {
                Console.WriteLine(lengthNumber + "f is " + (int)(lengthNumber * 0.3048) + "m.");
            }
        }
    }
}
