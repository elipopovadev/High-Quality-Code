using BridgeHomework.BridgeInterface;
using System;

namespace BridgeHomework.Abstraction
{
   public static class CosmeticsDateChecker
    {
        public static void CheckExpirationDate(ICosmetics product)
        {
            if(product.ExpirationDate.CompareTo(new DateTime(2026, 08, 30, 3, 4, 5)) > 0)
            {
                throw new ArgumentException("Unvalid Expired date!");
            }
            else
            {
                Console.WriteLine("Valid expired date!");
            }
        }
    }
}
