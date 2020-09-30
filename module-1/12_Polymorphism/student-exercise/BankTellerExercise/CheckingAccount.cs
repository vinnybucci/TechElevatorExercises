namespace BankTellerExercise
{
    public class CheckingAccount : BankAccount
    {

        public CheckingAccount(string accountHolder, string accountNumber) : base(accountHolder, accountNumber)
        {

        }

        public CheckingAccount(string accountHolder, string accountNumber, int balance) : base(accountHolder, accountNumber, balance)
        {

        }

        public override int Withdraw(int amountToWithdraw)
        {
            if (Balance - amountToWithdraw > -100)
            {
                base.Withdraw(amountToWithdraw);
                if (Balance < 0)
                {
                    base.Withdraw(10);
                }
            }
            return Balance;
        }

    }
}
