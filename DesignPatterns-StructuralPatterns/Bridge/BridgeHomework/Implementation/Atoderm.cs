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
            base.DateOfManufacture = new DateTime(20,05,2020);
            base.ExpirationDate = new DateTime(20,09,2023);
        }
    }
}
