using ProxyHomework.RealObject;
using ProxyHomework.Subject;

namespace ProxyHomework.ProxyObject
{
    public class ATM : IAccount
    {
        private bool CheckForValidateAccount(string accountName)
        {
            if (Bank.allAccounts.ContainsKey(accountName))
            {
                return true;
            }
            return false;
        }

        private bool CheckForValidateAmount(string accountName, decimal amount)
        {
            if (Bank.allAccounts[accountName] >= amount)
            {
                return true;
            }
            return false;
        }

        public string WithdrawMoney(string accountName, decimal amount)
        {
            if(this.CheckForValidateAccount(accountName) && this.CheckForValidateAmount(accountName, amount))
            {
                Bank.WithdrawMoney(accountName, amount);
                return "Transaction has been done successful!";
            }

            return "Unsuccessful transaction!";
        }
    }
}

