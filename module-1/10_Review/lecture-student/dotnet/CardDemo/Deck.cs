using System;
using System.Collections.Generic;
using System.Text;

namespace CardDemo
{
    public class Deck
    {
        /*
         * 52 cards
         * shuffle()
         * deal()
         * 
         */
        //public int FiftyTwo { get; } = 52;
        public List<Card> Cards { get; set; } = new List<Card>();

        //constructor for Deck class
        public Deck()
        {
            //Card cardToAdd = new Card(1, "spades");
            //Cards.Add(cardToAdd);

            string[] suits = { "spades", "clubs", "diamonds", "hearts" };

            for (int i = 1; i <= 13; i++)
            {
                foreach (string suit in suits)
                {

                    Card cardToAdd = new Card(i, suit);
                    Cards.Add(cardToAdd);
                }

            }


        }



    }
}
