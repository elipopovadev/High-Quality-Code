using System;

namespace BridgeHomework.Implementation
{
    public class Cicalfate : Avene
    {
        public Cicalfate()
        {
            base.ProductName = "Post-Acte";
            base.Price = 20;
            base.Barcode = "DCI12334553";
            base.DateOfManufacture = new DateTime(2021, 3, 30, 5, 6, 4);
            base.ExpirationDate = new DateTime(2023, 8, 30, 5, 6, 4);
        }
    }
}
