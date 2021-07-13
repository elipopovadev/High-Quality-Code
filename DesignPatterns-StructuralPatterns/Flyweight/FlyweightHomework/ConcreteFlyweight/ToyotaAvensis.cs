using FlyweightHomework.FlyweightInterface;
using System;

namespace FlyweightHomework.ConcreteFlyweight
{
   public class ToyotaAvensis : IBody
    {
       private readonly string engine = "2.0-litre turbo-diesel";
       private readonly string gearbox = "Multidrive S transmission";
        public ToyotaAvensis()
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
            Console.WriteLine($"{typeof(ToyotaAvensis)} is setted to {body}");
        }
    }
}
