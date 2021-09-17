using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //get user input
                //parse (could fail at runtime)
            //store input
            //for loop
            //array

            //.parse

            Console.WriteLine("Welcome to the Discount Calculator");

          
            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage): ");

            string discountAmoutAsString = Console.ReadLine();
            double discountAmount = double.Parse(discountAmoutAsString);

            //double discountAmount = double.Parse(Console.ReadLine());

           
            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");

            string prices = Console.ReadLine();

            string[] listOfPrices = prices.Split(' ');

            Console.WriteLine("You entered " + prices);



            for (int i = 0; i < listOfPrices.Length; i++)
            {
                //new amount after discount
                //multiply discount * each price
                decimal newPrice = decimal.Parse(listOfPrices[i]);
                
                decimal priceAfterDiscount = (100 - (decimal)discountAmount) * newPrice * .01M;
                Console.WriteLine("The discounted amount is: " + priceAfterDiscount);
            }

            
            






        }
    }
}
