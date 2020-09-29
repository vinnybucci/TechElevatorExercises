using System.Data;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    
    {
        public SavingsAccount(string AccountHolderName, string AccountNumber) : base(AccountHolderName, AccountNumber)
        {

        }
        public SavingsAccount(string AccountHolderName, string AccountName, decimal Balance) : base(AccountHolderName, AccountName, Balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw >=2)
            {
                base.Withdraw(amountToWithdraw);
                if (Balance <150)
                {
                    base.Withdraw(2);
                }

            }
            return Balance;
           
        }
    }
}
