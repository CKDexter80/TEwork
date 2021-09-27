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
            ValueOfCard = value;
            Suit = suit;
            
            //Console.WriteLine("creating a new card, neat!");
        }

        public int ValueOfCard { get; private set; }

        public string Suit { get; private set; }

        public bool IsFaceUp { get; private set; } //= true;//if we wnated to change default

        public void Flip()
        {
            if (IsFaceUp == true)
            {
                IsFaceUp = false;
            }
            else
            {
                IsFaceUp = true;
            }

            //   IsFaceUp = !IsFaceUp;
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

        public string Face
        {
            get
            {
                return faceValues[ValueOfCard];
            }
        }

        public static string Manufacturer { get; } = "Bicycle Card Company";

        public static Dictionary<int, string> faceValues = new Dictionary<int, string>()
        {
            {1, "Ace" },
            {2, "Two" },
            {3, "Three" },
            {4, "Four" },
            {5, "Five" },
            {6, "Six" },
            {7, "Seven" },
            {8, "Eight" },
            {9, "Nine" },
            {10, "Ten" },
            {11, "Jack" },
            {12, "Queen" },
            {13, "King" }
            
        };
    }
    //
    //no go zone 
}
