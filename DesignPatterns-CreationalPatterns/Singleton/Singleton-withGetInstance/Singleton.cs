using System;

namespace Singleton_EagerInitialization
{
    public sealed class Singleton // always is sealed
    {
        private static readonly Singleton singleInstance = new Singleton(); // creates the Singleton instance at the time of application startup

        private Singleton() // always is private
        {
             
        }

        public static Singleton GetInstance // property with getter
        {
            get
            {
                return singleInstance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
