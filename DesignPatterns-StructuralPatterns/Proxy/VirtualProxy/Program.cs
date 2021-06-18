using System;
using VirtualProxy.Proxy;

namespace VirtualProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage Image1 = new ProxyImage("Tiger Image");

            Console.WriteLine("Image1 calling DisplayImage first time:");
            Image1.DisplayImage(); // loading necessary

            Console.WriteLine("Image1 calling DisplayImage second time:");
            Image1.DisplayImage(); // loading unnecessary

            Console.WriteLine("Image1 calling DisplayImage third time:");
            Image1.DisplayImage(); // loading unnecessary
        }
    }
}
