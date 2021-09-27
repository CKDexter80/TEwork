using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyOutAuction : Auction
    {

        public int BuyoutPrice { get; }
        //once buyout price is met no more bids
        //aka auction has ended
        public BuyOutAuction(int buyoutPrice) : base("Buyout")
        {
            BuyoutPrice = buyoutPrice;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            /*
             * bid matches buyout
             *    -end the auction
             *    -place the bid
             * 
             */

            base.PlaceBid(offeredBid);
            if (offeredBid.BidAmount >= BuyoutPrice)
            {
                base.HasEnded = true;
            }


            return base.PlaceBid(offeredBid);
        }
    }
}
