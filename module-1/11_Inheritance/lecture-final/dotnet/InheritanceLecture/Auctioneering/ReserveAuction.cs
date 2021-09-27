using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    //do not accept a bid until it meets a certain price (reserve)
    public class ReserveAuction : Auction
    {

        //
        public int reservePrice { get; }

        public ReserveAuction(int reservePrice) : base("this is a reserve auction")
        {
            this.reservePrice = reservePrice;
        }
        //overload constructor
        public ReserveAuction(int reservePrice, string auctionName) : base(auctionName)
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
