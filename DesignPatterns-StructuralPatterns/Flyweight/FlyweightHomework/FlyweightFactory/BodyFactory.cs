using FlyweightHomework.ConcreteFlyweight;
using FlyweightHomework.FlyweightInterface;
using System;
using System.Collections.Generic;

namespace FlyweightHomework.FlyweightFactory
{
    public static class BodyFactory
    {
        // dictionary collection object which will act as a cache for our application
        private static Dictionary<string, IBody> modelBodyDictionary = new Dictionary<string, IBody>();

        public static IBody GetCar(string model)
        {
            IBody bodyType = null; // bodyType
            
            if (model == nameof(VWGolf))
            {
                if (modelBodyDictionary.ContainsKey("VWGolf"))
                {
                    bodyType = modelBodyDictionary[model];
                }

                else
                {
                    bodyType =  new VWGolf();
                    modelBodyDictionary.Add("VWGolf", bodyType); // Creating VWGolf object without any body                
                }
            }

            else if (model == nameof(ToyotaAvensis))
            {
                if (modelBodyDictionary.ContainsKey(model))
                {
                    bodyType = modelBodyDictionary[model];
                }

                else
                {
                    bodyType = new ToyotaAvensis();
                    modelBodyDictionary.Add("ToyotaAvensis", bodyType); // Creating ToyotaAvensis object without any body                
                }
            }

            else if (bodyType == null)
            {
                throw new ArgumentException("The body can not be null");
            }

            return bodyType;
        }
    }
}
