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
            //store the input
            //for loop
            //array

            // .Parse 

            Console.WriteLine("Welcome to the Discount Calculator");

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.WriteLine("Enter the discount amount (w/out percentage): ");

            //getting user input and storing it into discountAmountAsString
            string discountAmountAsString = Console.ReadLine();
            //parsing userinput into a double
            double discountAmount = double.Parse(discountAmountAsString);

            // Prompt the user for a series of prices
            Console.WriteLine("Please provide a series of prices (space separated): ");

            string prices = Console.ReadLine();

            string[] listOfPrices = prices.Split(' ');

            //Console.WriteLine("You Entered: " + prices + ".");
            
            for (int i = 0; i < listOfPrices.Length; i++)
            {
                //new amount after discount
                //multiply discount * each price

                //25 100 = 75
                //(100 - discount) * price 
                decimal newPrice = decimal.Parse(listOfPrices[i]);
                decimal priceAfterDiscount = (100 - (decimal)discountAmount) * newPrice * .01M;
                Console.WriteLine("The discounted Amount is: " + priceAfterDiscount);   
                //v2
                //format a string as money
                //show original and discounted
                //show the total cost vs cost discount
            }
        }
    }
}
