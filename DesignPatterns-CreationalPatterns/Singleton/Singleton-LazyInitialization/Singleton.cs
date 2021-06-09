using System;

namespace Singleton_LazyInitialization
{
   public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=> new Singleton()); // Thread-safe

        private Singleton()
        {

        }

        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
