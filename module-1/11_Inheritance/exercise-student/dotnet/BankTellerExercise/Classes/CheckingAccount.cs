namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        
        public CheckingAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (base.Balance - amountToWithdraw > -100M)
            {
                if (base.Balance - amountToWithdraw < 0M)
                {
                    base.Balance = (base.Balance -= amountToWithdraw) - 10M;
                }
                else
                {
                    base.Balance -= amountToWithdraw;
                }
            }
            return base.Balance;
        }
    }
}
