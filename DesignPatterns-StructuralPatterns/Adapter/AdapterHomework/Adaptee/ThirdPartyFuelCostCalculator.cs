using System;
using System.Collections.Generic;

namespace AdapterHomework.Adaptee
{
    public class ThirdPartyFuelCostCalculator
    {
        private Dictionary<string, decimal> fuelConstants = new Dictionary<string, decimal>() // they are different for different country
        {
           {"Bulgaria", 1},
           {"UK", 2},
           {"Australia", 2.1m},
           {"US", 3 }
        };

        public void CalculatePrice(Dictionary<string, decimal> fuelPrices)
        {
            foreach ((var country, var price) in fuelPrices)
            {
                if(country == "Bulgaria")
                {
                    Console.WriteLine($"Price in Bulgaria is: {fuelConstants["Bulgaria"] * price}");
                }

                else if(country == "UK")
                {
                    Console.WriteLine($"Price in UK is: {fuelConstants["UK"] * price}");
                }

                else if (country == "Australia")
                {
                    Console.WriteLine($"Price in Australia is: {fuelConstants["Australia"] * price}");
                }

                else if (country == "US")
                {
                    Console.WriteLine($"Price in US is: {fuelConstants["US"] * price}");
                }

                else
                {
                    Console.WriteLine("The Country is not valid!");
                }
            }
        }
    }
}
