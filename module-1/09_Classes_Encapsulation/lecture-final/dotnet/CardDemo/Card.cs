using System;
using System.Collections.Generic;
using System.Text;

namespace CardDemo
{
    public class Card
    {

    //constructor
     public Card(int value, string suit)
        {
            // // needed if the parameter matches the 
            // this.Value = Value;
            Value = value;
            Suit = suit;
            //Console.WriteLine("creating a new card, neat!");
        }

        public int Value { get; private set; }

        public string Suit { get; private set; }

        public bool IsFaceUp { get; private set; } //= true;//if we wnated to change default

        public void Flip()
        {
            if (IsFaceUp)
            {
                IsFaceUp = false;
            }
            else
            {
                IsFaceUp = true;
            }
        }

        //derived property
        public string Color
        {
            get
            {
                //we can do magic
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
    //
    //no go zone 
}
