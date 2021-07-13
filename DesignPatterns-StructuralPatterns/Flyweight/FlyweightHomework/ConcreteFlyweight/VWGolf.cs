using FlyweightHomework.FlyweightInterface;
using System;

namespace FlyweightHomework.ConcreteFlyweight
{
   public class VWGolf : IBody
    {
        private readonly string engine = "1.4 TSI BlueMotion";
        private readonly string gearbox = "seven-speed DSG gearbox";
        public VWGolf()
        {
            this.Engine = engine;
            this.Gearbox = gearbox;
        }

        public string Engine { get; private set; }
        public string Gearbox { get; private set; }
        public string Body { get; set; }

        public void SetBody(string body) // set body
        {
            this.Body = body;
            Console.WriteLine($"{typeof(VWGolf)} is setted to {body}");
        }
    }
}
