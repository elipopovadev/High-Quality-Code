using System;

namespace BridgeHomework.BridgeInterface
{
    public interface ICosmetics
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
