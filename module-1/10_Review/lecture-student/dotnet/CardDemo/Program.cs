using System;

namespace CardDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an instance of the card class
            //card is type
            //Card card = new Card();
            Card card0 = new Card(2, "hearts");
            card0.Flip();

            card0 = card0;
            card0.Flip();
            card0 = card0;
            //init all prop of the clas
            Console.WriteLine($"Card card0 value is {card0.Value}");
           
            //card0.Value = 10;
            //card0.Suit = "spades";
            //demoing derived property evaluation
            Console.WriteLine($"Card card0 color is {card0.Color}");

            Console.WriteLine($"Card card0 color is {card0.Color}");

            // Card card1 = new Card();

            Console.WriteLine("Hello World! wow look at this");
        }
    }
}
