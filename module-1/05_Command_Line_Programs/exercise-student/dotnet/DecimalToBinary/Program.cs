using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string conversions = Console.ReadLine();
            string[] conversionsArray = conversions.Split(' ');

            for (int i = 0; i < conversionsArray.Length; i++)
            {
                decimal stringAsDecimal = decimal.Parse(conversionsArray[i]);
                Console.WriteLine(conversionsArray[i] + " in binary is " + Convert.ToString((int)stringAsDecimal, 2));
            }


        }
    }
}
