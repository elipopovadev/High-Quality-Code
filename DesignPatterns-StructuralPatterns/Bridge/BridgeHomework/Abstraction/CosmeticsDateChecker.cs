using BridgeHomework.BridgeInterface;
using System;

namespace BridgeHomework.Abstraction
{
   public static class CosmeticsDateChecker
    {
        public static void CheckExpirationDate(ICosmetics product)
        {
            if(product.ExpirationDate < new DateTime(01, 08, 2021))
            {
                throw new ArgumentException("Expired date!");
            }
            else
            {
                Console.WriteLine("Valid expired date!");
            }
        }
    }
}
