namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {

        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)  {}

        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) {}

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (!(Balance - amountToWithdraw - 2M < 0M))
            {
                if (Balance - amountToWithdraw < 150M)
                {
                    Balance -= amountToWithdraw + 2M;
                }
                else
                {
                    Balance -= amountToWithdraw;
                }
            } return Balance;
        }
    }
}
