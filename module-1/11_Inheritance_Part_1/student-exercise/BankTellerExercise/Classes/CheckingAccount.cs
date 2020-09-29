using System.Reflection.Metadata.Ecma335;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string AccountHolderName, string AccountNumber) : base(AccountHolderName, AccountNumber)
        {

        }

        public CheckingAccount(string AccountHolderName, string AccountName, decimal Balance) : base(AccountHolderName, AccountName, Balance)
        {

        }


        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw > -100.00M)
            {
                base.Withdraw(amountToWithdraw);

                if (Balance - amountToWithdraw < 0)
                {

                    base.Withdraw(10M);

                }
            }
            return Balance;
        }
    } 
} 
        
   
    



