using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class ItemFactory
    {

        const int DEFAULT_QUANTITY = 5;

        public static Item GetItem(string type, string name, decimal price, int quantity = DEFAULT_QUANTITY)
        {
            switch (type)
            {
                case "gum":
                    return new Gum(name, price, quantity);
                case "chip":
                    return new Chip(name, price, quantity);
                default:
                    return null;
            }
        }
    }
}
