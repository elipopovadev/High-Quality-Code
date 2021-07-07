using System;
namespace BridgeHomework.Implementation
{
    public class MerveillanceExpert : Nuxe
    {
        public MerveillanceExpert()
        {
            base.ProductName = "Lift and firm cream";
            base.Price = 35;
            base.Barcode = "DCO12334553";
            base.DateOfManufacture = new DateTime(20,04,2021);
            base.ExpirationDate = new DateTime(20,09,2024);
        }   
    }
}
