using FlyweightHomework.ConcreteFlyweight;
using FlyweightHomework.FlyweightFactory;
using System;

namespace FlyweightHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                ToyotaAvensis toyota = (ToyotaAvensis)BodyFactory.GetCar("ToyotaAvensis");
                toyota.SetBody("Sedan");
            }

            for (int i = 0; i < 3; i++)
            {
                ToyotaAvensis toyota = (ToyotaAvensis)BodyFactory.GetCar("ToyotaAvensis");
                toyota.SetBody("Combi");
            }

            for (int i = 0; i < 3; i++)
            {
                VWGolf vw = (VWGolf)BodyFactory.GetCar("VWGolf");
                vw.SetBody("Sedan");
            }

            for (int i = 0; i < 3; i++)
            {
                VWGolf vw = (VWGolf)BodyFactory.GetCar("VWGolf");
                vw.SetBody("Combi");
            }
        }
    }
}
