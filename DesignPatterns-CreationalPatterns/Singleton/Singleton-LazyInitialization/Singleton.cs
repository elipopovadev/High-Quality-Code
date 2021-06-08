using System;

namespace Singleton_EagerInitialization
{
   public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private Singleton()
        {

        }

        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
