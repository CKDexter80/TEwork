using System;
using System.Collections.Generic;
using System.Text;

namespace FizzWriter
{
    class FizzBuzz
    {
        public static string FizzBuzzer(int number)
        {
            string output = "";
            if (number % 15 == 0)
            {
                output = "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                output = "Buzz";
            }
            else if (number % 3 == 0)
            {
                output = "Fizz";
            }
            else
            {
                output = number.ToString();
            }
            return output;
        }
    }
}
