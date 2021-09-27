namespace InheritanceLecture.Auctioneering
{
    public class Bid
    {
        /// <summary>
        /// The bidder name.
        /// </summary>
        public string Bidder { get; }

        /// <summary>
        /// The bid amount.
        /// </summary>
        public int BidAmount { get; }
        /// <summary>
        /// Constructor for Bid object. Each Bid requires a bidder and bidAmount
        /// </summary>
        /// <param name="bidderConstructor">Who is bidding</param>
        /// <param name="bidAmount">How much bid is for</param>
        public Bid(string bidderConstructor, int bidAmount)
        {
            this.Bidder = bidderConstructor;
            this.BidAmount = bidAmount;
        }
    }
}
