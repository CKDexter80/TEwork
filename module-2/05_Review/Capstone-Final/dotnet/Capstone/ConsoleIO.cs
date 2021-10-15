using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Capstone
{
    class ConsoleIO : IWrite
    {

        public void Welcome()
        {
            Console.WriteLine("Welcome to the Vend-O Matic 2.0");
            Console.WriteLine("Please Select From the Menu Below");
            Console.WriteLine("");
        }

        public void MainMenu()
        {
            Console.WriteLine("1) Display Vending Machine Items");
            Console.WriteLine("2) Purchase");
            Console.WriteLine("3) Exit");
            Console.WriteLine("");
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// Prompts user to select a number 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>-1 if bad input given</returns>
        public int GetNumber()
        {
            Print("Please Enter a number");
            string response = Console.ReadLine();
            if (int.TryParse(response, out int responseNumber))
            {
                return responseNumber;
            }
            else
            {
                return -1;
            }
        }
        /// <summary>
        /// Prompts user to select a number from a specific set of numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>-1 if bad input given</returns>
        public int GetNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Print($"{i + 1}) {numbers[i]}");
            }
           
            int responseNumber = GetNumber();

            if ((responseNumber > -1) && (responseNumber - 1 < numbers.Length))
            {
                return numbers[responseNumber - 1];
            }
           
            return -1;
        }
    }
}
