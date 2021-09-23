using System;
using System.Collections.Generic;
using System.Text;

namespace CardDemo
{
    class Card
    {
        //constructor
        public Card(int value, string suit)
        {
            //this.Value = Value;
            Value = value;
            Suit = suit;

            //Console.WriteLine("creating a new card");
        }

        public int Value { get; private set; }
        
        public string Suit { get; private set; }

        public bool IsFaceUp { get; set;}
        
        public void Flip()
        {
            IsFaceUp = !IsFaceUp;

            //if (IsFaceUp)
            //{
            //    IsFaceUp = false;
            //}
            //else
            //{
            //    IsFaceUp = true;
            //}
        }
 
        public string Color
        {
            get
            {
                //method
                if (Suit == "spades" || Suit == "clubs")
                {
                    return "black";
                }
                else
                {
                    return "red";
                }

            }
        }

    }
    //no code; keep
}
