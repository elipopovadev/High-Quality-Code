using AdapterHomework.Adaptee;
using System.Collections.Generic;

namespace AdapterHomework.Adapter
{
    public class FuelAdapter : ITarget
    {
        ThirdPartyFuelCostCalculator thirdPartyFuelCostCalculator = new ThirdPartyFuelCostCalculator();

        public void ProcessRealFuelPrice(string[,] fuelArray)
        {
            Dictionary<string, decimal> fuelPrices = new Dictionary<string, decimal>();
            string country = null;
            decimal price = 0;
            for (int row = 0; row < fuelArray.GetLength(0); row++)
            {               
                for (int col = 0; col < fuelArray.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        country = fuelArray[row, col];
                    }
                    else if (col == 1)
                    {
                        price = decimal.Parse(fuelArray[row, col]);
                    }                            
                }

                if (!fuelPrices.ContainsKey(country))
                {
                    fuelPrices[country] = price;
                }
            }

            thirdPartyFuelCostCalculator.CalculatePrice(fuelPrices);
        }
    }
}
