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
            base.DateOfManufacture = new DateTime(2021, 8, 30, 5, 6, 4);
            base.ExpirationDate = new DateTime(2023, 8, 30, 5, 6, 4);
        }   
    }
}
