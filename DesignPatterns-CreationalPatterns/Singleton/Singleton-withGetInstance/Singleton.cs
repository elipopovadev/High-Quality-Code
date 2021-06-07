using System;

namespace Singleton_withGetInstance
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton() // always is private
        {

        }

        public static Singleton GetInstance // property with getter
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton(); // the instance is created only once
                }

                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
