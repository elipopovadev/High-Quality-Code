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
            base.DateOfManufacture = new DateTime(20,09,2020);
            base.ExpirationDate = new DateTime(20,09,2022);
        }
    }
}
