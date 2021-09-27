namespace BankTellerExercise.Classes
{
    public class BankAccount
    {

        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = 0.0M;
        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }

        public decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }
    }
}
