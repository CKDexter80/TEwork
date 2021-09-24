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
    
        //constuctor for the Deck class
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

        public Card Deal()
        {
            if (Cards.Count > 1)
            {
                Card cardToDeal = Cards[Cards.Count - 1];
                Cards.Remove(cardToDeal);
                return cardToDeal;
            }
            else
            {
                return null;
            }
        }
      

        public void Shuffle()
        {
            Random rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                int k = rng.Next(n--);
                Card temp = Cards[n];
                Cards[n] = Cards[k];
                Cards[k] = temp;
            }
        }

        public void Shuffle(int valueToRemove)
        {
            Random rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                int k = rng.Next(n--);
                Card temp = Cards[n];
                Cards[n] = Cards[k];
                Cards[k] = temp;
            }
        }
    }
}
