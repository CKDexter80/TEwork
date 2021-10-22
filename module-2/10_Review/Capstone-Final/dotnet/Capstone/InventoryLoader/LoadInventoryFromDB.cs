using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Capstone
{
    class LoadInventoryFromDB : ILoadInventory
    {
        public bool Error { get; private set; } = false;
        private readonly string connectionString;

        public LoadInventoryFromDB(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Dictionary<string, Item> Load()
        {
            Dictionary<string, Item> inventory = new Dictionary<string, Item>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT type, name, price, quantity, slot FROM items";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Item newItem = CreateItemFromReader(reader);
                        string slot = GetSlotFromReader(reader);

                        inventory[slot] = newItem;
                    }
                }
            }
            catch (Exception)
            {
                Error = true;
                //todo log error?
                //throw;
            }

            return inventory;
        }


        private string GetSlotFromReader(SqlDataReader reader)
        { 
            return Convert.ToString(reader["slot"]);
        }

        private Item CreateItemFromReader(SqlDataReader reader)
        {
            //SELECT type, name, price, quantity, slot FROM items
            string name = Convert.ToString(reader["name"]);
            string type = Convert.ToString(reader["type"]);
            decimal price = Convert.ToDecimal(reader["price"]);
            int quantity = Convert.ToInt32(reader["quantity"]);

            return ItemFactory.GetItem(type, name, price, quantity);
        }
    }
}
