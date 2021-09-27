namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        
        public CheckingAccount(string accountholdername, string accountnumber) : base(accountholdername, accountnumber) {}

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) {}

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw > -100M)
            {
                if (Balance - amountToWithdraw < 0M)
                {
                    Balance = (Balance -= amountToWithdraw) - 10M;
                }
                else
                {
                    Balance -= amountToWithdraw;
                }
            }
            return Balance;
        }
    }
}
