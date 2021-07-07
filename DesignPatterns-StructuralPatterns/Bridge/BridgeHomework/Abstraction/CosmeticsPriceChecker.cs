using BridgeHomework.BridgeInterface;
using System;

namespace BridgeHomework.Abstraction
{
   public static class CosmeticsPriceChecker
    {
        public static void CheckPrice(ICosmetics product)
        {
            if(product.Price < 0 || product.Price > 100)
            {
                throw new ArgumentException("Invalid price!");
            }
            else
            {
                Console.WriteLine("Valid price!");
            }
        }
    }
}
