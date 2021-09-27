using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            //overload default constructor
            Auction generalAuction = new Auction("Funko Pop");

            generalAuction.PlaceBid(new Bid("Josh", 1));
            generalAuction.PlaceBid(new Bid("Fonz", 23));
            generalAuction.PlaceBid(new Bid("Rick Astley", 13));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids
            // generalAuction.HasEnded = true;

            BuyOutWednesdayAuction bow = new BuyOutWednesdayAuction();

            ReserveAuction reserveAuction = new ReserveAuction(250, "Beanie Baby");

            reserveAuction.PlaceBid(new Bid("Joe", 26));
            Console.ReadLine();
        }
    }
}
