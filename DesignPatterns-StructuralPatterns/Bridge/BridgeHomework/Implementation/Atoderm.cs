using System;

namespace BridgeHomework.Implementation
{
   public class Atoderm : Bioderma
    {
        public Atoderm()
        {
            base.ProductName = "Cream";
            base.Price = 30;
            base.Barcode = "DCM12334553";
            base.DateOfManufacture = new DateTime(2021, 3, 30, 5, 6, 4);
            base.ExpirationDate = new DateTime(2023, 8, 30, 5, 6, 4);
        }
    }
}
