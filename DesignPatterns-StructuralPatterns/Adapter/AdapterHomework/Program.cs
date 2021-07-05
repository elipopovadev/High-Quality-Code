using AdapterHomework.Adaptee;
using AdapterHomework.Adapter;

namespace AdapterHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] fuelArray = new string[,]
            {
                { "Bulgaria", "2" },
                { "Australia", "3" },
                { "UK", "4" },
                { "US", "5" }
            };

            ITarget petrolAdapter = new FuelAdapter();
            petrolAdapter.ProcessRealFuelPrice(fuelArray);
        }
    }
}
