using System;

namespace CardDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an instance of card class
            //casd is atype
            Card card0 = new Card(2, "hearts");
            card0.Flip();
            Console.WriteLine($"Card card0 vale is {card0.Value}");
            //card0.Value = 10;
            //card0.Suit = "spades";
            Console.WriteLine($"Card card0 color is {card0.Color}");
            string color = card0.Suit;
            //card0.Suit = "hearts";

            Console.WriteLine($"Card card0 color is {card0.Color}");
           
            //Card card1 = new Card();



            
        }
    }
}
