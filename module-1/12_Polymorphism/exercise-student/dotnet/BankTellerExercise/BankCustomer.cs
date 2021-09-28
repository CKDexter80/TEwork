using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer : IAccountable
    {
        public decimal Balance { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                decimal totalBalance = 0;
                foreach (IAccountable account in accountsToDate)
                {
                    totalBalance += account.Balance;
                }
                if (totalBalance >= 25000M)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private List<IAccountable> accountsToDate = new List<IAccountable>();

        public void AddAccount(IAccountable newAccount)
        {
            accountsToDate.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            IAccountable[] accounts = accountsToDate.ToArray();
            return accounts;
        }
    }
}
