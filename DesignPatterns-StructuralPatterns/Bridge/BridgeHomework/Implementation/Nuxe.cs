using BridgeHomework.BridgeInterface;
using System;

namespace BridgeHomework.Implementation
{
    public abstract class Nuxe : ICosmetics
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
