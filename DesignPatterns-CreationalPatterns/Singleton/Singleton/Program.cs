using System;

namespace Singleton
{
   public class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = new Singleton(); // only one object invoked with different print details
            s1.PrintDetails("This is first message");
            s1.PrintDetails("This is second message");
        }
    }
}
