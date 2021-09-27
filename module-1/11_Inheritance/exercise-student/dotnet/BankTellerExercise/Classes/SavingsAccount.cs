namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {

        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }

        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (!(base.Balance - amountToWithdraw - 2M < 0M))
            {
                if (base.Balance - amountToWithdraw < 150M)
                {
                    base.Balance -= amountToWithdraw + 2M;
                }
                else
                {
                    base.Balance -= amountToWithdraw;
                }
            } return base.Balance;
        }
    }
}
