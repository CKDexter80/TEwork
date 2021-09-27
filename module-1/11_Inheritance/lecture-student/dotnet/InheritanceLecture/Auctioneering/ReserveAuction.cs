using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    //do not accept bid imtil it meets a certain price (reserve)
    public class ReserveAuction : Auction
    {

        public int reservePrice { get; }

        public ReserveAuction(int reservePrice)
        {
            this.reservePrice = reservePrice;
        }

        public override bool PlaceBid(Bid offeredBid)
        {

            if (offeredBid.BidAmount > reservePrice)
            {
               return base.PlaceBid(offeredBid);
            }

            return false;
        }
    }
}
