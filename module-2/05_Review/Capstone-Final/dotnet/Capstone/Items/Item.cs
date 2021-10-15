namespace Capstone
{
    public abstract class Item
    {
        public string Name { get; }
        public decimal Price { get; }
        protected int QuantityAvailable { get; set; }

        public Item(string name, decimal price, int quantityToStock)
        {
            Name = name;
            Price = price;
            QuantityAvailable = quantityToStock;
        }

        public string QuanityAvailableMessage
        {
            get
            {
                if (QuantityAvailable > 0)
                {
                    return QuantityAvailable.ToString();
                }
                else
                {
                    return "Sold Out";
                }
            }
        }

        public abstract string VendItem();
        public override string ToString()
        {
            return $"{Name} {Price} {QuanityAvailableMessage} ";
        }
    }
}
