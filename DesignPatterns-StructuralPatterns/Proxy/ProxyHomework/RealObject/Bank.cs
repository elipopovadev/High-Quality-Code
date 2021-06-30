using System.Collections.Generic;

namespace ProxyHomework.RealObject
{
    public static class Bank
    {
        internal static Dictionary<string, decimal> allAccounts = new Dictionary<string, decimal>
        {
            { "Ivan Ivanov", 5000m },
            { "Georgi Georgiev", 4000m },
            { "Atanas Atanasov", 6000m },
            { "Marin Marinov", 6000m }
        };

        public static string WithdrawMoney(string accountName, decimal amount)
        {
            allAccounts[accountName] -= amount;
            return "Transaction has been successful!";
        }
    }
}

