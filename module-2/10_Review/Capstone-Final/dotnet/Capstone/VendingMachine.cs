using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public Dictionary<string, Item> inventory { get; }
        public IWrite io;
        public decimal Balance { get; private set; }
        public VendingMachine(Dictionary<string, Item> initInventory, IWrite write)
        {
            io = write;
            inventory = initInventory;
        }
        
        public void RunApp()
        {
            int userInput = 0;
            io.Welcome();

            while (userInput != 3)
            {
                io.MainMenu();
                userInput =  io.GetNumber();

                if (userInput == 1)
                {
                    DisplayInventory();
                }
                else if (userInput == 2)
                {
                    PurchaseMenu();
                }
            }
        }
        private void PurchaseMenu()
        {       
            int userInput = 0;
            while (userInput !=-1)
            {
                io.Print($"Currrent Balance: { Balance }");
                userInput = io.GetNumber(new int[] { 1, 2, 5, 10 });

                if (userInput > 0)
                {
                    Balance += userInput;
                }
            }
        }

        public Dictionary<string, int> MakeChange(decimal balance)
        {
            //balance =  2.15
            Dictionary<string, int> change = new Dictionary<string, int>();
            int numberOfQuarters = (int)(balance / .25M);
            balance = balance - (numberOfQuarters * .25M);

            int numberOfDimes = (int)(balance / .10M);
            balance = balance - (numberOfDimes * .10M);

            int numberOfNickels = (int)(balance / .05M);
            balance =  balance - (numberOfNickels * .05M);


            change["quarter"] = numberOfQuarters;
            change["dime"] = numberOfDimes;
            change["nickel"] = numberOfNickels;

            return change;
        }

        private void DisplayInventory()
        {
            io.Print("********************************************");

            foreach (KeyValuePair<string, Item> item in inventory)
            {
                string output = $"{item.Key} {item.Value}";
                io.Print(output);
            }

            io.Print("********************************************");
            io.Print("");
        }
    }
}
