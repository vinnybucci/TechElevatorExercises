using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer : IAccountable
    {
        private List<IAccountable> Accounts = new List<IAccountable>();
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Balance { get; set; }
        public bool IsVip
        {
            get
            {
                decimal balance = 0;
                foreach (IAccountable account in Accounts)
                {
                    balance += account.Balance;
                }
                if (balance >= 25000m)
                {
                    return true;
                }
                return false;
            }
        }




        public void AddAccount(IAccountable newAccount)
        {
            Accounts.Add(newAccount);
        }
        public IAccountable[] GetAccounts()
        {
            
            {
                return Accounts.ToArray();
            }
        }
    }
}
