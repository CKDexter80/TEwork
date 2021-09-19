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

            // short way
            /*for (int i = 0; i < conversionsArray.Length; i++)
            {
                decimal stringAsDecimal = decimal.Parse(conversionsArray[i]);
                Console.WriteLine(conversionsArray[i] + " in binary is " + Convert.ToString((int)stringAsDecimal, 2));
            }*/

            // long way
            for (int i = 0; i < conversionsArray.Length; i++)
            {
                decimal convertedStringToDecimal = decimal.Parse(conversionsArray[i]);
                decimal dividend = convertedStringToDecimal;
                int quotient = 0;
                string binaryHolder = "";
                string binaryDigit = "";

                if (convertedStringToDecimal == 0)
                {
                    binaryHolder += "0";
                }
                else
                {
                    while (dividend > 0)
                    {
                        binaryDigit = Convert.ToString((int)dividend % 2);
                        binaryHolder = binaryDigit + binaryHolder;
                        quotient = (int)dividend / 2;
                        dividend = quotient;
                    }
                }

                Console.WriteLine(conversionsArray[i] + " in binary is " + binaryHolder);
            }
        }
    }
}
