namespace Capstone
{
    public class Chip : Item
    {
        public Chip(string name, decimal price, int quantityToStock = -1)
            : base(name, price, quantityToStock) { }

        public override string VendItem()
        {
            QuantityAvailable -= 1;
            return "Munch Munch";
        }
    }
}
