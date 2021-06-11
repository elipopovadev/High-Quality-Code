using System.Collections.Generic;

namespace BugattiBuilder.Products
{
    public class Vehicle : IVehicle
    {
        public Vehicle()
        {
            this.Accessories = new List<string>();
        }
        public string Model { get; set; }

        public string Engine { get; set; }

        public string Transmission { get; set; }

        public string Body { get; set; }

        public List<string> Accessories { get; set; }
    }
}
