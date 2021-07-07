using BridgeHomework.Abstraction;
using BridgeHomework.Implementation;

namespace BridgeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            CosmeticsPriceChecker.CheckPrice(new Cicalfate());
            CosmeticsDateChecker.CheckExpirationDate(new Atoderm());
            CosmeticsPriceChecker.CheckPrice(new MerveillanceExpert());
        }
    }
}
