using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount: IAccountable
    {
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }

        public decimal Balance { get; private set; }
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; }

        public decimal Pay (decimal amountToPay)
        {
            Debt -= amountToPay;
            return Balance = -Debt;
        }

        public decimal Charge (decimal amountToCharge)
        {
            Debt += amountToCharge;
            return Balance = -Debt;

        }
    }
}
