using System.Collections.Generic;

namespace BugattiBuilder.Products
{
  public  interface IVehicle
    {
        public string Model { get; }
        public string Engine { get; }
        public string Transmission { get; }
        public string Body { get; }
        public List<string> Accessories { get; }
    }
}
