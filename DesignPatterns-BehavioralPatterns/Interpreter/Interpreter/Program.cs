using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Language
            var domainLanguage = "order x20 '5L water bottles' from Bankq";
            Console.WriteLine(Order.Parse(domainLanguage));
        }       
    }
}
