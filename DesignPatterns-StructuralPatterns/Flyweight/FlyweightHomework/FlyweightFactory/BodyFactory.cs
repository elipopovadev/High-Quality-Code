using FlyweightHomework.ConcreteFlyweight;
using FlyweightHomework.FlyweightInterface;
using System;
using System.Collections.Generic;

namespace FlyweightHomework.FlyweightFactory
{
    public static class BodyFactory
    {
        // dictionary collection object which will act as a cache for our application
        private static Dictionary<string, IBody> modelBodyTypeDictionary = new Dictionary<string, IBody>();

        public static IBody GetCar(string model)
        {
            IBody bodyType = null; // bodyType
            
            if (model == nameof(VWGolf))
            {
                if (modelBodyTypeDictionary.ContainsKey("VWGolf"))
                {
                    bodyType = modelBodyTypeDictionary[model];
                }

                else
                {
                    bodyType =  new VWGolf();
                    modelBodyTypeDictionary.Add("VWGolf", bodyType); // Creating VWGolf object without any body                
                }
            }

            else if (model == nameof(ToyotaAvensis))
            {
                if (modelBodyTypeDictionary.ContainsKey(model))
                {
                    bodyType = modelBodyTypeDictionary[model];
                }

                else
                {
                    bodyType = new ToyotaAvensis();
                    modelBodyTypeDictionary.Add("ToyotaAvensis", bodyType); // Creating ToyotaAvensis object without any body                
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
