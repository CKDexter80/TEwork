using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class LoadInventoryFromMemory : ILoadInventory
    {
        public bool Error {get;} = false;

        public Dictionary<string, Item> Load()
        {
            return new Dictionary<string, Item>()
            {
                {"A1", new Gum("TEST", 1M, 1) },
                {"A2", new Gum("TEST2", 2M, 2) },
                {"A3", new Gum("TEST3", 3M, 3) },
                {"A4", new Gum("TEST4", 4M, 4) },
            };
        }
    }
}
