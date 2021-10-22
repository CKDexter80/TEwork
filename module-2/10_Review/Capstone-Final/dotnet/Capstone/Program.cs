using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            /*what does vm need?
              a way to load inventory
              ui
              vend
              money manager
              logging
            */
            IWrite writer = new ConsoleIO();
            //ILoadInventory loader = new LoadInventoryFromMemory();
            //ILoadInventory loader = new LoadInventoryFromFile(writer);

            IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("Vending");

            ILoadInventory loader = new LoadInventoryFromDB(connectionString);

            Dictionary<string, Item> inventory = loader.Load();
            if (!loader.Error)
            {
                new VendingMachine(inventory, writer).RunApp();
            } else
            {
                writer.Print("Check log files, Error loading inventory");
            }
        }
    }
}
